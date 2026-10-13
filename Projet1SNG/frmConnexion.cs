using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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


                string maRequeteSQL = "SELECT COUNT(*) FROM utilisateur WHERE nomUtil = @utilisateur AND motDePasse = @mdp";
                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);

                maCommande.Parameters.AddWithValue("@utilisateur", txtUtilisateur.Text.Trim());
                maCommande.Parameters.AddWithValue("@mdp", txtMotDePasse.Text.Trim());

                int resultat = (int)maCommande.ExecuteScalar();

                if (resultat > 0)
                {
                    lblErreur.Text = "Connexion réussie !";

                    Menu principal = new Menu();
                    principal.Show();
                    this.Hide();
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
    }
}