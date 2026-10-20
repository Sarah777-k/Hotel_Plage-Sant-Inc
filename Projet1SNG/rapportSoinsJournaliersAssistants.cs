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
    public partial class rapportSoinsJournaliersAssistants : Form
    {
        public rapportSoinsJournaliersAssistants()
        {
            InitializeComponent();
        }

        private void rapportSoinsJournaliersAssistants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet1SNGDataSet.soinsJournaliersAssistantsDescription' table. You can move, or remove it, as needed.
            this.soinsJournaliersAssistantsDescriptionTableAdapter.Fill(this.bDB56Projet1SNGDataSet.soinsJournaliersAssistantsDescription);
            // TODO: This line of code loads data into the 'bDB56Projet1SNGDataSet.soinsJournaliersAssistants' table. You can move, or remove it, as needed.
            this.soinsJournaliersAssistantsTableAdapter.Fill(this.bDB56Projet1SNGDataSet.soinsJournaliersAssistants);

        }
    }
}
