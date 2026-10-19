using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG.Soins
{
    public partial class frmGestionSoins : Form
    {
        public frmGestionSoins()
        {
            InitializeComponent();
            soinTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(soinTableAdapter_RowUpdated);
        }

        private void frmGestionSoins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.type_soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.type_soinTableAdapter.Fill(this.bDB56Projet1SNGDataSet.type_soin);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bDB56Projet1SNGDataSet.soin);

        }

        private void tbPrix_Validating(object sender, CancelEventArgs e)
        {
            string messageErreur = string.Empty;
            decimal prix;

            if (string.IsNullOrEmpty(tbPrix.Text))
            {
                messageErreur = "Le prix ne doit pas être vide";
            }
            else if (!decimal.TryParse(tbPrix.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out prix))
            {
                messageErreur = "Le prix doit être un montant valide";
            }
            else if (prix <= 0)
            {
                messageErreur = "Le prix ne doit pas être plus petit que 0";
            }
            else if (prix > 99999.99m)
            {
                messageErreur = "Le prix ne doit pas dépasser 99999,99";
            }

            errMessage.SetError(tbPrix, messageErreur);
            if (messageErreur != string.Empty)
            {
                e.Cancel = true;
            }
        }

        private void dgvSoins_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            string messageErreur = string.Empty;
            string strDescription = Convert.ToString(dgvSoins["dgvDescription", e.RowIndex].Value);
            string strPrix = Convert.ToString(dgvSoins["dgvPrix", e.RowIndex].Value);

            if (string.IsNullOrEmpty(strDescription) || string.IsNullOrEmpty(strPrix))
            {
                messageErreur = "Aucun champ ne doit être vide";
            }
            else
            {
                decimal prix;
                if (!decimal.TryParse(strPrix, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out prix))
                {
                    messageErreur = "Le prix doit être un montant valide";
                }
                else if (prix <= 0)
                {
                    messageErreur = "Le prix ne doit pas être plus petit que 0";
                }
                else if (prix > 99999.99m)
                {
                    messageErreur = "Le prix ne doit pas dépasser 99999,99";
                }
            }

            dgvSoins.Rows[e.RowIndex].ErrorText = messageErreur;
            if (messageErreur != string.Empty)
            {
                e.Cancel = true;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text == "" || cmbTypeSoin.SelectedIndex == -1 || tbPrix.Text == "" || errMessage.GetError(tbPrix) != "")
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement.", "Ajout impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int noMax = 0;
            foreach (BDB56Projet1SNGDataSet.soinRow ligne in bDB56Projet1SNGDataSet.soin.Rows)
                if (ligne.id_soin > noMax) noMax = ligne.id_soin;

            BDB56Projet1SNGDataSet.soinRow nouveau = bDB56Projet1SNGDataSet.soin.NewsoinRow();
            nouveau.id_soin = noMax + 1;
            nouveau.description = tbDescription.Text;
            nouveau.duree = 60;
            nouveau.id_typeSoin = (int)cmbTypeSoin.SelectedValue;
            nouveau.prix = decimal.Parse(tbPrix.Text, CultureInfo.CurrentCulture);
            bDB56Projet1SNGDataSet.soin.AddsoinRow(nouveau);

            soinBindingSource.MoveLast();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soinBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);
                MessageBox.Show("Les modifications ont été enregistrées dans la base de données.", "Enregistrement des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DBConcurrencyException erreur)
            {
                MessageBox.Show("Conflit d'accès concurrentiel. Aucun enregistrement possible.\n" + erreur.Message, "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Data.SqlClient.SqlException erreur)
            {
                MessageBox.Show("Erreur lors de l'enregistrement dans la base de données :\n" + erreur.Message, "Erreur de base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void soinTableAdapter_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected == 0)
            {
                string noSoin = e.Row["id_soin"].ToString();
                MessageBox.Show("Conflit d'accès concurrentiel pour le soin " + noSoin + ". Cet enregistrement ne sera pas sauvegardé.", "Conflit d'accès");
                e.Status = UpdateStatus.Continue;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (soinBindingSource.Current == null) return;

            BDB56Projet1SNGDataSet.soinRow ligne = (BDB56Projet1SNGDataSet.soinRow)((DataRowView)soinBindingSource.Current).Row;

            foreach (BDB56Projet1SNGDataSet.planif_soinRow planif in bDB56Projet1SNGDataSet.planif_soin.Rows)
            {
                if (planif.id_soin == ligne.id_soin)
                {
                    MessageBox.Show("Ce soin est planifié et ne peut pas être supprimé.", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (BDB56Projet1SNGDataSet.assistant_soinRow offert in bDB56Projet1SNGDataSet.assistant_soin.Rows)
            {
                if (offert.id_soin == ligne.id_soin)
                {
                    MessageBox.Show("Ce soin est offert par un assistant et ne peut pas être supprimé.", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (MessageBox.Show("Voulez-vous vraiment supprimer ce soin ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                soinBindingSource.RemoveCurrent();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bDB56Projet1SNGDataSet.soin.RejectChanges();
            soinBindingSource.ResetBindings(false);
            tbDescription.Clear();
            tbPrix.Clear();
            cmbTypeSoin.SelectedIndex = -1;
            errMessage.SetError(tbPrix, "");
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
