namespace Projet1SNG.GestionChambre
{
    partial class frmGestionChambre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTypeChambres = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSupType = new System.Windows.Forms.Button();
            this.btnModifierType = new System.Windows.Forms.Button();
            this.btnAjouterType = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvChambres = new System.Windows.Forms.DataGridView();
            this.chambreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSupChambre = new System.Windows.Forms.Button();
            this.btnAjouterChambre = new System.Windows.Forms.Button();
            this.btnModifierChambre = new System.Windows.Forms.Button();
            this.chambreBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.chambreTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.type_chambreTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.type_chambreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_chambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des chambres et leurs types";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(39, 133);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.dgvTypeChambres);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnSupType);
            this.splitContainer1.Panel1.Controls.Add(this.btnModifierType);
            this.splitContainer1.Panel1.Controls.Add(this.btnAjouterType);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.dgvChambres);
            this.splitContainer1.Panel2.Controls.Add(this.btnSupChambre);
            this.splitContainer1.Panel2.Controls.Add(this.btnAjouterChambre);
            this.splitContainer1.Panel2.Controls.Add(this.btnModifierChambre);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 480);
            this.splitContainer1.SplitterDistance = 534;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvTypeChambres
            // 
            this.dgvTypeChambres.AllowUserToAddRows = false;
            this.dgvTypeChambres.AllowUserToDeleteRows = false;
            this.dgvTypeChambres.AutoGenerateColumns = false;
            this.dgvTypeChambres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTypeChambres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTypeChambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeChambres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvTypeChambres.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.chambreBindingSource, "id_typeChambre", true));
            this.dgvTypeChambres.DataSource = this.type_chambreBindingSource;
            this.dgvTypeChambres.Location = new System.Drawing.Point(17, 87);
            this.dgvTypeChambres.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTypeChambres.Name = "dgvTypeChambres";
            this.dgvTypeChambres.ReadOnly = true;
            this.dgvTypeChambres.RowHeadersWidth = 24;
            this.dgvTypeChambres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeChambres.Size = new System.Drawing.Size(503, 321);
            this.dgvTypeChambres.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Les type de la chambre";
            // 
            // btnSupType
            // 
            this.btnSupType.Location = new System.Drawing.Point(348, 427);
            this.btnSupType.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupType.Name = "btnSupType";
            this.btnSupType.Size = new System.Drawing.Size(124, 33);
            this.btnSupType.TabIndex = 7;
            this.btnSupType.Text = "Supprimer";
            this.btnSupType.UseVisualStyleBackColor = true;
            this.btnSupType.Click += new System.EventHandler(this.btnSupType_Click);
            // 
            // btnModifierType
            // 
            this.btnModifierType.Location = new System.Drawing.Point(197, 427);
            this.btnModifierType.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierType.Name = "btnModifierType";
            this.btnModifierType.Size = new System.Drawing.Size(124, 33);
            this.btnModifierType.TabIndex = 6;
            this.btnModifierType.Text = "Modifier";
            this.btnModifierType.UseVisualStyleBackColor = true;
            this.btnModifierType.Click += new System.EventHandler(this.btnModifierType_Click);
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.Location = new System.Drawing.Point(43, 427);
            this.btnAjouterType.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(124, 33);
            this.btnAjouterType.TabIndex = 5;
            this.btnAjouterType.Text = "Ajouter";
            this.btnAjouterType.UseVisualStyleBackColor = true;
            this.btnAjouterType.Click += new System.EventHandler(this.btnAjouterType_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Les chambres";
            // 
            // dgvChambres
            // 
            this.dgvChambres.AllowUserToAddRows = false;
            this.dgvChambres.AllowUserToDeleteRows = false;
            this.dgvChambres.AutoGenerateColumns = false;
            this.dgvChambres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChambres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChambres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvChambres.DataSource = this.chambreBindingSource1;
            this.dgvChambres.Location = new System.Drawing.Point(15, 87);
            this.dgvChambres.Name = "dgvChambres";
            this.dgvChambres.ReadOnly = true;
            this.dgvChambres.RowHeadersWidth = 24;
            this.dgvChambres.RowTemplate.Height = 24;
            this.dgvChambres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChambres.Size = new System.Drawing.Size(454, 321);
            this.dgvChambres.TabIndex = 5;
            // 
            // chambreBindingSource1
            // 
            this.chambreBindingSource1.DataMember = "fk_typeChambre";
            this.chambreBindingSource1.DataSource = this.type_chambreBindingSource;
            // 
            // btnSupChambre
            // 
            this.btnSupChambre.Location = new System.Drawing.Point(357, 427);
            this.btnSupChambre.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupChambre.Name = "btnSupChambre";
            this.btnSupChambre.Size = new System.Drawing.Size(124, 33);
            this.btnSupChambre.TabIndex = 4;
            this.btnSupChambre.Text = "Supprimer";
            this.btnSupChambre.UseVisualStyleBackColor = true;
            this.btnSupChambre.Click += new System.EventHandler(this.btnSupChambre_Click);
            // 
            // btnAjouterChambre
            // 
            this.btnAjouterChambre.Location = new System.Drawing.Point(59, 427);
            this.btnAjouterChambre.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterChambre.Name = "btnAjouterChambre";
            this.btnAjouterChambre.Size = new System.Drawing.Size(124, 33);
            this.btnAjouterChambre.TabIndex = 2;
            this.btnAjouterChambre.Text = "Ajouter";
            this.btnAjouterChambre.UseVisualStyleBackColor = true;
            this.btnAjouterChambre.Click += new System.EventHandler(this.btnAjouterChambre_Click);
            // 
            // btnModifierChambre
            // 
            this.btnModifierChambre.Location = new System.Drawing.Point(206, 427);
            this.btnModifierChambre.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierChambre.Name = "btnModifierChambre";
            this.btnModifierChambre.Size = new System.Drawing.Size(124, 33);
            this.btnModifierChambre.TabIndex = 3;
            this.btnModifierChambre.Text = "Modifier";
            this.btnModifierChambre.UseVisualStyleBackColor = true;
            this.btnModifierChambre.Click += new System.EventHandler(this.btnModifierChambre_Click);
            // 
            // chambreBindingNavigator
            // 
            this.chambreBindingNavigator.AddNewItem = null;
            this.chambreBindingNavigator.BindingSource = this.chambreBindingSource;
            this.chambreBindingNavigator.CountItem = null;
            this.chambreBindingNavigator.DeleteItem = null;
            this.chambreBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.chambreBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.chambreBindingNavigator.MoveFirstItem = null;
            this.chambreBindingNavigator.MoveLastItem = null;
            this.chambreBindingNavigator.MoveNextItem = null;
            this.chambreBindingNavigator.MovePreviousItem = null;
            this.chambreBindingNavigator.Name = "chambreBindingNavigator";
            this.chambreBindingNavigator.PositionItem = null;
            this.chambreBindingNavigator.Size = new System.Drawing.Size(1123, 25);
            this.chambreBindingNavigator.TabIndex = 3;
            this.chambreBindingNavigator.Text = "bindingNavigator1";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFermer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFermer.Location = new System.Drawing.Point(436, 640);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(124, 33);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnActualiser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualiser.Location = new System.Drawing.Point(568, 640);
            this.btnActualiser.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(124, 33);
            this.btnActualiser.TabIndex = 9;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "chambre";
            this.chambreBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_typeChambre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type chambre";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "prixHaut";
            this.dataGridViewTextBoxColumn7.HeaderText = "Prix Haut";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "prixMoyen";
            this.dataGridViewTextBoxColumn8.HeaderText = "Prix Moyen";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "prixBas";
            this.dataGridViewTextBoxColumn9.HeaderText = "Prix Bas";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // type_chambreBindingSource
            // 
            this.type_chambreBindingSource.DataMember = "type_chambre";
            this.type_chambreBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_chambre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id chambre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "emplacement";
            this.dataGridViewTextBoxColumn2.HeaderText = "Emplacement";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "decoration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Décoration";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistant_soinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = this.chambreTableAdapter;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planif_soinTableAdapter = null;
            this.tableAdapterManager.reservationTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.type_chambreTableAdapter = this.type_chambreTableAdapter;
            this.tableAdapterManager.type_soinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // type_chambreTableAdapter
            // 
            this.type_chambreTableAdapter.ClearBeforeFill = true;
            // 
            // frmGestionChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1123, 686);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.chambreBindingNavigator);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGestionChambre";
            this.Text = "Gestion Chambre";
            this.Load += new System.EventHandler(this.frmGestionChambre_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_chambreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.chambreTableAdapter chambreTableAdapter;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator chambreBindingNavigator;
        private BDB56Projet1SNGDataSetTableAdapters.type_chambreTableAdapter type_chambreTableAdapter;
        private System.Windows.Forms.BindingSource type_chambreBindingSource;
        private System.Windows.Forms.DataGridView dgvTypeChambres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnSupChambre;
        private System.Windows.Forms.Button btnModifierChambre;
        private System.Windows.Forms.Button btnAjouterChambre;
        private System.Windows.Forms.Button btnSupType;
        private System.Windows.Forms.Button btnModifierType;
        private System.Windows.Forms.Button btnAjouterType;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvChambres;
        private System.Windows.Forms.BindingSource chambreBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnActualiser;
    }
}