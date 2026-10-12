using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG
{
    public partial class frmGestionUtilisateurs : Form
    {
        public string nomUtilisateurConnecte;
        public frmGestionUtilisateurs()
        {
            InitializeComponent();
        }

        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        }

        private void frmGestionUtilisateurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.typeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeUtilisateurTableAdapter.Fill(this.bDB56Projet1SNGDataSet.typeUtilisateur);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.bDB56Projet1SNGDataSet.utilisateur);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Vérifications avant d'ouvrir la connexion et d'envoyer les donnees
            if (txtNomUtilisateur.Text.Trim() == "")
            {
                MessageBox.Show("Vous devez entrer un nom d'utilisateur.");
                txtNomUtilisateur.Focus();
                return;
            }
            if (txtMdp.Text.Trim() == "")
            {
                MessageBox.Show("Vous devez entrer un mot de passe.");
                txtMdp.Focus();
                return;
            }
            if (cmbTypeUtilisateur.SelectedValue == null)
            {
                MessageBox.Show("Vous devez selectionner le type d'utilisateur");
                cmbTypeUtilisateur.Focus();
                return;
            }

            // Recuperation de la chaine de connexion
            String maChaineDeConnexion = Projet1SNG.Properties.Settings.Default.BDB56Projet1SNGConnectionString;

            
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open(); //Ouverture de la connexion

            String requete1= "SELECT COUNT(*) " +
                             "FROM utilisateur " +
                             "WHERE nomUtilisateur = @nom;";

            SqlCommand commande1 = new SqlCommand(requete1, maConnexion);

            String nomUtilisateur = txtNomUtilisateur.Text.Trim(); //on recupere le nom util
            SqlParameter parametre1 = new SqlParameter("@nom", nomUtilisateur);
            commande1.Parameters.Add(parametre1);
            


            maConnexion.Close(); //Ferneture de la connexion
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
