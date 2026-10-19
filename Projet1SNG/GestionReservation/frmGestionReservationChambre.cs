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
    public partial class frmGestionReservationChambre : Form
    {
        public frmGestionReservationChambre()
        {
            InitializeComponent();
        }

        private void reservationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        }

        private void frmGestionReservationChambre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.reservation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationTableAdapter.Fill(this.bDB56Projet1SNGDataSet.reservation);

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.reservationRow uneRes =
                bDB56Projet1SNGDataSet.reservation.NewreservationRow();
            int idMax = 0;
            foreach (BDB56Projet1SNGDataSet.reservationRow ligne
                in bDB56Projet1SNGDataSet.reservation.Rows)
                if (ligne.RowState != DataRowState.Deleted &&
                    ligne.id_reservation > idMax)
                    idMax = ligne.id_reservation;

            uneRes.id_reservation = idMax + 1;
            frmAjouterReservation frmAjouter = new frmAjouterReservation();
            frmAjouter.uneReservation = uneRes;
            frmAjouter.ShowDialog();
            this.Close();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {

        }
    }
}
