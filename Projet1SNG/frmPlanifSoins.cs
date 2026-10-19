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
    public partial class frmPlanifSoins : Form
    {
        public frmPlanifSoins()
        {
            InitializeComponent();
        }


        private void frmPlanifSoins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.planif_soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.planif_soinTableAdapter.Fill(this.bDB56Projet1SNGDataSet.planif_soin);

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void btnPlanifier_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

        }
    }
}
