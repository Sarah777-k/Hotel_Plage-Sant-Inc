using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Projet1SNG.GestionReservation
{
    public partial class frmAjouterReservation : Form
    {
        public bool ajoutConfirme = false;
        // reservation transmise par le formulaire principal
        public BDB56Projet1SNGDataSet.reservationRow uneReservation;

        public frmAjouterReservation()
        {
            InitializeComponent();
        }
        //=======================================================================
        // charger les donnees du formulaire et initialiser les controles
        //=======================================================================
        private void frmAjouterReservation_Load(object sender, EventArgs e)
        {
            if (uneReservation == null)
            {
                MessageBox.Show("Impossible de charger la réservation.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // charger la liste des clients et des chambres
            infoClientReservationTableAdapter.Fill(
                bDB56Projet1SNGDataSet.InfoClientReservation);
            reservationTypeChambreTableAdapter.Fill(
                bDB56Projet1SNGDataSet.ReservationTypeChambre);

            // afficher le numero genere dans le formulaire principal
            txtReservation.Text = uneReservation.id_reservation.ToString();

            // formater les trois colonnes de prix en dollars
            CultureInfo culture = CultureInfo.GetCultureInfo("en-CA");
            DataGridViewColumn[] colonnesPrix =
            {
                dataGridViewTextBoxColumn4,
                dataGridViewTextBoxColumn5,
                dataGridViewTextBoxColumn6
            };

            foreach (DataGridViewColumn colonne in colonnesPrix)
            {
                colonne.DefaultCellStyle.Format = "C2";
                colonne.DefaultCellStyle.FormatProvider = culture;
            }


            dateDepart.Value = DateTime.Today.AddDays(1);
            cboClient.SelectedIndex = -1;
            dgvReservationChambre.ClearSelection(); //deselectionner toutes les lignes du DataGridView chambre
            dgvReservationChambre.CurrentCell = null;
        }
        //=======================================================================
        // valider les champs du formulaire avant d'ajouter la reservation
        //=======================================================================
        private bool ValiderChamps()
        {
            errMessage.Clear();
            Control premierChampErreur = null;

            // verifier la selection du client
            if (cboClient.SelectedIndex < 0 || cboClient.SelectedValue == null)
            {
                errMessage.SetError(cboClient, "Veuillez sélectionner un client.");
                premierChampErreur = cboClient;
            }

            // verifier la selection d'une chambre
            if (dgvReservationChambre.CurrentRow == null ||
                dgvReservationChambre.CurrentRow.IsNewRow ||
                !dgvReservationChambre.CurrentRow.Selected)
            {
                errMessage.SetError(dgvReservationChambre,
                    "Veuillez sélectionner une chambre.");
                if (premierChampErreur == null)
                    premierChampErreur = dgvReservationChambre;
            }

            // verifier le nombre de personnes
            if (nbPersonne.Value < 1 || nbPersonne.Value > 6)
            {
                errMessage.SetError(nbPersonne,
                    "Le nombre de personnes doit être compris entre 1 et 6.");
                if (premierChampErreur == null)
                    premierChampErreur = nbPersonne;
            }

            // verifier les dates du sejour
            if (dateArrivee.Value.Date < DateTime.Today)
            {
                errMessage.SetError(dateArrivee,
                    "La date d'arrivée ne peut pas être passée.");
                if (premierChampErreur == null)
                    premierChampErreur = dateArrivee;
            }

            if (dateDepart.Value.Date <= dateArrivee.Value.Date)
            {
                errMessage.SetError(dateDepart,
                    "La date de départ doit suivre la date d'arrivée.");
                if (premierChampErreur == null)
                    premierChampErreur = dateDepart;
            }

            if (premierChampErreur != null)
            {
                premierChampErreur.Focus();
                return false;
            }

            DataRowView ligneChambre =
                dgvReservationChambre.CurrentRow.DataBoundItem as DataRowView;

            if (ligneChambre == null)
            {
                errMessage.SetError(dgvReservationChambre,
                    "Veuillez sélectionner une chambre valide.");
                dgvReservationChambre.Focus();
                return false;
            }

            int idChambre = Convert.ToInt32(ligneChambre["id_chambre"]);
            DateTime arrivee = dateArrivee.Value.Date;
            DateTime depart = dateDepart.Value.Date;

            try
            {
                // verifier la disponibilite avec les reservations en base
                BDB56Projet1SNGDataSet.reservationDataTable reservations =
                    reservationTableAdapter.GetData();

                foreach (BDB56Projet1SNGDataSet.reservationRow ligne
                    in reservations.Rows)
                {
                    if (ligne.id_chambre == idChambre &&
                        arrivee < ligne.dateDepart.Date &&
                        depart > ligne.dateArrivee.Date)
                    {
                        errMessage.SetError(dgvReservationChambre,
                            "Cette chambre est déjà réservée pour cette période.");
                        dgvReservationChambre.Focus();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de vérifier la disponibilité.\n\n" +
                    ex.Message, "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        //=======================================================================
        // ajouter la reservation si tous les champs sont valides
        //=======================================================================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps())
                return;

            DataRowView ligneChambre =
                dgvReservationChambre.CurrentRow.DataBoundItem as DataRowView;

            // remplir la reservation transmise par le formulaire principal
            uneReservation.id_client = Convert.ToInt32(cboClient.SelectedValue);
            uneReservation.id_chambre =
                Convert.ToInt32(ligneChambre["id_chambre"]);
            uneReservation.dateArrivee = dateArrivee.Value.Date;
            uneReservation.dateDepart = dateDepart.Value.Date;
            uneReservation.nbPersonnes = Convert.ToInt32(nbPersonne.Value);

            ajoutConfirme = true;
            this.Close();
        }
        //=======================================================================
        // fermeture du formulaire sans ajouter de reservation
        //=======================================================================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            ajoutConfirme = false;
            errMessage.Clear();
            this.Close();
        }
    }
}
