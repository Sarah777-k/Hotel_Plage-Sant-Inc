using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG.Rapport
{
    public partial class frmRapportSoinsJournaliersAssistant : Form
    {
        public frmRapportSoinsJournaliersAssistant()
        {
            InitializeComponent();
        }


        private void frmRapportSoinsJournaliersAssistant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet1SNGDataSet.SoinsRecu' table. You can move, or remove it, as needed.
            this.soinsRecuTableAdapter.Fill(this.bDB56Projet1SNGDataSet.SoinsRecu);
            // TODO: This line of code loads data into the 'bDB56Projet1SNGDataSet.AssistantSoins' table. You can move, or remove it, as needed.
            this.assistantSoinsTableAdapter.Fill(this.bDB56Projet1SNGDataSet.AssistantSoins);
            // TODO: This line of code loads data into the 'bDB56Projet1SNGDataSet.SoinsRecu' table. You can move, or remove it, as needed.
            this.soinsRecuTableAdapter.Fill(this.bDB56Projet1SNGDataSet.SoinsRecu);


        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void assistantSoinsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantSoinsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        }
    }
}
