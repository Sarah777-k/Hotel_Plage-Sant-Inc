using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet1SNG.GestionReservation
{
    public partial class frmGestionReservationChambre : Form
    {
        private bool conflitAcces = false;

        public frmGestionReservationChambre()
        {
            InitializeComponent();
        }
        //=======================================================================
        // chargement du formulaire : remplir le dataset et gerer les conflits d'acces
        //=======================================================================
        private void frmGestionReservationChambre_Load(object sender, EventArgs e)
        {
            reservationTableAdapter.Fill(bDB56Projet1SNGDataSet.reservation);

            // gerer les conflits d'acces comme dans le labo 6
            reservationTableAdapter.Adapter.RowUpdated +=
                new SqlRowUpdatedEventHandler(reservationTableAdapter_RowUpdated);
        }
        //=======================================================================
        // gestion des conflits d'acces concurrentiel lors de l'enregistrement
        //=======================================================================
        private void reservationTableAdapter_RowUpdated(
            object sender, SqlRowUpdatedEventArgs e)
        {
            // traiter les suppressions ou modifications refusees
            if (e.RecordsAffected == 0 &&
                (e.StatementType == StatementType.Delete ||
                 e.StatementType == StatementType.Update) &&
                (e.Errors == null || e.Errors is DBConcurrencyException))
            {
                string numero =
                    e.Row["id_reservation", DataRowVersion.Original].ToString();

                MessageBox.Show(
                    "Conflit d'accès concurrentiel pour la réservation " + numero +
                    ". Cet enregistrement ne sera pas sauvegardé.",
                    "Conflit d'accès", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                conflitAcces = true;
                e.Status = UpdateStatus.Continue;
            }
        }
        //=======================================================================
        // ajouter une reservation : generer un id unique, verifier la disponibilite de la chambre, enregistrer dans sql server
        //=======================================================================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // recharger les numeros avant de generer le prochain
                reservationTableAdapter.Fill(bDB56Projet1SNGDataSet.reservation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de charger les réservations.\n\n" +
                    ex.Message, "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            BDB56Projet1SNGDataSet.reservationRow uneRes =
                bDB56Projet1SNGDataSet.reservation.NewreservationRow();
            //ajouter un id_reservation unique
            int idMax = 0;
            foreach (BDB56Projet1SNGDataSet.reservationRow ligne
                in bDB56Projet1SNGDataSet.reservation.Rows)
            {
                if (ligne.RowState != DataRowState.Deleted &&
                    ligne.id_reservation > idMax)
                    idMax = ligne.id_reservation;
            }

            uneRes.id_reservation = idMax + 1;
            int numeroReservation = uneRes.id_reservation;

            using (frmAjouterReservation frmAjouter = new frmAjouterReservation())
            {
                frmAjouter.uneReservation = uneRes;
                frmAjouter.StartPosition = FormStartPosition.Manual;
                frmAjouter.Location = this.Location;
                frmAjouter.ShowDialog(this);

                if (!frmAjouter.ajoutConfirme)
                    return;

                try
                {
                    // reverifier la disponibilite juste avant l'enregistrement
                    BDB56Projet1SNGDataSet.reservationDataTable reservations =
                        reservationTableAdapter.GetData();

                    foreach (BDB56Projet1SNGDataSet.reservationRow ligne
                        in reservations.Rows)
                    {
                        if (ligne.id_chambre == uneRes.id_chambre &&
                            uneRes.dateArrivee.Date < ligne.dateDepart.Date &&
                            uneRes.dateDepart.Date > ligne.dateArrivee.Date)
                        {
                            MessageBox.Show(
                                "Cette chambre vient d'être réservée pour la période choisie. " +
                                "Actualisez les données et réessayez.",
                                "Chambre indisponible", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // enregistrer la nouvelle reservation dans sql server
                    bDB56Projet1SNGDataSet.reservation.AddreservationRow(uneRes);
                    reservationBindingSource.EndEdit();
                    reservationTableAdapter.Update(bDB56Projet1SNGDataSet.reservation);
                    reservationBindingSource.ResetBindings(false);

                    MessageBox.Show("La réservation " + numeroReservation +
                        " a été ajoutée.", "Ajout", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (uneRes.RowState == DataRowState.Added)
                        uneRes.RejectChanges();

                    MessageBox.Show("Impossible d'ajouter la réservation. " +
                        "Les données ont peut-être changé.\n\n" + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //=======================================================================
        // supprimer une reservation : verifier que la date d'arrivee n'est pas passee, demander confirmation, supprimer et enregistrer dans sql server
        //=======================================================================
        private void btnSup_Click(object sender, EventArgs e)
        {
            // recuperer la reservation choisie dans la grille liee
            DataRowView ligne = reservationBindingSource.Current as DataRowView;
            BDB56Projet1SNGDataSet.reservationRow uneRes =
                ligne == null ? null :
                ligne.Row as BDB56Projet1SNGDataSet.reservationRow;

            if (uneRes == null)
            {
                MessageBox.Show("Veuillez sélectionner une réservation.",
                    "Suppression", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // enregistrer le numero avant la suppression de la ligne
            int numeroReservation = uneRes.id_reservation;

            // interdire l'annulation d'un sejour deja commence
            if (uneRes.dateArrivee.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Impossible d'annuler cette réservation : " +
                    "la date d'arrivée est antérieure à aujourd'hui.",
                    "Suppression impossible", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Supprimer la réservation " +
                numeroReservation + " ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes)
                return;

            try
            {
                // supprimer et enregistrer immediatement
                uneRes.Delete();
                conflitAcces = false;
                reservationTableAdapter.Update(bDB56Projet1SNGDataSet.reservation);

                if (conflitAcces)
                {
                    // ne pas conserver une suppression refusee en memoire
                    if (uneRes.RowState == DataRowState.Deleted)
                        uneRes.RejectChanges();
                    return;
                }

                reservationBindingSource.ResetBindings(false);
                MessageBox.Show("La réservation " + numeroReservation +
                    " a été supprimée.", "Suppression", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (uneRes.RowState == DataRowState.Deleted)
                    uneRes.RejectChanges();

                if (!conflitAcces)
                {
                    string message = ex is DBConcurrencyException
                        ? "Cette réservation a été modifiée ou supprimée par un autre utilisateur."
                        : "Impossible de supprimer la réservation.\n\n" + ex.Message;

                    MessageBox.Show(message, "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
        //=======================================================================
        // actualiser les reservations : recharger le dataset depuis sql server
        //=======================================================================
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            try
            {
                // annuler les modifications locales avant le rechargement
                bDB56Projet1SNGDataSet.reservation.RejectChanges();
                reservationTableAdapter.Fill(bDB56Projet1SNGDataSet.reservation);
                conflitAcces = false;

                MessageBox.Show("Les réservations ont été actualisées.",
                    "Actualisation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'actualisation.\n\n" +
                    ex.Message, "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        //=======================================================================
        // fermer le formulaire
        //=======================================================================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
