using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Projet1SNG.GestionChambre
{
    public partial class frmModifierTypeChambre : Form
    {
        public bool modificationConfirmee = false;

        public BDB56Projet1SNGDataSet.type_chambreRow unTypeChambre;

        public BDB56Projet1SNGDataSet.type_chambreDataTable
            typesExistants;

        public frmModifierTypeChambre()
        {
            InitializeComponent();
        }

        //=========================================================
        // Chargement
        //=========================================================
        private void frmModifierTypeChambre_Load(
            object sender, EventArgs e)
        {
            if (unTypeChambre == null)
            {
                this.Close();
                return;
            }

            txtIdTypeChambre.Text =
                unTypeChambre.id_typeChambre.ToString();

            txtDescription.Text =
                unTypeChambre.description;

            txtPrixHaut.Text =
                unTypeChambre.prixHaut.ToString("0.00");

            txtPrixMoyen.Text =
                unTypeChambre.prixMoyen.ToString("0.00");

            txtPrixBas.Text =
                unTypeChambre.prixBas.ToString("0.00");
           
        }

        //=========================================================
        // Validation
        //=========================================================
        private bool ValiderChamps()
        {
            errMessage.Clear();

            Control premierChampErreur = null;

            string description = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(description))
            {
                errMessage.SetError(
                    txtDescription,
                    "La description est obligatoire."
                );

                premierChampErreur = txtDescription;
            }
            else if (typesExistants != null)
            {
                foreach (BDB56Projet1SNGDataSet.type_chambreRow ligne
                    in typesExistants.Rows)
                {
                    if (ligne.RowState == DataRowState.Deleted)
                        continue;

                    // Ignorer le type en cours de modification.
                    if (ligne.id_typeChambre ==
                        unTypeChambre.id_typeChambre)
                    {
                        continue;
                    }

                    if (string.Equals(
                        ligne.description.Trim(),
                        description,
                        StringComparison.CurrentCultureIgnoreCase))
                    {
                        errMessage.SetError(
                            txtDescription,
                            "Ce type de chambre existe déjà."
                        );

                        premierChampErreur = txtDescription;
                        break;
                    }
                }
            }

            TextBox[] champsPrix =
            {
                txtPrixHaut,
                txtPrixMoyen,
                txtPrixBas
            };

            foreach (TextBox champ in champsPrix)
            {
                decimal prix;

                if (!decimal.TryParse(champ.Text.Trim(), out prix) ||
                    prix < 0 ||
                    prix > 99999.99m ||
                    decimal.Round(prix, 2) != prix)
                {
                    errMessage.SetError(
                        champ,
                        "Entrez un prix valide (maximum 2 décimales)."
                    );

                    if (premierChampErreur == null)
                    {
                        premierChampErreur = champ;
                    }
                }
            }
            //verifier l'ordre des prix
            decimal prixHaut, prixMoyen, prixBas;

            if (decimal.TryParse(txtPrixHaut.Text.Trim(), out prixHaut) &&
                decimal.TryParse(txtPrixMoyen.Text.Trim(), out prixMoyen) &&
                decimal.TryParse(txtPrixBas.Text.Trim(), out prixBas))
            {
                // Le prix moyen ne peut pas dépasser le prix haut.
                if (prixMoyen > prixHaut)
                {
                    errMessage.SetError(
                        txtPrixMoyen,
                        "Le prix moyen ne peut pas dépasser le prix haut."
                    );

                    if (premierChampErreur == null)
                    {
                        premierChampErreur = txtPrixMoyen;
                    }
                }

                // Le prix bas ne peut pas dépasser le prix moyen.
                if (prixBas > prixMoyen)
                {
                    errMessage.SetError(
                        txtPrixBas,
                        "Le prix bas ne peut pas dépasser le prix moyen."
                    );

                    if (premierChampErreur == null)
                    {
                        premierChampErreur = txtPrixBas;
                    }
                }
            }
            if (premierChampErreur != null)
            {
                premierChampErreur.Focus();
                return false;
            }

            return true;
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

            unTypeChambre.description =
                txtDescription.Text.Trim();

            unTypeChambre.prixHaut =
                decimal.Parse(txtPrixHaut.Text.Trim());

            unTypeChambre.prixMoyen =
                decimal.Parse(txtPrixMoyen.Text.Trim());

            unTypeChambre.prixBas =
                decimal.Parse(txtPrixBas.Text.Trim());

            modificationConfirmee = true;

            this.Close();
        }

        //=========================================================
        // Fermer
        //=========================================================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            modificationConfirmee = false;

            errMessage.Clear();

            this.Close();
        }
    }
}