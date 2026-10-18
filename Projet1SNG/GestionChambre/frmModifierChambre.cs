using System;
using System.Windows.Forms;

namespace Projet1SNG.GestionChambre
{
    public partial class frmModifierChambre : Form
    {
        public BDB56Projet1SNGDataSet.chambreRow uneChambre;

        public bool modificationConfirmee = false;

        public frmModifierChambre()
        {
            InitializeComponent();
        }

        //=========================================================
        // Chargement
        //=========================================================
        private void frmModifierChambre_Load(
            object sender, EventArgs e)
        {
            if (uneChambre == null)
            {
                this.Close();
                return;
            }

            
            this.type_chambreTableAdapter.Fill(
                this.bDB56Projet1SNGDataSet.type_chambre
            );

            // Afficher les données de la chambre reçue.
            txtIdChambre.Text =
                uneChambre.id_chambre.ToString();

            txtEmplacement.Text =
                uneChambre.emplacement;

            txtDecoration.Text =
                uneChambre.decoration;

            // Sélectionner le type ACTUEL de cette chambre.
            cboTypeChambre.SelectedValue =
                uneChambre.id_typeChambre;
        }

        //=========================================================
        // Validation
        //=========================================================
        private bool ValiderChamps()
        {
            bool valide = true;
            Control premierChampErreur = null;

            errMessage.Clear();

            Control[] champs =
            {
                txtEmplacement,
                txtDecoration,
                cboTypeChambre
            };

            string[] messages =
            {
                "L'emplacement est obligatoire.",
                "La décoration est obligatoire.",
                "Le type de chambre est obligatoire."
            };

            for (int i = 0; i < champs.Length; i++)
            {
                bool champVide = false;

                if (champs[i] is TextBox)
                {
                    TextBox txt = (TextBox)champs[i];

                    champVide =
                        string.IsNullOrWhiteSpace(txt.Text);
                }
                else if (champs[i] is ComboBox)
                {
                    ComboBox cbo = (ComboBox)champs[i];

                    champVide =
                        cbo.SelectedIndex < 0 ||
                        cbo.SelectedValue == null;
                }

                if (champVide)
                {
                    errMessage.SetError(
                        champs[i],
                        messages[i]
                    );

                    if (premierChampErreur == null)
                    {
                        premierChampErreur = champs[i];
                    }

                    valide = false;
                }
            }

            if (premierChampErreur != null)
            {
                premierChampErreur.Focus();
            }

            return valide;
        }

        //=========================================================
        // Modifier
        //=========================================================
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps())
            {
                return;
            }

            // Modifier exactement la chambre transmise.
            uneChambre.emplacement =
                txtEmplacement.Text.Trim();

            uneChambre.decoration =
                txtDecoration.Text.Trim();

            // Le type peut être changé.
            uneChambre.id_typeChambre =
                Convert.ToInt32(cboTypeChambre.SelectedValue);

            modificationConfirmee = true;

            this.Close();
        }

        //=========================================================
        // Fermer / Annuler
        //=========================================================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            modificationConfirmee = false;

            errMessage.Clear();

            this.Close();
        }
    }
}