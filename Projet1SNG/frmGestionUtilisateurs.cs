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

            String requete1= "SELECT COUNT(*) FROM utilisateur " +
                             "WHERE nomUtil = @nom;";

            SqlCommand commande1 = new SqlCommand(requete1, maConnexion);

            //on recupere les infos des input et du combobox
            String nomUtilisateur = txtNomUtilisateur.Text.Trim(); 
            String mdp = txtMdp.Text.Trim();
            object typeUtilisateur = cmbTypeUtilisateur.SelectedValue;

            SqlParameter parametre1 = new SqlParameter("@nom", nomUtilisateur);
            commande1.Parameters.Add(parametre1); // on l'ajoute en parametre pour la requete

            // On verifie si le nom existe deja:
            object compte = commande1.ExecuteScalar();
            int nbCompte = Convert.ToInt32(compte);
            // si on trouve que ca exisye deja on afffche un message
            if (nbCompte != 0)
            {
                MessageBox.Show("Ce nom d'utilisateur est deja existant.");
                txtNomUtilisateur.Focus();
                maConnexion.Close();
                return;
            }

            SqlTransaction maTransaction = maConnexion.BeginTransaction();
            String requete2 = "INSERT INTO utilisateur (id_util, nomUtil, motDePasse, typeUtil) " +
                              "VALUES (@idUtil, @nom, @mdp, @typeUtil);";

            try
            {
                //On attribue le bon id ()
                String requete3 = "SELECT MAX(id_util) FROM utilisateur;";
                SqlCommand commande2 = new SqlCommand(requete3, maConnexion);
                commande2.Transaction = maTransaction;
                object max = commande2.ExecuteScalar();
                int idUtilisateur;
                if (max == DBNull.Value)
                {
                    idUtilisateur = 1;
                }
                else idUtilisateur = Convert.ToInt32(max)+1;

                // ajout du user a la transaction:
                SqlCommand commande3 = new SqlCommand(requete2, maConnexion);
                commande3.Transaction = maTransaction;
                commande3.Parameters.Add(new SqlParameter("@idUtil", idUtilisateur));
                commande3.Parameters.Add(new SqlParameter("@nom", nomUtilisateur));
                commande3.Parameters.Add(new SqlParameter("@mdp", mdp));
                commande3.Parameters.Add(new SqlParameter("@typeUtil", typeUtilisateur));

                commande3.ExecuteNonQuery();

                maTransaction.Commit();
                MessageBox.Show("Utilisateur créée avec succès.");

            }
            catch
            {
                maTransaction.Rollback();
                MessageBox.Show("Erreur: transaction annulée.");
            }

            utilisateurTableAdapter.Fill(bDB56Projet1SNGDataSet.utilisateur);
            txtNomUtilisateur.Clear();
            txtMdp.Clear();

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
