namespace Projet1SNG
{
    partial class frmGestionUtilisateurs
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionUtilisateurs));
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.utilisateurTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.utilisateurBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvUtilisateurs = new System.Windows.Forms.DataGridView();
            this.dgvIdUtil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNomUtil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMotDePasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTypeUtil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.cmbTypeUtilisateur = new System.Windows.Forms.ComboBox();
            this.typeUtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeUtilisateurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeUtilisateurTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.typeUtilisateurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingNavigator)).BeginInit();
            this.utilisateurBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistant_soinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planif_soinTableAdapter = null;
            this.tableAdapterManager.reservationTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.type_chambreTableAdapter = null;
            this.tableAdapterManager.type_soinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = this.utilisateurTableAdapter;
            // 
            // utilisateurBindingNavigator
            // 
            this.utilisateurBindingNavigator.AddNewItem = null;
            this.utilisateurBindingNavigator.BindingSource = this.utilisateurBindingSource;
            this.utilisateurBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.utilisateurBindingNavigator.DeleteItem = null;
            this.utilisateurBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.utilisateurBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.utilisateurBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.utilisateurBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.utilisateurBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.utilisateurBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.utilisateurBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.utilisateurBindingNavigator.Name = "utilisateurBindingNavigator";
            this.utilisateurBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.utilisateurBindingNavigator.Size = new System.Drawing.Size(1334, 39);
            this.utilisateurBindingNavigator.TabIndex = 0;
            this.utilisateurBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // dgvUtilisateurs
            // 
            this.dgvUtilisateurs.AllowUserToAddRows = false;
            this.dgvUtilisateurs.AllowUserToDeleteRows = false;
            this.dgvUtilisateurs.AutoGenerateColumns = false;
            this.dgvUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilisateurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdUtil,
            this.dgvNomUtil,
            this.dgvMotDePasse,
            this.dgvTypeUtil});
            this.dgvUtilisateurs.DataSource = this.utilisateurBindingSource;
            this.dgvUtilisateurs.Location = new System.Drawing.Point(67, 172);
            this.dgvUtilisateurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUtilisateurs.MultiSelect = false;
            this.dgvUtilisateurs.Name = "dgvUtilisateurs";
            this.dgvUtilisateurs.ReadOnly = true;
            this.dgvUtilisateurs.RowHeadersWidth = 51;
            this.dgvUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtilisateurs.Size = new System.Drawing.Size(923, 335);
            this.dgvUtilisateurs.TabIndex = 1;
            // 
            // dgvIdUtil
            // 
            this.dgvIdUtil.DataPropertyName = "id_util";
            this.dgvIdUtil.HeaderText = "Identifiant utilisateur";
            this.dgvIdUtil.MinimumWidth = 6;
            this.dgvIdUtil.Name = "dgvIdUtil";
            this.dgvIdUtil.ReadOnly = true;
            this.dgvIdUtil.Width = 125;
            // 
            // dgvNomUtil
            // 
            this.dgvNomUtil.DataPropertyName = "nomUtil";
            this.dgvNomUtil.HeaderText = "Nom d\'utilisateur";
            this.dgvNomUtil.MinimumWidth = 6;
            this.dgvNomUtil.Name = "dgvNomUtil";
            this.dgvNomUtil.ReadOnly = true;
            this.dgvNomUtil.Width = 125;
            // 
            // dgvMotDePasse
            // 
            this.dgvMotDePasse.DataPropertyName = "motDePasse";
            this.dgvMotDePasse.HeaderText = "Mot de passe";
            this.dgvMotDePasse.MinimumWidth = 6;
            this.dgvMotDePasse.Name = "dgvMotDePasse";
            this.dgvMotDePasse.ReadOnly = true;
            this.dgvMotDePasse.Width = 125;
            // 
            // dgvTypeUtil
            // 
            this.dgvTypeUtil.DataPropertyName = "typeUtil";
            this.dgvTypeUtil.HeaderText = "Type d\'utilisateur";
            this.dgvTypeUtil.MinimumWidth = 6;
            this.dgvTypeUtil.Name = "dgvTypeUtil";
            this.dgvTypeUtil.ReadOnly = true;
            this.dgvTypeUtil.Width = 125;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(627, 15);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(136, 38);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(771, 15);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(136, 38);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(915, 15);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(136, 38);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Location = new System.Drawing.Point(67, 79);
            this.txtNomUtilisateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(132, 22);
            this.txtNomUtilisateur.TabIndex = 6;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(220, 79);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(132, 22);
            this.txtMdp.TabIndex = 7;
            // 
            // cmbTypeUtilisateur
            // 
            this.cmbTypeUtilisateur.DataSource = this.typeUtilisateurBindingSource1;
            this.cmbTypeUtilisateur.DisplayMember = "identification";
            this.cmbTypeUtilisateur.FormattingEnabled = true;
            this.cmbTypeUtilisateur.Location = new System.Drawing.Point(387, 79);
            this.cmbTypeUtilisateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTypeUtilisateur.Name = "cmbTypeUtilisateur";
            this.cmbTypeUtilisateur.Size = new System.Drawing.Size(160, 24);
            this.cmbTypeUtilisateur.TabIndex = 8;
            this.cmbTypeUtilisateur.ValueMember = "id_typeUtil";
            // 
            // typeUtilisateurBindingSource
            // 
            this.typeUtilisateurBindingSource.DataMember = "typeUtilisateur";
            this.typeUtilisateurBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // typeUtilisateurBindingSource1
            // 
            this.typeUtilisateurBindingSource1.DataMember = "typeUtilisateur";
            this.typeUtilisateurBindingSource1.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type d\'utilisateur :";
            // 
            // typeUtilisateurTableAdapter
            // 
            this.typeUtilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // frmGestionUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 594);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTypeUtilisateur);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtNomUtilisateur);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvUtilisateurs);
            this.Controls.Add(this.utilisateurBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGestionUtilisateurs";
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.frmGestionUtilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingNavigator)).EndInit();
            this.utilisateurBindingNavigator.ResumeLayout(false);
            this.utilisateurBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator utilisateurBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvUtilisateurs;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.ComboBox cmbTypeUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource typeUtilisateurBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.typeUtilisateurTableAdapter typeUtilisateurTableAdapter;
        private System.Windows.Forms.BindingSource typeUtilisateurBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdUtil;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomUtil;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMotDePasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTypeUtil;
    }
}

