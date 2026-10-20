using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1SNG.Rapport;

namespace Projet1SNG
{
    public partial class menuAdmin : Form
    {
        public string noAdmin;
        public string nomUtilisateurConnecte;

        public menuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConnexion frmCo = new frmConnexion();
            frmCo.Show();
            this.Close();
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {
            lblIdAdmin.Text = "Numéros d'employé: " + noAdmin;
        }

        private void button8_Click(object sender, EventArgs e)
        {
                     // DataSet vide qu'on remplit avec les données de la base
            BDB56Projet1SNGDataSet monDataSet = new BDB56Projet1SNGDataSet();

            // Remplir chaque table
            new BDB56Projet1SNGDataSetTableAdapters.utilisateurTableAdapter().Fill(monDataSet.utilisateur);
            new BDB56Projet1SNGDataSetTableAdapters.clientTableAdapter().Fill(monDataSet.client);
            new BDB56Projet1SNGDataSetTableAdapters.inviteTableAdapter().Fill(monDataSet.invite);
            new BDB56Projet1SNGDataSetTableAdapters.assistantTableAdapter().Fill(monDataSet.assistant);
            new BDB56Projet1SNGDataSetTableAdapters.assistant_soinTableAdapter().Fill(monDataSet.assistant_soin);
            new BDB56Projet1SNGDataSetTableAdapters.soinTableAdapter().Fill(monDataSet.soin);
            new BDB56Projet1SNGDataSetTableAdapters.planif_soinTableAdapter().Fill(monDataSet.planif_soin);
            new BDB56Projet1SNGDataSetTableAdapters.chambreTableAdapter().Fill(monDataSet.chambre);
            new BDB56Projet1SNGDataSetTableAdapters.type_chambreTableAdapter().Fill(monDataSet.type_chambre);
            new BDB56Projet1SNGDataSetTableAdapters.reservationTableAdapter().Fill(monDataSet.reservation);


            monDataSet.utilisateur.WriteXml("utilisateur.xml");
            monDataSet.client.WriteXml("client.xml");
            monDataSet.invite.WriteXml("invite.xml");
            monDataSet.assistant.WriteXml("assistant.xml");
            monDataSet.assistant_soin.WriteXml("assistantSoin.xml");
            monDataSet.soin.WriteXml("soin.xml");
            monDataSet.planif_soin.WriteXml("planificationSoin.xml");
            monDataSet.chambre.WriteXml("chambre.xml");
            monDataSet.type_chambre.WriteXml("typeChambre.xml");
            monDataSet.reservation.WriteXml("reservationChambre.xml");
        
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
            fGestionUtilisateurs.nomUtilisateurConnecte = nomUtilisateurConnecte;
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

        private void btnRapportReservation_Click(object sender, EventArgs e)
        {
            frmRapportReservationsChambres frmRapportReservationsChambres = new frmRapportReservationsChambres();
            frmRapportReservationsChambres.Location = new Point(
                this.Location.X + (this.Width - frmRapportReservationsChambres.Width) / 2,
                this.Location.Y + (this.Height - frmRapportReservationsChambres.Height) / 2
            );
            frmRapportReservationsChambres.Show();
        }

        private void btnPlanifSoins_Click(object sender, EventArgs e)
        {
            frmPlanifSoins frmPlanifSoins = new frmPlanifSoins();
            frmPlanifSoins.Location = new Point(
                this.Location.X + (this.Width - frmPlanifSoins.Width) / 2,
                this.Location.Y + (this.Height - frmPlanifSoins.Height) / 2
            );
            frmPlanifSoins.Show();
        }

        private void btnRapportsSoinsClientInvites_Click(object sender, EventArgs e)
        {
            frmRapportSoinsOffertsClientsInvites frmRapportSoins = new frmRapportSoinsOffertsClientsInvites();
            frmRapportSoins.Location = new Point(
                this.Location.X + (this.Width - frmRapportSoins.Width) / 2,
                this.Location.Y + (this.Height - frmRapportSoins.Height) / 2
            );
            frmRapportSoins.Show();
        }

        private void btnRapportSoinsAssistant_Click(object sender, EventArgs e)
        {

            frmRapportSoinsJournaliersAssistant frmCo = new frmRapportSoinsJournaliersAssistant();
            frmCo.Show();
        }
    }
}
