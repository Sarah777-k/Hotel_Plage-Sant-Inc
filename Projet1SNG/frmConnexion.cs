using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG
{
    public partial class frmConnexion : Form
    {
        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Projet1SNG;Persist Security Info=True;User ID=B56Projet1SNG;Password=ResidentEvil2;Encrypt=True;TrustServerCertificate=True";

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);

            try
            {

                //fait une connection direct à la base de données
                maConnexion.Open();


                string maRequeteSQL = "SELECT COUNT(*) FROM utilisateur WHERE nomUtil = @utilisateur AND motDePasse = @mdp";
                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);

                maCommande.Parameters.AddWithValue("@utilisateur", txtUtilisateur.Text.Trim());
                maCommande.Parameters.AddWithValue("@mdp", txtMotDePasse.Text.Trim());

                int resultat = (int)maCommande.ExecuteScalar();

                //si l'utilisateur existe
                if (resultat > 0)
                {
                    
                    lblErreur.Text = "Connexion réussie !";

                    //cherche le type d'utilisateur
                    string maRequeteSQL2 = "SELECT typeUtil FROM typeUtilisateur WHERE nomUtil = @utilisateur AND motDePasse = @mdp";
                    int resultat2 = (int)maCommande.ExecuteScalar();

                    //Connecte vers l'admin
                    if (resultat2 == 1)
                    {
                        string maRequeteSQL3 = "SELECT id_util FROM typeUtilisateur WHERE nomUtil = @utilisateur AND motDePasse = @mdp";
                        int idAdmin = (int)maCommande.ExecuteScalar();
                        menuAdmin mAdmin = new menuAdmin();
                        mAdmin.noAdmin = idAdmin.ToString();
                        mAdmin.Show();
                        this.Hide();
                    }
                    else //Connecte vers l'employe
                    {
                        string maRequeteSQL4 = "SELECT id_util FROM typeUtilisateur WHERE nomUtil = @utilisateur AND motDePasse = @mdp";
                        int idEmploye = (int)maCommande.ExecuteScalar();
                        menuEmploye principal = new menuEmploye();
                        principal.noEmploye = idEmploye.ToString();
                        principal.Show();
                        this.Hide();
                    }

                }
                else
                {
                    //si l'utilisateur il affiche:
                    lblErreur.Text = "Connexion échouée : Utilisateur ou mot de passe incorrect.";
                }
            }
            catch (Exception ex)
            {

                lblErreur.Text = "Erreur : " + ex.Message;
            }
            finally
            {
                if (maConnexion.State == ConnectionState.Open)
                {
                    maConnexion.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}