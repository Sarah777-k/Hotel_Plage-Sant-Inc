using System;
using System.Data;
using System.Windows.Forms;

namespace Projet1SNG.GestionChambre
{
    public partial class frmAjouterChambre : Form
    {
        public bool ajoutConfirme = false;

        public BDB56Projet1SNGDataSet.chambreRow uneChambre;

        public BDB56Projet1SNGDataSet.type_chambreDataTable typesExistants;

        public frmAjouterChambre()
        {
            InitializeComponent();
        }

        //=========================================================
        // chargement du formulaire
        //=========================================================
        private void frmAjouterChambre_Load(object sender, EventArgs e)
        {
            if (uneChambre == null || typesExistants == null)
            {
                MessageBox.Show(
                    "Impossible de charger la chambre.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                this.Close();
                return;
            }

            // afficher le numéro genere
            txtIdChambre.Text =
                uneChambre.id_chambre.ToString();

            txtIdChambre.ReadOnly = true;

            // remplir la liste des types de chambres
            cboTypeChambre.DisplayMember = "description";
            cboTypeChambre.ValueMember = "id_typeChambre";
            cboTypeChambre.DataSource = typesExistants;

            // selectionner automatiquement le type choisi
            cboTypeChambre.SelectedValue =
                uneChambre.id_typeChambre;

            // empecher de changer le type selectionne
            cboTypeChambre.Enabled = false;

            // placer le curseur sur le premier champ
            txtEmplacement.Focus();
        }

        //=========================================================
        // validation des champs
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

                    champVide = cbo.SelectedIndex < 0;
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

            //mettre le focus sur le premier champ incorrect
            if (premierChampErreur != null)
            {
                premierChampErreur.Focus();
            }

            return valide;
        }

        //=========================================================
        // ajouter la chambre
        //=========================================================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps())
            {
                return;
            }

            // recuperer les donnees saisies
            uneChambre.emplacement =
                txtEmplacement.Text.Trim();

            uneChambre.decoration =
                txtDecoration.Text.Trim();

            //le type provient de la selection du formulaire principal
            uneChambre.id_typeChambre =
                Convert.ToInt32(cboTypeChambre.SelectedValue);

            ajoutConfirme = true;

            this.Close();
        }

        //=========================================================
        // Fermer / Annuler
        //=========================================================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            ajoutConfirme = false;

            errMessage.Clear();

            this.Close();
        }
    }
}