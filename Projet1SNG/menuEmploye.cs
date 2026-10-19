using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG
{
    public partial class menuEmploye : Form
    {
        public string noEmploye;
        public menuEmploye()
        {
            InitializeComponent();
        }

        private void assistantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bDB56Projet1SNGDataSet.assistant);
            txtIdNumber.Text = "Numéros d'employé: " + noEmploye;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmConnexion frmCo = new frmConnexion();
            frmCo.Show();
            this.Hide();
        }

        private void btnReserverChambre_Click(object sender, EventArgs e)
        {
            GestionReservation.frmGestionReservationChambre frmGestionReservationChambre = new GestionReservation.frmGestionReservationChambre();
            frmGestionReservationChambre.Show();
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
           G
        }
    }
}
