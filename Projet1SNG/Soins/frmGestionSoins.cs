using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG.Soins
{
    public partial class frmGestionSoins : Form
    {
        public frmGestionSoins()
        {
            InitializeComponent();
        }

        //private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.soinBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        //}

        private void frmGestionSoins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.type_soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.type_soinTableAdapter.Fill(this.bDB56Projet1SNGDataSet.type_soin);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bDB56Projet1SNGDataSet.soin);

        }
    }
}
