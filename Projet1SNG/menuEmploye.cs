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
    public partial class menuEmploye : Form
    {
        public string noEmploye;
        public menuEmploye()
        {
            InitializeComponent();
        }

        private void assistantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.assistantTableAdapter.Fill(this.bDB56Projet1SNGDataSet.assistant);
            txtIdNumber.Text = "Numéros d'employé: " + noEmploye;

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            frmConnexion frmCo = new frmConnexion();
            frmCo.Show();
            this.Hide();
        }

        private void btnReserverChambre_Click(object sender, EventArgs e)
        {
            GestionReservation.frmGestionReservationChambre frmGestionReservationChambre = new GestionReservation.frmGestionReservationChambre();
            frmGestionReservationChambre.Show();
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
           GestionClientInvites.frmGestionClientInvites frmGestionClientInvites = new GestionClientInvites.frmGestionClientInvites();
            frmGestionClientInvites.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPlanifSoins frmPlanifSoins = new frmPlanifSoins();
            frmPlanifSoins.Location = new Point(
                this.Location.X + (this.Width - frmPlanifSoins.Width) / 2,
                this.Location.Y + (this.Height - frmPlanifSoins.Height) / 2
            );
            frmPlanifSoins.Show();
        }
    }
}
