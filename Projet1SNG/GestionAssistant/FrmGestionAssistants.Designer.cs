namespace Projet1SNG
{
    partial class FrmGestionAssistants
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
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.dgvAssistants = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistant_soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableAssistantSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSoinsOfferts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouterAssistant = new System.Windows.Forms.Button();
            this.btnModifierAssistant = new System.Windows.Forms.Button();
            this.btnSupAssistant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSupprimerSoin = new System.Windows.Forms.Button();
            this.btnAjouterSoin = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.assistantTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.assistantTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.assistant_soinTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.assistant_soinTableAdapter();
            this.dataTableAssistantSoinTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.DataTableAssistantSoinTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistant_soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAssistantSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoinsOfferts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "assistant";
            this.assistantBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvAssistants
            // 
            this.dgvAssistants.AllowUserToAddRows = false;
            this.dgvAssistants.AllowUserToDeleteRows = false;
            this.dgvAssistants.AutoGenerateColumns = false;
            this.dgvAssistants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAssistants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAssistants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssistants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvAssistants.DataSource = this.assistantBindingSource;
            this.dgvAssistants.Location = new System.Drawing.Point(12, 53);
            this.dgvAssistants.Name = "dgvAssistants";
            this.dgvAssistants.ReadOnly = true;
            this.dgvAssistants.RowHeadersWidth = 17;
            this.dgvAssistants.RowTemplate.Height = 24;
            this.dgvAssistants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssistants.Size = new System.Drawing.Size(545, 327);
            this.dgvAssistants.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_assistant";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id assistant";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 103;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 83;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "specialite";
            this.dataGridViewTextBoxColumn4.HeaderText = "Specialite";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 96;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "remarque";
            this.dataGridViewTextBoxColumn5.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // assistant_soinBindingSource
            // 
            this.assistant_soinBindingSource.DataMember = "fk_assistant";
            this.assistant_soinBindingSource.DataSource = this.assistantBindingSource;
            // 
            // dataTableAssistantSoinBindingSource
            // 
            this.dataTableAssistantSoinBindingSource.DataMember = "fk_assistant1";
            this.dataTableAssistantSoinBindingSource.DataSource = this.assistantBindingSource;
            // 
            // dgvSoinsOfferts
            // 
            this.dgvSoinsOfferts.AllowUserToAddRows = false;
            this.dgvSoinsOfferts.AllowUserToDeleteRows = false;
            this.dgvSoinsOfferts.AutoGenerateColumns = false;
            this.dgvSoinsOfferts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoinsOfferts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSoinsOfferts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoinsOfferts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvSoinsOfferts.DataSource = this.dataTableAssistantSoinBindingSource;
            this.dgvSoinsOfferts.Location = new System.Drawing.Point(44, 53);
            this.dgvSoinsOfferts.Name = "dgvSoinsOfferts";
            this.dgvSoinsOfferts.ReadOnly = true;
            this.dgvSoinsOfferts.RowHeadersWidth = 24;
            this.dgvSoinsOfferts.RowTemplate.Height = 24;
            this.dgvSoinsOfferts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoinsOfferts.Size = new System.Drawing.Size(343, 327);
            this.dgvSoinsOfferts.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_soin";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id soin";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn9.HeaderText = "Description";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestion des assistants et leurs soins ";
            // 
            // btnAjouterAssistant
            // 
            this.btnAjouterAssistant.Location = new System.Drawing.Point(56, 397);
            this.btnAjouterAssistant.Name = "btnAjouterAssistant";
            this.btnAjouterAssistant.Size = new System.Drawing.Size(92, 36);
            this.btnAjouterAssistant.TabIndex = 5;
            this.btnAjouterAssistant.Text = "Ajouter";
            this.btnAjouterAssistant.UseVisualStyleBackColor = true;
            this.btnAjouterAssistant.Click += new System.EventHandler(this.btnAjouterAssistant_Click);
            // 
            // btnModifierAssistant
            // 
            this.btnModifierAssistant.Location = new System.Drawing.Point(208, 397);
            this.btnModifierAssistant.Name = "btnModifierAssistant";
            this.btnModifierAssistant.Size = new System.Drawing.Size(94, 36);
            this.btnModifierAssistant.TabIndex = 6;
            this.btnModifierAssistant.Text = "Modifier";
            this.btnModifierAssistant.UseVisualStyleBackColor = true;
            this.btnModifierAssistant.Click += new System.EventHandler(this.btnModifierAssistant_Click);
            // 
            // btnSupAssistant
            // 
            this.btnSupAssistant.BackColor = System.Drawing.SystemColors.Control;
            this.btnSupAssistant.Location = new System.Drawing.Point(356, 397);
            this.btnSupAssistant.Name = "btnSupAssistant";
            this.btnSupAssistant.Size = new System.Drawing.Size(92, 36);
            this.btnSupAssistant.TabIndex = 7;
            this.btnSupAssistant.Text = "Supprimer";
            this.btnSupAssistant.UseVisualStyleBackColor = false;
            this.btnSupAssistant.Click += new System.EventHandler(this.btnSupAssistant_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Assistants";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soins offerts";
            // 
            // btnSupprimerSoin
            // 
            this.btnSupprimerSoin.BackColor = System.Drawing.SystemColors.Control;
            this.btnSupprimerSoin.Location = new System.Drawing.Point(249, 397);
            this.btnSupprimerSoin.Name = "btnSupprimerSoin";
            this.btnSupprimerSoin.Size = new System.Drawing.Size(92, 36);
            this.btnSupprimerSoin.TabIndex = 12;
            this.btnSupprimerSoin.Text = "Supprimer";
            this.btnSupprimerSoin.UseVisualStyleBackColor = false;
            this.btnSupprimerSoin.Click += new System.EventHandler(this.btnSupprimerSoin_Click);
            // 
            // btnAjouterSoin
            // 
            this.btnAjouterSoin.Location = new System.Drawing.Point(134, 397);
            this.btnAjouterSoin.Name = "btnAjouterSoin";
            this.btnAjouterSoin.Size = new System.Drawing.Size(92, 36);
            this.btnAjouterSoin.TabIndex = 10;
            this.btnAjouterSoin.Text = "Ajouter";
            this.btnAjouterSoin.UseVisualStyleBackColor = true;
            this.btnAjouterSoin.Click += new System.EventHandler(this.btnAjouterSoin_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFermer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFermer.Location = new System.Drawing.Point(490, 575);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(97, 32);
            this.btnFermer.TabIndex = 13;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnActualiser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualiser.Location = new System.Drawing.Point(612, 575);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(97, 32);
            this.btnActualiser.TabIndex = 14;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistant_soinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = this.assistantTableAdapter;
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
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // assistant_soinTableAdapter
            // 
            this.assistant_soinTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableAssistantSoinTableAdapter
            // 
            this.dataTableAssistantSoinTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Menu;
            this.splitContainer1.Location = new System.Drawing.Point(24, 104);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.dgvAssistants);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnAjouterAssistant);
            this.splitContainer1.Panel1.Controls.Add(this.btnModifierAssistant);
            this.splitContainer1.Panel1.Controls.Add(this.btnSupAssistant);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.dgvSoinsOfferts);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnAjouterSoin);
            this.splitContainer1.Panel2.Controls.Add(this.btnSupprimerSoin);
            this.splitContainer1.Size = new System.Drawing.Size(1014, 456);
            this.splitContainer1.SplitterDistance = 572;
            this.splitContainer1.TabIndex = 15;
            // 
            // FrmGestionAssistants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 629);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionAssistants";
            this.Text = "Gestion Assistants";
            this.Load += new System.EventHandler(this.FrmGestionAssistants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistant_soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAssistantSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoinsOfferts)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.assistantTableAdapter assistantTableAdapter;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvAssistants;
        private System.Windows.Forms.BindingSource assistant_soinBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.assistant_soinTableAdapter assistant_soinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource dataTableAssistantSoinBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.DataTableAssistantSoinTableAdapter dataTableAssistantSoinTableAdapter;
        private System.Windows.Forms.DataGridView dgvSoinsOfferts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouterAssistant;
        private System.Windows.Forms.Button btnModifierAssistant;
        private System.Windows.Forms.Button btnSupAssistant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSupprimerSoin;
        private System.Windows.Forms.Button btnAjouterSoin;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}