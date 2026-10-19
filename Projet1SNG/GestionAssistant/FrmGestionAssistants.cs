using Projet1SNG.BDB56Projet1SNGDataSetTableAdapters;
using Projet1SNG.GestionAssistant;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet1SNG
{
    public partial class FrmGestionAssistants : Form
    {
        private planif_soinTableAdapter planifSoinTableAdapter =
            new planif_soinTableAdapter();

        private bool conflitAcces = false;
        private bool operationMultipleEnCours = false;

        public FrmGestionAssistants()
        {
            InitializeComponent();
        }

        //=========================================================
        // chargement des donnees et gestion des conflits
        //=========================================================
        private void FrmGestionAssistants_Load(object sender, EventArgs e)
        {
            // afficher la nouvelle fonction du bouton
            btnActualiser.Text = "Actualiser";

            // charger le parent avant les deux tables liees
            assistantTableAdapter.Fill(bDB56Projet1SNGDataSet.assistant);
            assistant_soinTableAdapter.Fill(bDB56Projet1SNGDataSet.assistant_soin);
            dataTableAssistantSoinTableAdapter.Fill(
                bDB56Projet1SNGDataSet.DataTableAssistantSoin);

            // relier les deux tables a la meme transaction pour updateall
            tableAdapterManager.assistant_soinTableAdapter = assistant_soinTableAdapter;

            // detecter les conflits comme dans le labo 6
            assistantTableAdapter.Adapter.RowUpdated += TableAdapter_RowUpdated;
            assistant_soinTableAdapter.Adapter.RowUpdated += TableAdapter_RowUpdated;
        }
        //=========================================================
        // gestion des conflits d'acces concurrentiel
        //=========================================================

        private void TableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected != 0 ||
                (e.StatementType != StatementType.Update &&
                 e.StatementType != StatementType.Delete) ||
                (e.Errors != null && !(e.Errors is DBConcurrencyException)))
                return;

            conflitAcces = true;

            string numero = Convert.ToString(
                e.Row["id_assistant", DataRowVersion.Original]);
            string element = "l'assistant " + numero;

            if (e.Row.Table.TableName == "assistant_soin")
            {
                string idSoin = Convert.ToString(
                    e.Row["id_soin", DataRowVersion.Original]);
                element = "le soin " + idSoin + " de l'assistant " + numero;
            }

            if (operationMultipleEnCours)
            {
                // interrompre updateall pour annuler toute la transaction
                e.Errors = new DBConcurrencyException(
                    "Conflit d'accès concurrentiel pour " + element + ".");
                e.Status = UpdateStatus.ErrorsOccurred;
                return;
            }

            MessageBox.Show(
                "Conflit d'accès concurrentiel pour " + element +
                ". Cet enregistrement ne sera pas sauvegardé.",
                "Conflit d'accès", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            // continuer selon la methode du labo 6
            e.Status = UpdateStatus.Continue;
        }

        //=========================================================
        // selection et enregistrement simple
        //=========================================================
        private BDB56Projet1SNGDataSet.assistantRow AssistantSelectionne()
        {
            if (dgvAssistants.CurrentRow == null ||
                dgvAssistants.CurrentRow.IsNewRow ||
                !dgvAssistants.CurrentRow.Selected)
                return null;

            DataRowView ligne =
                dgvAssistants.CurrentRow.DataBoundItem as DataRowView;

            return ligne == null ? null :
                ligne.Row as BDB56Projet1SNGDataSet.assistantRow;
        }

        private bool Enregistrer(bool association)
        {
            conflitAcces = false;

            try
            {
                if (association)
                    assistant_soinTableAdapter.Update(
                        bDB56Projet1SNGDataSet.assistant_soin);
                else
                    assistantTableAdapter.Update(
                        bDB56Projet1SNGDataSet.assistant);

                if (conflitAcces)
                {
                    // annuler les modifications locales refusees
                    if (association)
                        bDB56Projet1SNGDataSet.assistant_soin.RejectChanges();
                    else
                        bDB56Projet1SNGDataSet.assistant.RejectChanges();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                if (association)
                    bDB56Projet1SNGDataSet.assistant_soin.RejectChanges();
                else
                    bDB56Projet1SNGDataSet.assistant.RejectChanges();

                if (!conflitAcces)
                {
                    MessageBox.Show(
                        "Erreur lors de l'enregistrement.\n\n" + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

        //=========================================================
        // ajouter un assistant
        //=========================================================
        private void btnAjouterAssistant_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.assistantRow unAssistant =
                bDB56Projet1SNGDataSet.assistant.NewassistantRow();

            int idMax = 0;
            foreach (BDB56Projet1SNGDataSet.assistantRow ligne
                in bDB56Projet1SNGDataSet.assistant.Rows)
            {
                if (ligne.RowState != DataRowState.Deleted &&
                    ligne.id_assistant > idMax)
                    idMax = ligne.id_assistant;
            }

            unAssistant.id_assistant = idMax + 1;

            using (frmAjouterAssistant frm = new frmAjouterAssistant())
            {
                frm.unAssistant = unAssistant;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = this.Location;
                frm.ShowDialog(this);

                if (!frm.ajoutConfirme) return;

                bDB56Projet1SNGDataSet.assistant.AddassistantRow(unAssistant);
                if (!Enregistrer(false)) return;

                assistantBindingSource.MoveLast();
                MessageBox.Show(
                    "L'assistant " + unAssistant.id_assistant + " a été ajouté.",
                    "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //=========================================================
        // modifier un assistant
        //=========================================================
        private void btnModifierAssistant_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.assistantRow unAssistant =
                AssistantSelectionne();

            if (unAssistant == null)
            {
                MessageBox.Show("Veuillez sélectionner un assistant.",
                    "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (frmGestionAssistantModifier frm =
                new frmGestionAssistantModifier())
            {
                frm.unAssistant = unAssistant;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = this.Location;
                frm.ShowDialog(this);

                if (!frm.modificationConfirmee) return;

                assistantBindingSource.EndEdit();
                if (!Enregistrer(false)) return;

                assistantBindingSource.ResetCurrentItem();
                MessageBox.Show("L'assistant a été modifié.",
                    "Modification", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        //=========================================================
        // supprimer un assistant et ses soins offerts
        //=========================================================
        private void btnSupAssistant_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.assistantRow unAssistant =
                AssistantSelectionne();

            if (unAssistant == null)
            {
                MessageBox.Show("Veuillez sélectionner un assistant.",
                    "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idAssistant = unAssistant.id_assistant;

            try
            {
                BDB56Projet1SNGDataSet.planif_soinDataTable planifications =
                    planifSoinTableAdapter.GetByNbPlanifByAssistant(idAssistant);

                if (planifications.Rows.Count > 0)
                {
                    MessageBox.Show(
                        "Cet assistant ne peut pas être supprimé : " +
                        "des soins sont présents dans une planification.",
                        "Suppression impossible", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de vérifier les planifications.\n\n" +
                    ex.Message, "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(
                "Voulez-vous supprimer l'assistant " +
                unAssistant.prenom + " " + unAssistant.nom + " ?",
                "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            conflitAcces = false;
            operationMultipleEnCours = true;

            try
            {
                // retirer les lignes d'affichage avant le parent
                bDB56Projet1SNGDataSet.DataTableAssistantSoin.Clear();

                // supprimer les associations en memoire
                DataRow[] associations =
                    bDB56Projet1SNGDataSet.assistant_soin.Select(
                        "id_assistant = " + idAssistant);

                foreach (DataRow ligne in associations)
                    ligne.Delete();

                unAssistant.Delete();

                // updateall utilise une transaction pour les deux tables
                tableAdapterManager.UpdateAll(bDB56Projet1SNGDataSet);

                dataTableAssistantSoinTableAdapter.Fill(
                    bDB56Projet1SNGDataSet.DataTableAssistantSoin);

                MessageBox.Show("L'assistant a été supprimé.",
                    "Suppression", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // recharger les donnees apres l'annulation de la transaction
                try
                {
                    bDB56Projet1SNGDataSet.assistant_soin.RejectChanges();
                    bDB56Projet1SNGDataSet.assistant.RejectChanges();
                    bDB56Projet1SNGDataSet.DataTableAssistantSoin.Clear();
                    bDB56Projet1SNGDataSet.assistant_soin.Clear();
                    bDB56Projet1SNGDataSet.assistant.Clear();
                    assistantTableAdapter.Fill(bDB56Projet1SNGDataSet.assistant);
                    assistant_soinTableAdapter.Fill(
                        bDB56Projet1SNGDataSet.assistant_soin);
                    dataTableAssistantSoinTableAdapter.Fill(
                        bDB56Projet1SNGDataSet.DataTableAssistantSoin);
                }
                catch (Exception erreurChargement)
                {
                    MessageBox.Show("Erreur de rechargement : " +
                        erreurChargement.Message, "Erreur");
                }

                MessageBox.Show(
                    conflitAcces ? "Conflit d'accès concurrentiel. " +
                        "La suppression de l'assistant a été annulée." :
                        "Erreur lors de la suppression.\n\n" + ex.Message,
                    conflitAcces ? "Conflit d'accès" : "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                operationMultipleEnCours = false;
            }
        }

        //=========================================================
        // ajouter un soin a un assistant
        //=========================================================
        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.assistantRow unAssistant =
                AssistantSelectionne();

            if (unAssistant == null)
            {
                MessageBox.Show("Veuillez sélectionner un assistant.",
                    "Ajout d'un soin", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            BDB56Projet1SNGDataSet.assistant_soinRow association =
                bDB56Projet1SNGDataSet.assistant_soin.Newassistant_soinRow();

            using (frmAjouterSoinAssistant frm = new frmAjouterSoinAssistant())
            {
                frm.idAssistant = unAssistant.id_assistant;
                frm.unAssistantSoin = association;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = this.Location;
                frm.ShowDialog(this);

                if (!frm.ajoutConfirme) return;

                DataRow[] existantes =
                    bDB56Projet1SNGDataSet.assistant_soin.Select(
                        "id_assistant = " + association.id_assistant +
                        " AND id_soin = " + association.id_soin);

                if (existantes.Length > 0)
                {
                    MessageBox.Show("Cet assistant offre déjà ce soin.",
                        "Ajout impossible", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                bDB56Projet1SNGDataSet.assistant_soin
                    .Addassistant_soinRow(association);

                if (!Enregistrer(true)) return;

                dataTableAssistantSoinTableAdapter.Fill(
                    bDB56Projet1SNGDataSet.DataTableAssistantSoin);

                MessageBox.Show("Le soin a été ajouté à l'assistant.",
                    "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //=========================================================
        // supprimer un soin offert
        //=========================================================
        private void btnSupprimerSoin_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.assistantRow unAssistant =
                AssistantSelectionne();

            if (unAssistant == null)
            {
                MessageBox.Show("Veuillez sélectionner un assistant.",
                    "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvSoinsOfferts.CurrentRow == null ||
                dgvSoinsOfferts.CurrentRow.IsNewRow ||
                !dgvSoinsOfferts.CurrentRow.Selected)
            {
                MessageBox.Show("Veuillez sélectionner un soin.",
                    "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView ligneSoin =
                dgvSoinsOfferts.CurrentRow.DataBoundItem as DataRowView;

            if (ligneSoin == null) return;

            int idAssistant = unAssistant.id_assistant;
            int idSoin = Convert.ToInt32(ligneSoin["id_soin"]);

            try
            {
                BDB56Projet1SNGDataSet.planif_soinDataTable planifications =
                    planifSoinTableAdapter.GetByAssistantSoin(idAssistant, idSoin);

                if (planifications.Rows.Count > 0)
                {
                    MessageBox.Show(
                        "Ce soin ne peut pas être retiré car il est planifié.",
                        "Suppression impossible", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de vérifier les planifications.\n\n" +
                    ex.Message, "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(
                "Voulez-vous retirer ce soin de l'assistant ?",
                "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            DataRow[] associations =
                bDB56Projet1SNGDataSet.assistant_soin.Select(
                    "id_assistant = " + idAssistant +
                    " AND id_soin = " + idSoin);

            if (associations.Length == 0)
            {
                MessageBox.Show("Association assistant-soin introuvable.",
                    "Suppression", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            associations[0].Delete();
            if (!Enregistrer(true)) return;

            dataTableAssistantSoinTableAdapter.Fill(
                bDB56Projet1SNGDataSet.DataTableAssistantSoin);

            MessageBox.Show("Le soin a été retiré de l'assistant.",
                "Suppression", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //=========================================================
        // actualiser les assistants et leurs soins
        //=========================================================
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            // demander confirmation si des changements ne sont pas enregistres
            if (bDB56Projet1SNGDataSet.HasChanges() &&
                MessageBox.Show(
                    "Des modifications locales non enregistrées seront perdues. " +
                    "Voulez-vous actualiser les données ?",
                    "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                // vider les tables dans l'ordre des relations
                bDB56Projet1SNGDataSet.DataTableAssistantSoin.Clear();
                bDB56Projet1SNGDataSet.assistant_soin.Clear();
                bDB56Projet1SNGDataSet.assistant.Clear();

                // recuperer les donnees les plus recentes de sql server
                assistantTableAdapter.Fill(bDB56Projet1SNGDataSet.assistant);
                assistant_soinTableAdapter.Fill(
                    bDB56Projet1SNGDataSet.assistant_soin);
                dataTableAssistantSoinTableAdapter.Fill(
                    bDB56Projet1SNGDataSet.DataTableAssistantSoin);

                conflitAcces = false;

                MessageBox.Show("Les données ont été actualisées.",
                    "Actualisation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors de l'actualisation.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
