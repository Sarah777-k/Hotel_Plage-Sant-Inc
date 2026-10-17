using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG.GestionChambre
{
    public partial class frmGestionChambre : Form
    {
        public frmGestionChambre()
        {
            InitializeComponent();
        }

        private void chambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        }

        private void frmGestionChambre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.type_chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.type_chambreTableAdapter.Fill(this.bDB56Projet1SNGDataSet.type_chambre);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.bDB56Projet1SNGDataSet.chambre);

        }

        private void btnSupType_Click(object sender, EventArgs e)
        {

        }

        private void btnModifierType_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterType_Click(object sender, EventArgs e)
        {
            
         }

        private void btnAjouterChambre_Click(object sender, EventArgs e)
        {
            frmAjouterChambre fAC = new frmAjouterChambre();
            fAC.Location = this.Location;
            fAC.ShowDialog();
        }
    }
}
