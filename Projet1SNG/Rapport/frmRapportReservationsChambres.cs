using System;
using System.Data;
using System.Windows.Forms;

namespace Projet1SNG
{
    public partial class frmRapportReservationsChambres : Form
    {
        private bool chargementEnCours = false;

        public frmRapportReservationsChambres()
        {
            InitializeComponent();
        }

        //=========================================================
        // chargement du formulaire
        //=========================================================
        private void frmRapportReservationsChambres_Load(
            object sender, EventArgs e)
        {
            chargementEnCours = true;

            try
            {
                // charger la liste des chambres
                listeChambresRapportTableAdapter.Fill(
                    bDB56Projet1SNGDataSet.ListeChambresRapport
                );

                // aucune chambre selectionnee au depart
                cboChambre.SelectedIndex = -1;

                // vider l'historique
                bDB56Projet1SNGDataSet.HistoriqueReservationsChambre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors du chargement.\n\n" + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                chargementEnCours = false;
            }
        }
        //=========================================================
        // afficher l'historique de la chambre selectionnee
        //=========================================================
        private void AfficherHistorique()
        {
            if (chargementEnCours)
            {
                return;
            }

            // vider l'historique si aucune chambre est selectionnee
            if (cboChambre.SelectedIndex < 0 ||
                cboChambre.SelectedValue == null ||
                cboChambre.SelectedValue is DataRowView)
            {
                bDB56Projet1SNGDataSet
                    .HistoriqueReservationsChambre.Clear();

                return;
            }

            try
            {
                // recuperer le numero de chambre
                int idChambre =
                    Convert.ToInt32(cboChambre.SelectedValue);

                // charger les reservations de cette chambre
                historiqueReservationsChambreTableAdapter.Fill(
                    bDB56Projet1SNGDataSet
                        .HistoriqueReservationsChambre,
                    idChambre
                );
            }
            catch (Exception ex)
            {
                bDB56Projet1SNGDataSet
                    .HistoriqueReservationsChambre.Clear();

                MessageBox.Show(
                    "Erreur lors du chargement de l'historique.\n\n"
                    + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //=========================================================
        // changement de chambre
        //=========================================================
        private void cboChambre_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (!chargementEnCours)
            {
                AfficherHistorique();
            }
        }

        //=========================================================
        // selection de chambre
        //=========================================================
        private void cboChambre_SelectionChangeCommitted(
            object sender, EventArgs e)
        {
            AfficherHistorique();
        }

        //=========================================================
        // actualiser les donnees du rapport
        //=========================================================
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            // recharger les chambres et vider l'historique
            frmRapportReservationsChambres_Load(sender, e);
        }

        //=========================================================
        // fermer le rapport
        //=========================================================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}