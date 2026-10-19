using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG
{
    public partial class menuAdmin : Form
    {
        public string noAdmin;

        public menuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConnexion frmCo = new frmConnexion();
            frmCo.Show();
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {
            lblIdAdmin.Text = "Numéros d'employé: " + noAdmin;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAssistantSoins_Click(object sender, EventArgs e)
        {
            FrmGestionAssistants frmGestionAssistants = new FrmGestionAssistants();
            frmGestionAssistants.Show();

            
        }

        private void btnChambreType_Click(object sender, EventArgs e)
        {
            GestionChambre.frmGestionChambre frmGestionChambre = new GestionChambre.frmGestionChambre();
            frmGestionChambre.Show();
           

        }

        private void btnGestionUtilisateur_Click(object sender, EventArgs e)
        {
            frmGestionUtilisateurs fGestionUtilisateurs = new frmGestionUtilisateurs();
            fGestionUtilisateurs.Show();

        }

        private void btnChambre_Click(object sender, EventArgs e)
        {
            GestionChambre.frmGestionChambre frmGestionChambre = new GestionChambre.frmGestionChambre();
            frmGestionChambre.Show();
        }

        private void btnReserverChambre_Click(object sender, EventArgs e)
        {
            GestionReservation.frmGestionReservationChambre frmGestionReservationChambre = new GestionReservation.frmGestionReservationChambre();
            frmGestionReservationChambre.Show();
        }

        private void btnGestionSoins_Click(object sender, EventArgs e)
        {
            Soins.frmGestionSoins frmGestionSoins = new Soins.frmGestionSoins();
            frmGestionSoins.Show();
        }

        private void btnGestionClientInvites_Click(object sender, EventArgs e)
        {
            GestionClientInvites.frmGestionClientInvites frmGestionClientInvites = new GestionClientInvites.frmGestionClientInvites();
            frmGestionClientInvites.Show();
        }
    }
}
