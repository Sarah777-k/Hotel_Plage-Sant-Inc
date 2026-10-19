using System;
using System.Windows.Forms;

namespace Projet1SNG.GestionAssistant
{
    public partial class frmAjouterAssistant : Form
    {
        public BDB56Projet1SNGDataSet.assistantRow unAssistant;
        public bool ajoutConfirme = false;

        public frmAjouterAssistant()
        {
            InitializeComponent();
            
        }

        private void frmAjouterAssistant_Load(object sender, EventArgs e)
        {
            if (unAssistant == null)
            {
                MessageBox.Show("Impossible de créer l'assistant.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            txtIdAssistant.Text = unAssistant.id_assistant.ToString();
        }

        private bool ValiderChamps()
        {
            errMessage.Clear();
            Control premierChampErreur = null;

            TextBox[] champs = { txtPrenom, txtNom, txtSpecialites };
            string[] messages =
            {
                "Le prénom est obligatoire.",
                "Le nom est obligatoire.",
                "La spécialité est obligatoire."
            };

            for (int i = 0; i < champs.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(champs[i].Text))
                {
                    errMessage.SetError(champs[i], messages[i]);
                    if (premierChampErreur == null)
                        premierChampErreur = champs[i];
                }
            }

            if (premierChampErreur != null)
            {
                premierChampErreur.Focus();
                return false;
            }

            return true;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            // remplir la ligne transmise par le formulaire principal
            unAssistant.prenom = txtPrenom.Text.Trim();
            unAssistant.nom = txtNom.Text.Trim();
            unAssistant.specialite = txtSpecialites.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtRemarques.Text))
                unAssistant["remarque"] = DBNull.Value;
            else
                unAssistant.remarque = txtRemarques.Text.Trim();

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
