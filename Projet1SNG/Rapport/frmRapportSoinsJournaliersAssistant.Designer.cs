namespace Projet1SNG.Rapport
{
    partial class frmRapportSoinsJournaliersAssistant
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.assistantSoinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinsTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.AssistantSoinsTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.assistantSoinsComboBox = new System.Windows.Forms.ComboBox();
            this.soinsRecuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinsRecuTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.SoinsRecuTableAdapter();
            this.soinsRecuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinsRecuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinsRecuDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(24, 28);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(417, 24);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Rapport des soins journaliers des assistants";
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFermer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFermer.Location = new System.Drawing.Point(693, 458);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(80, 26);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assistantSoinsBindingSource
            // 
            this.assistantSoinsBindingSource.DataMember = "AssistantSoins";
            this.assistantSoinsBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // assistantSoinsTableAdapter
            // 
            this.assistantSoinsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistant_soinTableAdapter = null;
            this.tableAdapterManager.AssistantSoinsTableAdapter = this.assistantSoinsTableAdapter;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.ListeChambresRapportTableAdapter = null;
            this.tableAdapterManager.nosEtNomsAssistantsTableAdapter = null;
            this.tableAdapterManager.planif_soinTableAdapter = null;
            this.tableAdapterManager.reservationTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.type_chambreTableAdapter = null;
            this.tableAdapterManager.type_soinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // assistantSoinsComboBox
            // 
            this.assistantSoinsComboBox.DataSource = this.assistantSoinsBindingSource;
            this.assistantSoinsComboBox.DisplayMember = "nom";
            this.assistantSoinsComboBox.FormattingEnabled = true;
            this.assistantSoinsComboBox.Location = new System.Drawing.Point(109, 108);
            this.assistantSoinsComboBox.Name = "assistantSoinsComboBox";
            this.assistantSoinsComboBox.Size = new System.Drawing.Size(300, 21);
            this.assistantSoinsComboBox.TabIndex = 7;
            this.assistantSoinsComboBox.ValueMember = "id_assistant";
            // 
            // soinsRecuBindingSource
            // 
            this.soinsRecuBindingSource.DataMember = "AssistantSoins_SoinsRecu";
            this.soinsRecuBindingSource.DataSource = this.assistantSoinsBindingSource;
            // 
            // soinsRecuTableAdapter
            // 
            this.soinsRecuTableAdapter.ClearBeforeFill = true;
            // 
            // soinsRecuDataGridView
            // 
            this.soinsRecuDataGridView.AutoGenerateColumns = false;
            this.soinsRecuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.soinsRecuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soinsRecuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.soinsRecuDataGridView.DataSource = this.soinsRecuBindingSource;
            this.soinsRecuDataGridView.Location = new System.Drawing.Point(52, 31);
            this.soinsRecuDataGridView.Name = "soinsRecuDataGridView";
            this.soinsRecuDataGridView.Size = new System.Drawing.Size(646, 220);
            this.soinsRecuDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn1.HeaderText = "description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dateHeure";
            this.dataGridViewTextBoxColumn2.HeaderText = "date et heure";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomComplet";
            this.dataGridViewTextBoxColumn3.HeaderText = "nom du client";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Assistant:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Location = new System.Drawing.Point(12, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 71);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.soinsRecuDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 278);
            this.panel1.TabIndex = 10;
            // 
            // frmRapportSoinsJournaliersAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assistantSoinsComboBox);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRapportSoinsJournaliersAssistant";
            this.Text = "frmRapportSoinsJournaliersAssistant";
            this.Load += new System.EventHandler(this.frmRapportSoinsJournaliersAssistant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinsRecuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinsRecuDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnFermer;
        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private System.Windows.Forms.BindingSource assistantSoinsBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.AssistantSoinsTableAdapter assistantSoinsTableAdapter;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox assistantSoinsComboBox;
        private System.Windows.Forms.BindingSource soinsRecuBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.SoinsRecuTableAdapter soinsRecuTableAdapter;
        private System.Windows.Forms.DataGridView soinsRecuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}