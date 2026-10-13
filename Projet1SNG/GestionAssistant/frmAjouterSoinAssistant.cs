using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG.GestionAssistant
{
    public partial class frmAjouterSoinAssistant : Form
    {
        // Numéro de l'assistant sélectionné.
        public int idAssistant;

        // Nouvelle association assistant-soin.
        public BDB56Projet1SNGDataSet.assistant_soinRow unAssistantSoin;

        // Permet de savoir si l'ajout est confirmé.
        public bool ajoutConfirme = false;
        public frmAjouterSoinAssistant()
        {
            InitializeComponent();
        }


        private void frmAjouterSoinAssistant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet1SNGDataSet.soin' table. You can move, or remove it, as needed.
            this.soinTableAdapter.Fill(this.bDB56Projet1SNGDataSet.soin);
            // TODO: This line of code loads data into the 'bDB56Projet1SNGDataSet.DataTableAssistantSoin' table. You can move, or remove it, as needed.
            lblAssistant.Text =
             "a l'assistant " + idAssistant;
        }
        //=========================================================
        // Validation
        //=========================================================
        private bool ValiderChamps()
        {
            errMessage.Clear();

            if (cboSoin.SelectedIndex == -1)
            {
                errMessage.SetError(
                    cboSoin,
                    "Veuillez sélectionner un soin."
                );

                return false;
            }

            return true;
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps())
            {
                return;
            }

            int idSoin =
                Convert.ToInt32(cboSoin.SelectedValue);

            unAssistantSoin.id_assistant =
                idAssistant;

            unAssistantSoin.id_soin =
                idSoin;

            ajoutConfirme = true;

            Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            ajoutConfirme = false;
            errMessage.Clear();
            Close();
        }

       
    }
}
