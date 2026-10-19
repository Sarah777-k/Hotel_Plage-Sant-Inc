using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Projet1SNG.GestionChambre
{
    public partial class frmGestionChambre : Form
    {
        private BDB56Projet1SNGDataSetTableAdapters.reservationTableAdapter
            reservationTableAdapter =
            new BDB56Projet1SNGDataSetTableAdapters.reservationTableAdapter();

        private bool conflitAcces = false;

        public frmGestionChambre()
        {
            InitializeComponent();
        }

        private void frmGestionChambre_Load(object sender, EventArgs e)
        {
            type_chambreTableAdapter.Fill(bDB56Projet1SNGDataSet.type_chambre);
            chambreTableAdapter.Fill(bDB56Projet1SNGDataSet.chambre);

           
            chambreTableAdapter.Adapter.RowUpdated += TableAdapter_RowUpdated;
            type_chambreTableAdapter.Adapter.RowUpdated += TableAdapter_RowUpdated;

            // Afficher les trois prix en dollars canadiens.
            foreach (DataGridViewColumn colonne in new DataGridViewColumn[]
            {
                dataGridViewTextBoxColumn7,
                dataGridViewTextBoxColumn8,
                dataGridViewTextBoxColumn9
            })
            {
                colonne.DefaultCellStyle.Format = "C2";
                colonne.DefaultCellStyle.FormatProvider =
                    CultureInfo.GetCultureInfo("en-CA");
                colonne.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }
        }

        // Gestion commune des conflits, selon RowUpdated du labo 6.
        private void TableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected != 0 ||
                (e.StatementType != StatementType.Update &&
                 e.StatementType != StatementType.Delete) ||
                (e.Errors != null && !(e.Errors is DBConcurrencyException)))
                return;

            bool estChambre = e.Row.Table.TableName == "chambre";
            string nom = estChambre ? "la chambre " : "le type de chambre ";
            string colonneId = estChambre ? "id_chambre" : "id_typeChambre";
            string numero = e.Row[colonneId, DataRowVersion.Original].ToString();

            MessageBox.Show(
                "Conflit d'accès concurrentiel pour " + nom + numero +
                ". Cet enregistrement ne sera pas sauvegardé.",
                "Conflit d'accès", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            conflitAcces = true;
            e.Status = UpdateStatus.Continue;
        }

        // Une seule méthode pour les Update et leurs erreurs.
        // Elle annule la modification locale en cas d'échec, sans recharger les tables.
        private bool Enregistrer(DataRow ligne)
        {
            conflitAcces = false;
            bool estChambre = ligne.Table == bDB56Projet1SNGDataSet.chambre;

            try
            {
                if (estChambre)
                    chambreTableAdapter.Update(bDB56Projet1SNGDataSet.chambre);
                else
                    type_chambreTableAdapter.Update(bDB56Projet1SNGDataSet.type_chambre);

                if (conflitAcces)
                {
                    AnnulerLigne(ligne);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                AnnulerLigne(ligne);

                if (!conflitAcces)
                {
                    string message = ex is DBConcurrencyException
                        ? "Cet enregistrement a été modifié ou supprimé par un autre utilisateur."
                        : "L'enregistrement a échoué.\n\n" + ex.Message;

                    MessageBox.Show(message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return false;
            }
        }

        // Ajout d'une ligne typée dans son DataSet, puis sauvegarde SQL.
        private bool AjouterLigne(DataRow ligne)
        {
            try
            {
                ligne.Table.Rows.Add(ligne);
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'ajout est impossible.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return Enregistrer(ligne);
        }

        private void AnnulerLigne(DataRow ligne)
        {
            if (ligne.RowState == DataRowState.Added ||
                ligne.RowState == DataRowState.Modified ||
                ligne.RowState == DataRowState.Deleted)
                ligne.RejectChanges();
        }

        private bool ConfirmerSuppression(string nom)
        {
            return MessageBox.Show("Voulez-vous supprimer " + nom + " ?",
                "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void OuvrirFormulaire(Form formulaire)
        {
            formulaire.StartPosition = FormStartPosition.Manual;
            formulaire.Location = this.Location;
            formulaire.ShowDialog(this);
        }

        // Sélection réelle dans la grille des types (pas le dernier BindingSource.Current).
        private BDB56Projet1SNGDataSet.type_chambreRow TypeSelectionne()
        {
            if (dgvTypeChambres.CurrentRow == null ||
                dgvTypeChambres.CurrentRow.IsNewRow ||
                !dgvTypeChambres.CurrentRow.Selected)
                return null;

            DataRowView ligne = dgvTypeChambres.CurrentRow.DataBoundItem as DataRowView;
            return ligne == null ? null :
                ligne.Row as BDB56Projet1SNGDataSet.type_chambreRow;
        }

        // dgvChambres est déjà liée à chambreBindingSource1 (relation fk_typeChambre).
        private BDB56Projet1SNGDataSet.chambreRow ChambreSelectionnee()
        {
            if (dgvChambres.CurrentRow == null ||
                dgvChambres.CurrentRow.IsNewRow)
                return null;

            DataRowView ligne = dgvChambres.CurrentRow.DataBoundItem as DataRowView;
            return ligne == null ? null :
                ligne.Row as BDB56Projet1SNGDataSet.chambreRow;
        }

        // =========================================================
        // TYPES DE CHAMBRES
        // =========================================================
        private void btnAjouterType_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.type_chambreRow unType =
                bDB56Projet1SNGDataSet.type_chambre.Newtype_chambreRow();

            int idMax = 0;
            foreach (BDB56Projet1SNGDataSet.type_chambreRow ligne
                in bDB56Projet1SNGDataSet.type_chambre.Rows)
                if (ligne.RowState != DataRowState.Deleted &&
                    ligne.id_typeChambre > idMax)
                    idMax = ligne.id_typeChambre;

            unType.id_typeChambre = idMax + 1;

            using (frmAjouterTypeChambre frm = new frmAjouterTypeChambre())
            {
                frm.unTypeChambre = unType;
                frm.typesExistants = bDB56Projet1SNGDataSet.type_chambre;
                OuvrirFormulaire(frm);
                if (!frm.ajoutConfirme) return;
            }

            if (!AjouterLigne(unType)) return;

            type_chambreBindingSource.ResetBindings(false);
            MessageBox.Show("Le type de chambre a été ajouté.", "Ajout");
        }

        private void btnModifierType_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.type_chambreRow unType = TypeSelectionne();
            if (unType == null)
            {
                MessageBox.Show("Veuillez sélectionner un type de chambre.");
                return;
            }

            using (frmModifierTypeChambre frm = new frmModifierTypeChambre())
            {
                frm.unTypeChambre = unType;
                frm.typesExistants = bDB56Projet1SNGDataSet.type_chambre;
                OuvrirFormulaire(frm);
                if (!frm.modificationConfirmee) return;
            }

            if (!Enregistrer(unType)) return;

            type_chambreBindingSource.ResetBindings(false);
            MessageBox.Show("Le type de chambre a été modifié.", "Modification");
        }

        private void btnSupType_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.type_chambreRow unType = TypeSelectionne();
            if (unType == null)
            {
                MessageBox.Show("Veuillez sélectionner un type de chambre.");
                return;
            }

            int idType = unType.id_typeChambre;
            try
            {
                // Vérifier la règle métier : pas de type ayant des chambres.
                chambreTableAdapter.Fill(bDB56Projet1SNGDataSet.chambre);
                foreach (BDB56Projet1SNGDataSet.chambreRow chambre
                    in bDB56Projet1SNGDataSet.chambre.Rows)
                {
                    if (chambre.RowState != DataRowState.Deleted &&
                        chambre.id_typeChambre == idType)
                    {
                        MessageBox.Show("Impossible de supprimer ce type : " +
                            "il possède des chambres.", "Suppression impossible");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de vérifier les chambres.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ConfirmerSuppression("le type " + unType.description)) return;

            unType.Delete();
            if (!Enregistrer(unType)) return;

            type_chambreBindingSource.ResetBindings(false);
            MessageBox.Show("Le type de chambre a été supprimé.", "Suppression");
        }

        // =========================================================
        // CHAMBRES
        // =========================================================
        private void btnAjouterChambre_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.type_chambreRow type = TypeSelectionne();
            if (type == null)
            {
                MessageBox.Show("Veuillez sélectionner un type de chambre.");
                return;
            }

            BDB56Projet1SNGDataSet.chambreRow chambre =
                bDB56Projet1SNGDataSet.chambre.NewchambreRow();

            int idMax = 0;
            foreach (BDB56Projet1SNGDataSet.chambreRow ligne
                in bDB56Projet1SNGDataSet.chambre.Rows)
                if (ligne.RowState != DataRowState.Deleted && ligne.id_chambre > idMax)
                    idMax = ligne.id_chambre;

            chambre.id_chambre = idMax + 1;
            chambre.id_typeChambre = type.id_typeChambre;

            using (frmAjouterChambre frm = new frmAjouterChambre())
            {
                frm.uneChambre = chambre;
                frm.typesExistants = bDB56Projet1SNGDataSet.type_chambre;
                OuvrirFormulaire(frm);
                if (!frm.ajoutConfirme) return;
            }

            if (!AjouterLigne(chambre)) return;

            chambreBindingSource1.ResetBindings(false);
            MessageBox.Show("La chambre " + chambre.id_chambre + " a été ajoutée.", "Ajout");
        }

        private void btnModifierChambre_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.chambreRow chambre = ChambreSelectionnee();
            if (chambre == null)
            {
                MessageBox.Show("Veuillez sélectionner une chambre.");
                return;
            }

            using (frmModifierChambre frm = new frmModifierChambre())
            {
                frm.uneChambre = chambre;
                OuvrirFormulaire(frm);
                if (!frm.modificationConfirmee) return;
            }

            if (!Enregistrer(chambre)) return;

            chambreBindingSource1.ResetBindings(false);
            MessageBox.Show("La chambre a été modifiée.", "Modification");
        }

        private void btnSupChambre_Click(object sender, EventArgs e)
        {
            BDB56Projet1SNGDataSet.chambreRow chambre = ChambreSelectionnee();
            if (chambre == null)
            {
                MessageBox.Show("Veuillez sélectionner une chambre.");
                return;
            }

            int idChambre = chambre.id_chambre;
            try
            {
                // Une chambre ayant des réservations ne peut pas être supprimée.
                if (reservationTableAdapter.GetDataByChambre(idChambre).Rows.Count > 0)
                {
                    MessageBox.Show("Impossible de supprimer la chambre " + idChambre +
                        " : elle possède des réservations.", "Suppression impossible");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de vérifier les réservations.\n\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ConfirmerSuppression("la chambre " + idChambre)) return;

            chambre.Delete();
            if (!Enregistrer(chambre)) return;

            chambreBindingSource1.ResetBindings(false);
            MessageBox.Show("La chambre " + idChambre + " a été supprimée.", "Suppression");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==============================================================================
        //lors dun conflit d'acces on actualise le formulaire pour recuperer les donnees 
        //==============================================================================
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            try
            {
                // Annuler les modifications locales non enregistrées.
                bDB56Projet1SNGDataSet.chambre.RejectChanges();
                bDB56Projet1SNGDataSet.type_chambre.RejectChanges();

                // Vider les anciennes données (enfant avant parent).
                bDB56Projet1SNGDataSet.chambre.Clear();
                bDB56Projet1SNGDataSet.type_chambre.Clear();

                // Récupérer les dernières données de SQL Server.
                type_chambreTableAdapter.Fill(
                    bDB56Projet1SNGDataSet.type_chambre
                );

                chambreTableAdapter.Fill(
                    bDB56Projet1SNGDataSet.chambre
                );

                conflitAcces = false;

                MessageBox.Show(
                    "Les données ont été actualisées.",
                    "Actualisation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors de l'actualisation.\n" + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
