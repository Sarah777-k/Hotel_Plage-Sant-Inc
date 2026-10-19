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
                maConnexion.Open();

                // 1. Vérifier si l'utilisateur existe
                string maRequeteSQL = "SELECT COUNT(*) FROM utilisateur WHERE nomUtil = @utilisateur AND motDePasse = @mdp";
                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                maCommande.Parameters.AddWithValue("@utilisateur", txtUtilisateur.Text.Trim());
                maCommande.Parameters.AddWithValue("@mdp", txtMotDePasse.Text.Trim());

                int resultat = (int)maCommande.ExecuteScalar();

                // Si l'utilisateur existe
                if (resultat > 0)
                {
                    lblErreur.Text = "Connexion réussie !";

                    // 2. Chercher le type d'utilisateur
                    string maRequeteSQL2 = "SELECT typeUtil FROM utilisateur WHERE nomUtil = @utilisateur AND motDePasse = @mdp";
                    SqlCommand maCommande2 = new SqlCommand(maRequeteSQL2, maConnexion);
                    maCommande2.Parameters.AddWithValue("@utilisateur", txtUtilisateur.Text.Trim());
                    maCommande2.Parameters.AddWithValue("@mdp", txtMotDePasse.Text.Trim());

                    // Utilisation de Convert.ToInt32 pour éviter les erreurs de cast direct
                    int resultat2 = Convert.ToInt32(maCommande2.ExecuteScalar());

                    // Connecter vers l'admin
                    if (resultat2 == 1)
                    {
                        string maRequeteSQL3 = "SELECT id_util FROM utilisateur WHERE nomUtil = @utilisateur AND motDePasse = @mdp";
                        SqlCommand maCommande3 = new SqlCommand(maRequeteSQL3, maConnexion);
                        maCommande3.Parameters.AddWithValue("@utilisateur", txtUtilisateur.Text.Trim());
                        maCommande3.Parameters.AddWithValue("@mdp", txtMotDePasse.Text.Trim());

                        // Utilisation de .ToString() pour l'ID (évite le plantage peu importe le type numérique SQL)
                        string idAdmin = maCommande3.ExecuteScalar().ToString();

                        menuAdmin mAdmin = new menuAdmin();
                        mAdmin.noAdmin = idAdmin;
                        mAdmin.Show();
                        this.Hide();
                    }
                    else // Connecter vers l'employé
                    {
                        string maRequeteSQL4 = "SELECT id_util FROM utilisateur WHERE nomUtil = @utilisateur AND motDePasse = @mdp";
                        SqlCommand maCommande4 = new SqlCommand(maRequeteSQL4, maConnexion);
                        maCommande4.Parameters.AddWithValue("@utilisateur", txtUtilisateur.Text.Trim());
                        maCommande4.Parameters.AddWithValue("@mdp", txtMotDePasse.Text.Trim());

                        string idEmploye = maCommande4.ExecuteScalar().ToString();

                        menuEmploye principal = new menuEmploye();
                        principal.noEmploye = idEmploye;
                        principal.Show();
                        this.Hide();
                    }
                }
                else
                {
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