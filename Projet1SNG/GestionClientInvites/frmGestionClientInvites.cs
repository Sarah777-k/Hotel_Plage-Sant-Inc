using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG.GestionClientInvites
{
    public partial class frmGestionClientInvites : Form
    {
        public frmGestionClientInvites()
        {
            InitializeComponent();
        }


        private void frmGestionClientInvites_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.invite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inviteTableAdapter.Fill(this.bDB56Projet1SNGDataSet.invite);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.bDB56Projet1SNGDataSet.client);

            clientTableAdapter.Adapter.RowUpdated += new SqlRowUpdatedEventHandler(clientTableAdapter_RowUpdated);
            inviteTableAdapter.Adapter.RowUpdated += new SqlRowUpdatedEventHandler(inviteTableAdapter_RowUpdated);

        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.clientRow unClient = bDB56Projet1SNGDataSet.client.NewclientRow();

            int noMax = 0;
            foreach (BDB56Projet1SNGDataSet.clientRow uneLigne in bDB56Projet1SNGDataSet.client.Rows)
                if (uneLigne.id_client > noMax) noMax = uneLigne.id_client;

            unClient.id_client = noMax + 10;
            unClient.dateInscription = DateTime.Now.Date;

            unClient.nom = "";

            frmAjouterClient fAjouter = new frmAjouterClient();
            fAjouter.unClient = unClient;
            fAjouter.ShowDialog();

            if (unClient.nom != "")
            {
                bDB56Projet1SNGDataSet.client.AddclientRow(unClient);
                clientTableAdapter.Update(bDB56Projet1SNGDataSet.client);
                clientBindingSource.MoveLast();
                MessageBox.Show("Le client " + unClient.id_client.ToString() + " a été ajouté.", "Ajout d'un client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAjouterInvite_Click(object sender, EventArgs e)
        {
            if (clientBindingSource.Current == null)
            {
                MessageBox.Show("Sélectionnez d'abord un client.", "Ajout impossible");
                return;
            }

            if (inviteBindingSource.Count >= 9)
            {
                MessageBox.Show("Un client ne peut pas avoir plus de 9 invités.", "Ajout impossible");
                return;
            }

            BDB56Projet1SNGDataSet.clientRow unClientCourant = (BDB56Projet1SNGDataSet.clientRow)((DataRowView)clientBindingSource.Current).Row;

            int noInvite = 0;
            for (int k = 1; k <= 9 && noInvite == 0; k++)
            {
                int candidat = unClientCourant.id_client + k;
                bool libre = !bDB56Projet1SNGDataSet.invite.Cast<BDB56Projet1SNGDataSet.inviteRow>().Any(i => i.id_invite == candidat);
                if (libre) noInvite = candidat;
            }

            BDB56Projet1SNGDataSet.inviteRow unInvite = bDB56Projet1SNGDataSet.invite.NewinviteRow();
            unInvite.id_invite = noInvite;
            unInvite.id_client = unClientCourant.id_client;

            unInvite.nom = "";

            frmAjouterInvite fAjouter = new frmAjouterInvite();
            fAjouter.unInvite = unInvite;
            fAjouter.ShowDialog();

            if (unInvite.nom != "")
            {
                bDB56Projet1SNGDataSet.invite.AddinviteRow(unInvite);
                inviteTableAdapter.Update(bDB56Projet1SNGDataSet.invite);
                inviteBindingSource.MoveLast();
                MessageBox.Show("L'invité " + unInvite.id_invite.ToString() + " a été ajouté.", "Ajout d'un invité", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            dgvClient.CancelEdit();
            dgvInvite.CancelEdit();

            this.bDB56Projet1SNGDataSet.client.RejectChanges();
            this.bDB56Projet1SNGDataSet.invite.RejectChanges();
            clientBindingSource.ResetBindings(false);
            inviteBindingSource.ResetBindings(false);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.inviteBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);
                MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Conflit d'accès. Aucun enregistrement possible.", "Conflit d'accès");
            }
            catch (SqlException)
            {
                MessageBox.Show("Erreur lors de l'enregistrement dans la base de données.", "Erreur");
            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClient_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

            DataRowView drv = (DataRowView)dgvClient.Rows[e.RowIndex].DataBoundItem;
            string messageErreur = string.Empty;

            if (string.IsNullOrWhiteSpace(Convert.ToString(drv["nom"])) ||
                string.IsNullOrWhiteSpace(Convert.ToString(drv["prenom"])) ||
                string.IsNullOrWhiteSpace(Convert.ToString(drv["adresse"])) ||
                string.IsNullOrWhiteSpace(Convert.ToString(drv["ville"])) ||
                string.IsNullOrWhiteSpace(Convert.ToString(drv["pays"])) ||
                string.IsNullOrWhiteSpace(Convert.ToString(drv["codePostal"])) ||
                string.IsNullOrWhiteSpace(Convert.ToString(drv["telephone"])))
            {
                messageErreur = "Aucun champ du client ne doit être vide.";
            }

            dgvClient.Rows[e.RowIndex].ErrorText = messageErreur;
            if (messageErreur != string.Empty)
            {
                e.Cancel = true;
            }
        }

        private void dgvInvite_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= inviteBindingSource.Count) return;

            DataRowView drv = (DataRowView)dgvInvite.Rows[e.RowIndex].DataBoundItem;
            string messageErreur = string.Empty;

            if (string.IsNullOrWhiteSpace(Convert.ToString(drv["nom"])) ||
                string.IsNullOrWhiteSpace(Convert.ToString(drv["prenom"])))
            {
                messageErreur = "Le nom et le prénom de l'invité ne doivent pas être vides.";
            }

            dgvInvite.Rows[e.RowIndex].ErrorText = messageErreur;
            if (messageErreur != string.Empty)
            {
                e.Cancel = true;
            }
        }

        private void clientTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected == 0)
            {
                string noClient = e.Row["id_client"].ToString();
                MessageBox.Show("Conflit d'accès concurrentiel pour le client " + noClient + ". Cet enregistrement ne sera pas sauvegardé.", "Conflit d'accès");
                e.Status = UpdateStatus.Continue;
            }
        }

        private void inviteTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected == 0)
            {
                string noInvite = e.Row["id_invite"].ToString();
                MessageBox.Show("Conflit d'accès concurrentiel pour l'invité " + noInvite + ". Cet enregistrement ne sera pas sauvegardé.", "Conflit d'accès");
                e.Status = UpdateStatus.Continue;
            }
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (clientBindingSource.Current == null) return;

            if (inviteBindingSource.Count > 0)
            {
                MessageBox.Show("Impossible de supprimer ce client : il a des invités.", "Suppression refusée");
                return;
            }

            if (MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                clientBindingSource.RemoveCurrent();
        }

        private void btnSupprimerInvite_Click(object sender, EventArgs e)
        {
            if (inviteBindingSource.Current == null) return;

            if (MessageBox.Show("Voulez-vous vraiment supprimer cet invité ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ((DataRowView)inviteBindingSource.Current).Row.Delete();
                inviteBindingSource.ResetBindings(false);
            }
        }
    }
}
