using System;
using System.Data;
using System.Windows.Forms;

namespace Projet1SNG.GestionChambre
{
    public partial class frmAjouterTypeChambre : Form
    {
        public bool ajoutConfirme = false;

        public BDB56Projet1SNGDataSet.type_chambreRow unTypeChambre;

        public BDB56Projet1SNGDataSet.type_chambreDataTable
            typesExistants;

        public frmAjouterTypeChambre()
        {
            InitializeComponent();
        }

        //=========================================================
        // Chargement
        //=========================================================
        private void frmAjouterTypeChambre_Load(
            object sender, EventArgs e)
        {
            if (unTypeChambre == null)
            {
                this.Close();
                return;
            }

            txtIdTypeChambre.Text =
                unTypeChambre.id_typeChambre.ToString();

        }

        //=========================================================
        // Validation
        //=========================================================
        private bool ValiderChamps()
        {
            errMessage.Clear();

            Control premierChampErreur = null;

            // Vérifier la description.
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
                // Vérifier que la description est unique.
                foreach (BDB56Projet1SNGDataSet.type_chambreRow ligne
                    in typesExistants.Rows)
                {
                    if (ligne.RowState == DataRowState.Deleted)
                        continue;

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

            // Vérifier les trois prix.
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
        // Ajouter
        //=========================================================
        private void btnAjouter_Click(object sender, EventArgs e)
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

            ajoutConfirme = true;

            this.Close();
        }

        //=========================================================
        // Fermer
        //=========================================================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            ajoutConfirme = false;

            errMessage.Clear();

            this.Close();
        }
    }
}