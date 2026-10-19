using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Projet1SNG.GestionAssistant
{
    public partial class frmAjouterSoinAssistant : Form
    {
        public int idAssistant;
        public BDB56Projet1SNGDataSet.assistant_soinRow unAssistantSoin;
        public bool ajoutConfirme = false;

        public frmAjouterSoinAssistant()
        {
            InitializeComponent();
        }

        //=========================================================
        // charger seulement les soins non offerts par cet assistant
        //=========================================================
        private void frmAjouterSoinAssistant_Load(object sender, EventArgs e)
        {
            if (unAssistantSoin == null)
            {
                MessageBox.Show("Impossible de préparer le soin.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            try
            {
                lblAssistant.Text = "à l'assistant " + idAssistant;
                cboSoin.DropDownStyle = ComboBoxStyle.DropDownList;

                // creer un affichage avec le numero et la description du soin
                bDB56Projet1SNGDataSet.soin.Columns.Add(
                    "affichageSoin", typeof(string),
                    "Convert(id_soin, 'System.String') + ' - ' + description");

                soinTableAdapter.Fill(bDB56Projet1SNGDataSet.soin);
                cboSoin.DisplayMember = "affichageSoin";
                cboSoin.ValueMember = "id_soin";

                // recuperer les associations actuelles dans sql server
                BDB56Projet1SNGDataSetTableAdapters.assistant_soinTableAdapter
                    adapter = new BDB56Projet1SNGDataSetTableAdapters.assistant_soinTableAdapter();

                BDB56Projet1SNGDataSet.assistant_soinDataTable associations =
                    adapter.GetData();

                List<string> idsSoinsOfferts = new List<string>();

                foreach (BDB56Projet1SNGDataSet.assistant_soinRow ligne
                    in associations.Rows)
                {
                    if (ligne.id_assistant == idAssistant)
                    {
                        idsSoinsOfferts.Add(ligne.id_soin.ToString());
                    }
                }

                // masquer les soins deja offerts par l'assistant
                if (idsSoinsOfferts.Count > 0)
                {
                    soinBindingSource.Filter = "id_soin NOT IN (" +
                        string.Join(",", idsSoinsOfferts) + ")";
                }
                else
                {
                    soinBindingSource.RemoveFilter();
                }

                cboSoin.SelectedIndex = -1;

                if (soinBindingSource.Count == 0)
                {
                    btnAjouter.Enabled = false;
                    MessageBox.Show(
                        "Aucun soin supplémentaire n'est disponible pour cet assistant.",
                        "Ajout impossible", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                btnAjouter.Enabled = false;
                MessageBox.Show(
                    "Impossible de charger les soins disponibles.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //=========================================================
        // validation du soin choisi
        //=========================================================
        private bool ValiderChamps()
        {
            errMessage.Clear();

            if (cboSoin.SelectedIndex < 0 || cboSoin.SelectedValue == null)
            {
                errMessage.SetError(cboSoin, "Veuillez sélectionner un soin.");
                cboSoin.Focus();
                return false;
            }

            return true;
        }

        //=========================================================
        // confirmer l'ajout du soin
        //=========================================================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            unAssistantSoin.id_assistant = idAssistant;
            unAssistantSoin.id_soin = Convert.ToInt32(cboSoin.SelectedValue);

            ajoutConfirme = true;
            Close();
        }

        //=========================================================
        // fermer sans ajouter de soin
        //=========================================================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            ajoutConfirme = false;
            errMessage.Clear();
            Close();
        }
    }
}
