using Projet1SNG.BDB56Projet1SNGDataSetTableAdapters;
using Projet1SNG.GestionAssistant;
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
    public partial class FrmGestionAssistants : Form
    {
        // TableAdapter utilisé pour vérifier si un assistant possède des planifications.
        private BDB56Projet1SNGDataSetTableAdapters.planif_soinTableAdapter planifSoinTableAdapter = new BDB56Projet1SNGDataSetTableAdapters.planif_soinTableAdapter();
        public FrmGestionAssistants()
        {
            InitializeComponent();
        }

        private void assistantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assistantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        }

        private void FrmGestionAssistants_Load(object sender, EventArgs e)
        {
            
            this.assistant_soinTableAdapter.Fill(this.bDB56Projet1SNGDataSet.assistant_soin);

            // TODO: This line of code loads data into the 'bDB56Projet1SNGDataSet.DataTableAssistantSoin' table. You can move, or remove it, as needed.
            this.dataTableAssistantSoinTableAdapter.Fill(this.bDB56Projet1SNGDataSet.DataTableAssistantSoin);

            // TODO: This line of code loads data into the 'bDB56Projet1SNGDataSet.assistant' table. You can move, or remove it, as needed.
            this.assistantTableAdapter.Fill(this.bDB56Projet1SNGDataSet.assistant);
            if (assistantBindingSource.Position < 0)
            {
                MessageBox.Show("Aucun assistant sélectionné.");
                return;
            }

        }

        private void btnAjouterAssistant_Click(object sender, EventArgs e)
        {
            // Créer une nouvelle ligne en mémoire.
            BDB56Projet1SNGDataSet.assistantRow unAssistant =
                bDB56Projet1SNGDataSet.assistant.NewassistantRow();

            // Trouver le plus grand numéro existant.
            int idMax = 0;

            foreach (BDB56Projet1SNGDataSet.assistantRow ligne
                in bDB56Projet1SNGDataSet.assistant.Rows)
            {
                if (ligne.id_assistant > idMax)
                {
                    idMax = ligne.id_assistant;
                }
            }

            // Générer automatiquement le prochain numéro.
            unAssistant.id_assistant = idMax + 1;

            // Ouvrir le formulaire d'ajout.
            frmAjouterAssistant frmAjouter =
                new frmAjouterAssistant();

            frmAjouter.unAssistant = unAssistant;

            frmAjouter.ShowDialog();

            // Ajouter réellement la ligne seulement
            // si l'utilisateur a cliqué sur Enregistrer.
            if (frmAjouter.ajoutConfirme)
            {
                try
                {
                    // Ajouter l'assistant dans le DataSet.
                    bDB56Projet1SNGDataSet.assistant
                        .AddassistantRow(unAssistant);

                    assistantBindingSource.EndEdit();

                    // Enregistrer immédiatement dans SQL Server.
                    assistantTableAdapter.Update(
                        bDB56Projet1SNGDataSet.assistant
                    );

                    assistantBindingSource.MoveLast();

                    MessageBox.Show(
                        "L'assistant " +
                        unAssistant.id_assistant +
                        " a été ajouté.",
                        "Ajout d'un assistant",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erreur lors de l'ajout de l'assistant.\n\n" +
                        ex.Message,
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnModifierAssistant_Click(object sender, EventArgs e)
        {
            // Vérifier qu'un assistant est sélectionné.
            if (assistantBindingSource.Current == null)
            {
                MessageBox.Show(
                    "Aucun assistant sélectionné.",
                    "Modification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // Récupérer la ligne sélectionnée.
            DataRowView ligneSelectionnee =
                (DataRowView)assistantBindingSource.Current;

            BDB56Projet1SNGDataSet.assistantRow unAssistant =
                (BDB56Projet1SNGDataSet.assistantRow)
                ligneSelectionnee.Row;


            // Ouvrir le formulaire de modification.
            frmGestionAssistantModifier frmModifier =
                new frmGestionAssistantModifier();

            frmModifier.unAssistant = unAssistant;

            frmModifier.ShowDialog();

            // Si l'utilisateur a confirmé,
            // actualiser l'affichage.
            if (frmModifier.modificationConfirmee)
            {
                assistantBindingSource.ResetCurrentItem();
                assistantBindingSource.EndEdit();

                assistantTableAdapter.Update(
                    bDB56Projet1SNGDataSet.assistant
                );
            }
        }

        private void btnSupAssistant_Click(object sender, EventArgs e)
        {
            // Vérifier qu'un assistant est sélectionné.
            if (assistantBindingSource.Current == null)
            {
                MessageBox.Show(
                    "Veuillez sélectionner un assistant.",
                    "Suppression",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // Récupérer l'assistant sélectionné.
            DataRowView ligneSelectionnee =
                (DataRowView)assistantBindingSource.Current;

            BDB56Projet1SNGDataSet.assistantRow unAssistant =
                (BDB56Projet1SNGDataSet.assistantRow)
                ligneSelectionnee.Row;

            int idAssistant = unAssistant.id_assistant;


            //=========================================================
            // Vérifier si l'assistant possède une planification
            //=========================================================

            // Vérifier si l'assistant possède une planification
            BDB56Projet1SNGDataSet.planif_soinDataTable planifications =
                planifSoinTableAdapter.GetByNbPlanifByAssistant(idAssistant);

            if (planifications.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Cet assistant ne peut pas être supprimé " +
                    "car des soins lui sont assignés dans une planification.",
                    "Suppression impossible",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            //=========================================================
            // Confirmation
            //=========================================================

            DialogResult reponse = MessageBox.Show(
                "Voulez-vous vraiment supprimer l'assistant " +
                unAssistant.prenom + " " +
                unAssistant.nom + " ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (reponse != DialogResult.Yes)
            {
                return;
            }


            //=========================================================
            // Suppression
            //=========================================================

            try
            {
                //=====================================================
                // 1. Supprimer les soins offerts par l'assistant
                //=====================================================

                DataRow[] soinsAssistant =
                    bDB56Projet1SNGDataSet.assistant_soin.Select(
                        "id_assistant = " + idAssistant
                    );

                foreach (DataRow ligne in soinsAssistant)
                {
                    ligne.Delete();
                }

                // IMPORTANT :
                // enregistrer les suppressions de assistant_soin
                // AVANT de supprimer l'assistant.
                assistant_soinTableAdapter.Update(
                    bDB56Projet1SNGDataSet.assistant_soin
                );


                //=====================================================
                // 2. Supprimer l'assistant
                //=====================================================

                unAssistant.Delete();

                assistantTableAdapter.Update(
                    bDB56Projet1SNGDataSet.assistant
                );


                //=====================================================
                // 3. Actualiser les données
                //=====================================================

                assistantTableAdapter.Fill(
                    bDB56Projet1SNGDataSet.assistant
                );

                assistant_soinTableAdapter.Fill(
                    bDB56Projet1SNGDataSet.assistant_soin
                );

                dataTableAssistantSoinTableAdapter.Fill(
                    bDB56Projet1SNGDataSet.DataTableAssistantSoin
                );


                MessageBox.Show(
                    "L'assistant a été supprimé.",
                    "Suppression",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors de la suppression de l'assistant.\n\n" +
                    ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //=========================================================
        // Ajouter un soin à un assistant
        //=========================================================

        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {
            // Vérifier qu'un assistant est sélectionné.
            if (assistantBindingSource.Current == null)
            {
                MessageBox.Show(
                    "Veuillez sélectionner un assistant.",
                    "Ajout d'un soin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // Récupérer l'assistant sélectionné.
            DataRowView ligneSelectionnee =
                (DataRowView)assistantBindingSource.Current;

            BDB56Projet1SNGDataSet.assistantRow unAssistant =
                (BDB56Projet1SNGDataSet.assistantRow)
                ligneSelectionnee.Row;

            int idAssistant =
                unAssistant.id_assistant;


            // Créer une nouvelle association assistant-soin.
            BDB56Projet1SNGDataSet.assistant_soinRow unAssistantSoin =
                bDB56Projet1SNGDataSet.assistant_soin
                .Newassistant_soinRow();


            // Ouvrir le formulaire d'ajout de soin.
            frmAjouterSoinAssistant frmAjouter =
                new frmAjouterSoinAssistant();

            frmAjouter.idAssistant =
                idAssistant;

            frmAjouter.unAssistantSoin =
                unAssistantSoin;

            frmAjouter.ShowDialog();


            // Ajouter seulement si l'utilisateur confirme.
            if (frmAjouter.ajoutConfirme)
            {
                try
                {
                    int idSoin =
                        unAssistantSoin.id_soin;


                    // Vérifier que l'assistant n'offre pas déjà ce soin.
                    DataRow[] lignesExistantes =
                        bDB56Projet1SNGDataSet.assistant_soin.Select(
                            "id_assistant = " + idAssistant +
                            " AND id_soin = " + idSoin
                        );

                    if (lignesExistantes.Length > 0)
                    {
                        MessageBox.Show(
                            "Cet assistant offre déjà ce soin.",
                            "Ajout impossible",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }


                    // Ajouter l'association dans assistant_soin.
                    bDB56Projet1SNGDataSet.assistant_soin
                        .Addassistant_soinRow(unAssistantSoin);

                    assistant_soinBindingSource.EndEdit();


                    // Enregistrer dans SQL Server.
                    assistant_soinTableAdapter.Update(
                        bDB56Projet1SNGDataSet.assistant_soin
                    );


                    // Actualiser la table utilisée par la grille des soins.
                    dataTableAssistantSoinTableAdapter.Fill(
                        bDB56Projet1SNGDataSet.DataTableAssistantSoin
                    );


                    MessageBox.Show(
                        "Le soin a été ajouté à l'assistant.",
                        "Ajout d'un soin",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erreur lors de l'ajout du soin.\n\n" +
                        ex.Message,
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnSupprimerSoin_Click(object sender, EventArgs e)
        {
            // Vérifier qu'un assistant est sélectionné.
            if (assistantBindingSource.Current == null)
            {
                MessageBox.Show(
                    "Veuillez sélectionner un assistant.",
                    "Suppression",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // Vérifier qu'un soin est sélectionné.
            if (dataTableAssistantSoinBindingSource.Current == null)
            {
                MessageBox.Show(
                    "Veuillez sélectionner un soin.",
                    "Suppression",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            //=========================================================
            // Récupérer l'assistant sélectionné
            //=========================================================

            DataRowView ligneAssistant =
                (DataRowView)assistantBindingSource.Current;

            BDB56Projet1SNGDataSet.assistantRow unAssistant =
                (BDB56Projet1SNGDataSet.assistantRow)
                ligneAssistant.Row;

            int idAssistant =
                unAssistant.id_assistant;


            //=========================================================
            // Récupérer le soin sélectionné
            //=========================================================

            DataRowView ligneSoin =
                (DataRowView)dataTableAssistantSoinBindingSource.Current;

            int idSoin =
                Convert.ToInt32(
                    ligneSoin["id_soin"]
                );


            //=========================================================
            // Vérifier si ce soin est planifié pour cet assistant
            //=========================================================

            BDB56Projet1SNGDataSet.planif_soinDataTable planifications =
                planifSoinTableAdapter.GetByAssistantSoin(
                    idAssistant,
                    idSoin
                );


            if (planifications.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Ce soin ne peut pas être retiré de l'assistant " +
                    "car il est présent dans une planification.",
                    "Suppression impossible",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            //=========================================================
            // Confirmation
            //=========================================================

            DialogResult reponse =
                MessageBox.Show(
                    "Voulez-vous vraiment retirer ce soin de l'assistant ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (reponse != DialogResult.Yes)
            {
                return;
            }


            //=========================================================
            // Trouver l'association assistant_soin
            //=========================================================

            DataRow[] lignes =
                bDB56Projet1SNGDataSet.assistant_soin.Select(
                    "id_assistant = " + idAssistant +
                    " AND id_soin = " + idSoin
                );


            if (lignes.Length == 0)
            {
                MessageBox.Show(
                    "Association assistant-soin introuvable.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            //=========================================================
            // Supprimer l'association
            //=========================================================

            lignes[0].Delete();


            // Sauvegarder dans SQL Server.
            this.assistant_soinTableAdapter.Update(
                this.bDB56Projet1SNGDataSet.assistant_soin
            );


            // Actualiser la grille d'affichage.
            this.dataTableAssistantSoinTableAdapter.Fill(
                this.bDB56Projet1SNGDataSet.DataTableAssistantSoin
            );


            MessageBox.Show(
                "Le soin a été retiré de l'assistant.",
                "Suppression",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        //=========================================================
        // fermer le formulaire
        //=========================================================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
        //=========================================================
        //enregistrées dans SQL Server cas securité
        //=========================================================
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.assistantBindingSource.EndEdit();
                this.assistant_soinBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(
                    this.bDB56Projet1SNGDataSet
                );

                MessageBox.Show(
                    "Les modifications ont été enregistrées.",
                    "Enregistrement",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors de l'enregistrement.\n\n" +
                    ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
