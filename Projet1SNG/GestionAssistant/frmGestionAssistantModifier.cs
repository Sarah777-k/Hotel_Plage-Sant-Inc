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
    public partial class frmGestionAssistantModifier : Form
    {
        // Assistant sélectionné dans FrmGestionAssistants
        public BDB56Projet1SNGDataSet.assistantRow unAssistant;

        // Permet de savoir si l'utilisateur
        // a réellement confirmé la modification.
        public bool modificationConfirmee = false;

        public frmGestionAssistantModifier()
        {
            InitializeComponent();
        }

        private void assistantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        }

        private void frmGestionAssistantModifier_Load(object sender, EventArgs e)
        {
            // Vérification de sécurité.
            if (unAssistant == null)
            {
                MessageBox.Show(
                    "Aucun assistant à modifier.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Close();
                return;
            }
                // Charger les données de l'assistant sélectionné.
                txtIdAssistant.Text =
                    unAssistant.id_assistant.ToString();

                txtPrenom.Text =
                    unAssistant.prenom;

                txtNom.Text =
                    unAssistant.nom;

                txtSpecialite.Text =
                    unAssistant.specialite;

                // Remarques peut être NULL.
                txtRemarque.Text =
                    Convert.ToString(unAssistant["remarque"]);

                // Le numéro d'assistant ne peut pas être modifié.
                txtIdAssistant.ReadOnly = true;

                txtPrenom.Focus();
        }
        private bool ValiderChamps()
        {
            bool valide = true;

            // Effacer les anciennes erreurs.
            errMessage.Clear();

            TextBox[] champs =
            {
                txtPrenom,
                txtNom,
                txtSpecialite
            };

            string[] nomsChamps =
            {
                "Le prénom",
                "Le nom",
                "Les spécialités"
            };

            for (int i = 0; i < champs.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(champs[i].Text))
                {
                    errMessage.SetError(
                        champs[i],
                        nomsChamps[i] + " ne peut pas être vide."
                    );

                    valide = false;
                }
            }

            // Remarques est facultatif.

            return valide;
        }
        //modifie le DataSet en mémoire
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps())
            {
                return;
            }

            // Modifier la ligne uniquement lorsque
            // l'utilisateur confirme avec Enregistrer.
            unAssistant.prenom =
                txtPrenom.Text.Trim();

            unAssistant.nom =
                txtNom.Text.Trim();

            unAssistant.specialite =
                txtSpecialite.Text.Trim();


            // Remarques est facultatif
            if (string.IsNullOrWhiteSpace(txtRemarque.Text))
            {
                unAssistant["remarques"] = DBNull.Value;
            }
            else
            {
                unAssistant.remarque =
                    txtRemarque.Text.Trim();
            }


            modificationConfirmee = true;

            Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            // Aucun ajout ne sera effectué.
            modificationConfirmee = false;
            Close();
        }
    }
}
