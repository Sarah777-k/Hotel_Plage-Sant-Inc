using System;
using System.Windows.Forms;

namespace Projet1SNG
{
    public partial class frmGestionAssistantModifier : Form
    {
        public BDB56Projet1SNGDataSet.assistantRow unAssistant;
        public bool modificationConfirmee = false;

        public frmGestionAssistantModifier()
        {
            InitializeComponent();

        }

        private void frmGestionAssistantModifier_Load(object sender, EventArgs e)
        {
            if (unAssistant == null)
            {
                MessageBox.Show("Aucun assistant à modifier.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            txtIdAssistant.Text = unAssistant.id_assistant.ToString();
            txtPrenom.Text = unAssistant.prenom;
            txtNom.Text = unAssistant.nom;
            txtSpecialite.Text = unAssistant.specialite;
            txtRemarque.Text = Convert.ToString(unAssistant["remarque"]);
        }

        private bool ValiderChamps()
        {
            errMessage.Clear();
            Control premierChampErreur = null;

            TextBox[] champs = { txtPrenom, txtNom, txtSpecialite };
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            // modifier uniquement la ligne transmise par le formulaire principal
            unAssistant.prenom = txtPrenom.Text.Trim();
            unAssistant.nom = txtNom.Text.Trim();
            unAssistant.specialite = txtSpecialite.Text.Trim();

            // la colonne remarque peut etre nulle
            if (string.IsNullOrWhiteSpace(txtRemarque.Text))
                unAssistant["remarque"] = DBNull.Value;
            else
                unAssistant.remarque = txtRemarque.Text.Trim();

            modificationConfirmee = true;
            Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            modificationConfirmee = false;
            errMessage.Clear();
            Close();
        }
    }
}
