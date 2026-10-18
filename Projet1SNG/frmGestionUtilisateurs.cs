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
        public string nomUtilisateurConnecte = "nes";
        public frmGestionUtilisateurs()
        {
            InitializeComponent();
        }

        //private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.utilisateurBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        //}

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

            // On recupere les infos des input et du combobox
            String nomUtilisateur = txtNomUtilisateur.Text.Trim(); 
            String mdp = txtMdp.Text.Trim();
            object typeUtilisateur = cmbTypeUtilisateur.SelectedValue;

            SqlParameter parametre1 = new SqlParameter("@nom", nomUtilisateur);
            commande1.Parameters.Add(parametre1); //on l'ajoute en parametre pour la requete

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
                // On attribue le bon id
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

                // Ajout du user a la transaction:
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
                // Si ça échoue
                maTransaction.Rollback();
                MessageBox.Show("Erreur: l'ajout a échoué, transaction annulée.");
            }

            utilisateurTableAdapter.Fill(bDB56Projet1SNGDataSet.utilisateur);
            txtNomUtilisateur.Clear();
            txtMdp.Clear();

            maConnexion.Close(); //Ferneture de la connexion
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (utilisateurBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur pour le modifier.");
                return;
            }

            // Utilisateur selectionné
            int idUtilisateur = Convert.ToInt32(dgvUtilisateurs.CurrentRow.Cells["dgvIdUtil"].Value);
            String nomUtilisateur = dgvUtilisateurs.CurrentRow.Cells["dgvNomUtil"].Value.ToString();
            int ancienType = Convert.ToInt32(dgvUtilisateurs.CurrentRow.Cells["dgvTypeUtil"].Value);

            // New valeurs
            String mdp = txtMdp.Text.Trim();
            object nouveauType = cmbTypeUtilisateur.SelectedValue;

            // Validations
            if (mdp == "")
            {
                MessageBox.Show("Vous devez entrer un mot de passe.");
                txtMdp.Focus();
                return;
            }
            if (nouveauType == null)
            {
                MessageBox.Show("Vous devez sélectionner le type d'utilisateur.");
                cmbTypeUtilisateur.Focus();
                return;
            }

            // On ne peut pas modifier son propre type
            if (nomUtilisateur == nomUtilisateurConnecte && Convert.ToInt32(nouveauType) != ancienType)
            {
                MessageBox.Show("Vous ne pouvez pas modifier votre propre type d'utilisateur.");
                return;
            }

            // Connexion et transaction
            String maChaineDeConnexion = Projet1SNG.Properties.Settings.Default.BDB56Projet1SNGConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();
            SqlTransaction maTransaction = maConnexion.BeginTransaction();

            String requete = "UPDATE utilisateur " +
                             "SET motDePasse = @mdp, typeUtil = @typeUtil " +
                             "WHERE id_util = @idUtil;";

            try
            {
                SqlCommand commande = new SqlCommand(requete, maConnexion);
                commande.Transaction = maTransaction;
                commande.Parameters.Add(new SqlParameter("@mdp", mdp));
                commande.Parameters.Add(new SqlParameter("@typeUtil", nouveauType));
                commande.Parameters.Add(new SqlParameter("@idUtil", idUtilisateur));
                commande.ExecuteNonQuery();

                maTransaction.Commit();
                MessageBox.Show("Utilisateur modifié avec succès.");
            }
            catch
            {
                maTransaction.Rollback();
                MessageBox.Show("Erreur : la modification a échoué, transaction annulée.");
            }

            utilisateurTableAdapter.Fill(bDB56Projet1SNGDataSet.utilisateur);
            maConnexion.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            // Recuperation de la chaine de connexion
            String maChaineDeConnexion = Projet1SNG.Properties.Settings.Default.BDB56Projet1SNGConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);

            if (utilisateurBindingSource.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur pour le supprimer.");
                return;
            }

            // Utilisateur selectionné:
            int idUtilisateur = Convert.ToInt32(dgvUtilisateurs.CurrentRow.Cells["dgvIdUtil"].Value);
            String nomUtilisateur = dgvUtilisateurs.CurrentRow.Cells["dgvNomUtil"].Value.ToString();

            // Empêcher la suppression de l'administrateur principal et de l'utilisateur actuel
            if(idUtilisateur == 1)
            {
                MessageBox.Show("L'administtrateur principal ne peut pas être supprimé.");
                return;
            }
            if (nomUtilisateur == nomUtilisateurConnecte)
            {
                MessageBox.Show("Impossible de supprimer votre propre compte.");
                return;
            }

            // Confirmation de suppression (oui ou non)
            DialogResult rep = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet utilisateur ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.No)
            {
                return;
            }

            // Ouverture de la connexion et début de la transaction
            maConnexion.Open();
            SqlTransaction maTransaction = maConnexion.BeginTransaction();
            String requete = "DELETE FROM utilisateur " +
                             "WHERE id_util = @idUtil;";

            try
            {
                SqlCommand commande = new SqlCommand(requete, maConnexion);
                commande.Transaction = maTransaction;
                commande.Parameters.Add(new SqlParameter("@idUtil", idUtilisateur));
                commande.ExecuteNonQuery();

                maTransaction.Commit();
                MessageBox.Show("Utilisateur supprimé avec succès");
            }
            catch
            {
                // Si ça échoue
                maTransaction.Rollback();
                MessageBox.Show("Erreur: la suppression a échoué, transaction annulée.");
            }

            utilisateurTableAdapter.Fill(bDB56Projet1SNGDataSet.utilisateur);
            maConnexion.Close();
        }

    }
}
