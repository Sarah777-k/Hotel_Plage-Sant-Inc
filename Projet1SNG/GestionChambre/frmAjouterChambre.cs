using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG.GestionChambre
{
    public partial class frmAjouterChambre : Form
    {
        public frmAjouterChambre()
        {
            InitializeComponent();
        }

        private void chambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        }

        private void frmAjouterChambre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.type_chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.type_chambreTableAdapter.Fill(this.bDB56Projet1SNGDataSet.type_chambre);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.bDB56Projet1SNGDataSet.chambre);

        }
        private bool ValiderChamps()
        {
            bool valide = true;
            Control premierChampErreur = null;

            errMessage.Clear();

            Control[] champs = {txtEmplacement, txtDecoration, cboTypeChambre};

            string[] messages = { "L'emplacement est obligatoire.","La décoration est obligatoire.","Le type de chambre est obligatoire."};

            for (int i = 0; i < champs.Length; i++)
            {
                bool champVide = false;

                if (champs[i] is TextBox)
                {
                    TextBox txt = (TextBox)champs[i];
                    champVide = string.IsNullOrWhiteSpace(txt.Text);
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

            // Mettre le curseur sur le premier champ invalide
            if (premierChampErreur != null)
            {
                premierChampErreur.Focus();
            }

            return valide;
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps())
            {
                return;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

        }
    }
}
