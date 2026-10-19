using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG.GestionReservation
{
    public partial class frmAjouterReservation : Form
    {
        public bool ajoutConfirme = false;
        public BDB56Projet1SNGDataSet.reservationRow uneReservation;
        public BDB56Projet1SNGDataSet.chambreDataTable chambre;
        public frmAjouterReservation()
        {
            InitializeComponent();
        }


        private void frmAjouterReservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.InfoClientReservation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.infoClientReservationTableAdapter.Fill(this.bDB56Projet1SNGDataSet.InfoClientReservation);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.ReservationTypeChambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationTypeChambreTableAdapter.Fill(this.bDB56Projet1SNGDataSet.ReservationTypeChambre);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.type_chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.type_chambreTableAdapter.Fill(this.bDB56Projet1SNGDataSet.type_chambre);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.bDB56Projet1SNGDataSet.chambre);
            if (uneReservation == null)
            {
                MessageBox.Show(
                  "Impossible de charger la réservation.",
                  "Erreur",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
              );

                this.Close();
                return;
            }
            txtReservation.Text = uneReservation.id_reservation.ToString();
          
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.reservation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationTableAdapter.Fill(this.bDB56Projet1SNGDataSet.reservation);


        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            ajoutConfirme = false;
            errMessage.Clear();
            this.Close();
        }
    }
}
