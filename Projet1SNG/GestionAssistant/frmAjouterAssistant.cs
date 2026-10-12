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
    public partial class frmAjouterAssistant : Form
    {
        // Ligne créée dans FrmGestionAssistants
        // et transmise à ce formulaire.
        public BDB56Projet1SNGDataSet.assistantRow unAssistant;

        // Permet au formulaire principal de savoir
        // si l'utilisateur a réellement enregistré l'ajout.
        public bool ajoutConfirme = false;

        public frmAjouterAssistant()
        {
            InitializeComponent();
        }

        private void assistantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        }

        private void frmAjouterAssistant_Load(object sender, EventArgs e)
        {
            // Sécurité : normalement unAssistant doit avoir été
            // créé dans FrmGestionAssistants avant l'ouverture.
            if (unAssistant == null)
            {
                MessageBox.Show(
                    "Impossible de créer l'assistant.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Close();
                return;
            }

            // Le numéro a déjà été généré dans FrmGestionAssistants.
            txtIdAssistant.Text =
                unAssistant.id_assistant.ToString();

            // Le numéro ne peut jamais être modifié.
            txtIdAssistant.ReadOnly = true;

            // Positionner le curseur sur le premier champ.
            txtPrenom.Focus();
        }
        private bool ValiderChamps()
        {
            bool valide = true;

            // Effacer les anciens messages d'erreur.
            errMessage.Clear();

            // Les trois champs obligatoires.
            TextBox[] champs =
            {
                txtNom,
                txtNom,
                txtSpecialites
            };

            // Nom à afficher dans le message d'erreur.
            string[] nomsChamps =
            {
                "Le prénom",
                "Le nom",
                "Les spécialités"
            };

            // Même validation pour tous les champs obligatoires.
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

            // Remarques n'est pas vérifié :
            // ce champ est facultatif.

            return valide;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Vérifier tous les champs avant de continuer.
            if (!ValiderChamps())
            {
                return;
            }

            // Affecter les valeurs à la ligne créée
            // dans FrmGestionAssistants.
            unAssistant.prenom =
                txtPrenom.Text.Trim();

            unAssistant.nom =
                txtNom.Text.Trim();

            unAssistant.specialite =
                txtSpecialites.Text.Trim();

            // Remarques peut être vide.
            unAssistant.remarque =
                txtRemarques.Text.Trim();

            // Indiquer au formulaire principal
            // que l'ajout a été confirmé.
            ajoutConfirme = true;

            Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            // Aucun ajout ne sera effectué.
            ajoutConfirme = false;

            errMessage.Clear();
            Close();
        }
    }
}
