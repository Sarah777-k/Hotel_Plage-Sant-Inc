namespace Projet1SNG
{
    partial class frmPlanifSoins
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
            this.btnPlanifier = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.planif_soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPersonne = new System.Windows.Forms.ComboBox();
            this.nosEtNomsPersonnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSoin = new System.Windows.Forms.ComboBox();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAssistant = new System.Windows.Forms.ComboBox();
            this.assistantsParSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHeure = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.planif_soinTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.planif_soinTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.nosEtNomsPersonnesTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.nosEtNomsPersonnesTableAdapter();
            this.assistantsParSoinTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.assistantsParSoinTableAdapter();
            this.soinTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.soinTableAdapter();
            this.dgvPlanifSoins = new System.Windows.Forms.DataGridView();
            this.nosEtNomsAssistantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtNomsAssistantsTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.nosEtNomsAssistantsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.planif_soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsPersonnesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantsParSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanifSoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsAssistantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlanifier
            // 
            this.btnPlanifier.Location = new System.Drawing.Point(592, 119);
            this.btnPlanifier.Name = "btnPlanifier";
            this.btnPlanifier.Size = new System.Drawing.Size(75, 23);
            this.btnPlanifier.TabIndex = 0;
            this.btnPlanifier.Text = "Planifier";
            this.btnPlanifier.UseVisualStyleBackColor = true;
            this.btnPlanifier.Click += new System.EventHandler(this.btnPlanifier_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(640, 24);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(728, 507);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(272, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Planification des soins";
            // 
            // planif_soinBindingSource
            // 
            this.planif_soinBindingSource.DataMember = "planif_soin";
            this.planif_soinBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Client ou invité: ";
            // 
            // cmbPersonne
            // 
            this.cmbPersonne.DataSource = this.nosEtNomsPersonnesBindingSource;
            this.cmbPersonne.DisplayMember = "nomComplet";
            this.cmbPersonne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonne.FormattingEnabled = true;
            this.cmbPersonne.Location = new System.Drawing.Point(83, 119);
            this.cmbPersonne.Name = "cmbPersonne";
            this.cmbPersonne.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonne.TabIndex = 7;
            this.cmbPersonne.ValueMember = "id_personne";
            // 
            // nosEtNomsPersonnesBindingSource
            // 
            this.nosEtNomsPersonnesBindingSource.DataMember = "nosEtNomsPersonnes";
            this.nosEtNomsPersonnesBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // cmbSoin
            // 
            this.cmbSoin.DataSource = this.soinBindingSource;
            this.cmbSoin.DisplayMember = "description";
            this.cmbSoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoin.FormattingEnabled = true;
            this.cmbSoin.Location = new System.Drawing.Point(421, 119);
            this.cmbSoin.Name = "cmbSoin";
            this.cmbSoin.Size = new System.Drawing.Size(121, 21);
            this.cmbSoin.TabIndex = 9;
            this.cmbSoin.ValueMember = "id_soin";
            this.cmbSoin.SelectedIndexChanged += new System.EventHandler(this.cmbSoin_SelectedIndexChanged);
            // 
            // soinBindingSource
            // 
            this.soinBindingSource.DataMember = "soin";
            this.soinBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soin :";
            // 
            // cmbAssistant
            // 
            this.cmbAssistant.DataSource = this.assistantsParSoinBindingSource;
            this.cmbAssistant.DisplayMember = "nomAssistant";
            this.cmbAssistant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssistant.FormattingEnabled = true;
            this.cmbAssistant.Location = new System.Drawing.Point(260, 119);
            this.cmbAssistant.Name = "cmbAssistant";
            this.cmbAssistant.Size = new System.Drawing.Size(121, 21);
            this.cmbAssistant.TabIndex = 11;
            this.cmbAssistant.ValueMember = "id_assistant";
            // 
            // assistantsParSoinBindingSource
            // 
            this.assistantsParSoinBindingSource.DataMember = "assistantsParSoin";
            this.assistantsParSoinBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Assistant:";
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(83, 174);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 20);
            this.dtpDate.TabIndex = 12;
            // 
            // dtpHeure
            // 
            this.dtpHeure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeure.Location = new System.Drawing.Point(260, 174);
            this.dtpHeure.Name = "dtpHeure";
            this.dtpHeure.ShowUpDown = true;
            this.dtpHeure.Size = new System.Drawing.Size(121, 20);
            this.dtpHeure.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Heure:";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(693, 202);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // planif_soinTableAdapter
            // 
            this.planif_soinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistant_soinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.nosEtNomsAssistantsTableAdapter = null;
            this.tableAdapterManager.planif_soinTableAdapter = this.planif_soinTableAdapter;
            this.tableAdapterManager.reservationTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.type_chambreTableAdapter = null;
            this.tableAdapterManager.type_soinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // nosEtNomsPersonnesTableAdapter
            // 
            this.nosEtNomsPersonnesTableAdapter.ClearBeforeFill = true;
            // 
            // assistantsParSoinTableAdapter
            // 
            this.assistantsParSoinTableAdapter.ClearBeforeFill = true;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPlanifSoins
            // 
            this.dgvPlanifSoins.AllowUserToAddRows = false;
            this.dgvPlanifSoins.AllowUserToDeleteRows = false;
            this.dgvPlanifSoins.AutoGenerateColumns = false;
            this.dgvPlanifSoins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanifSoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanifSoins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.dgvPlanifSoins.DataSource = this.planif_soinBindingSource;
            this.dgvPlanifSoins.Location = new System.Drawing.Point(31, 231);
            this.dgvPlanifSoins.MultiSelect = false;
            this.dgvPlanifSoins.Name = "dgvPlanifSoins";
            this.dgvPlanifSoins.ReadOnly = true;
            this.dgvPlanifSoins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanifSoins.Size = new System.Drawing.Size(747, 220);
            this.dgvPlanifSoins.TabIndex = 5;
            // 
            // nosEtNomsAssistantsBindingSource
            // 
            this.nosEtNomsAssistantsBindingSource.DataMember = "nosEtNomsAssistants";
            this.nosEtNomsAssistantsBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // nosEtNomsAssistantsTableAdapter
            // 
            this.nosEtNomsAssistantsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_personne";
            this.dataGridViewTextBoxColumn1.DataSource = this.nosEtNomsPersonnesBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "nomComplet";
            this.dataGridViewTextBoxColumn1.HeaderText = "Client ou invité";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "id_personne";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_assistant";
            this.dataGridViewTextBoxColumn2.DataSource = this.nosEtNomsAssistantsBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "nomAssistant";
            this.dataGridViewTextBoxColumn2.HeaderText = "Assistant";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id_assistant";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dateHeure";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date et heure";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_soin";
            this.dataGridViewTextBoxColumn4.DataSource = this.soinBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Soin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "id_soin";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "fait";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Effectué?";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(728, 24);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmPlanifSoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 542);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHeure);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbAssistant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPersonne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPlanifSoins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnPlanifier);
            this.Name = "frmPlanifSoins";
            this.Text = "Planification des soins";
            this.Load += new System.EventHandler(this.frmPlanifSoins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planif_soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsPersonnesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantsParSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanifSoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsAssistantsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlanifier;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label1;
        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private System.Windows.Forms.BindingSource planif_soinBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.planif_soinTableAdapter planif_soinTableAdapter;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPersonne;
        private System.Windows.Forms.ComboBox cmbSoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAssistant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHeure;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.BindingSource nosEtNomsPersonnesBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.nosEtNomsPersonnesTableAdapter nosEtNomsPersonnesTableAdapter;
        private System.Windows.Forms.BindingSource assistantsParSoinBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.assistantsParSoinTableAdapter assistantsParSoinTableAdapter;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.soinTableAdapter soinTableAdapter;
        private System.Windows.Forms.DataGridView dgvPlanifSoins;
        private System.Windows.Forms.BindingSource nosEtNomsAssistantsBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.nosEtNomsAssistantsTableAdapter nosEtNomsAssistantsTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnAnnuler;
    }
}