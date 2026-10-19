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
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.utilisateurTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
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
            this.typeUtilisateurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typeUtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeUtilisateurTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.typeUtilisateurTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tableAdapterManager.ListeChambresRapportTableAdapter = null;
            this.tableAdapterManager.nosEtNomsAssistantsTableAdapter = null;
            this.tableAdapterManager.planif_soinTableAdapter = null;
            this.tableAdapterManager.reservationTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.type_chambreTableAdapter = null;
            this.tableAdapterManager.type_soinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = this.utilisateurTableAdapter;
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
            this.dgvUtilisateurs.Location = new System.Drawing.Point(20, 52);
            this.dgvUtilisateurs.MultiSelect = false;
            this.dgvUtilisateurs.Name = "dgvUtilisateurs";
            this.dgvUtilisateurs.ReadOnly = true;
            this.dgvUtilisateurs.RowHeadersWidth = 51;
            this.dgvUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtilisateurs.Size = new System.Drawing.Size(692, 272);
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
            this.btnAjouter.Location = new System.Drawing.Point(486, 34);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(102, 31);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(610, 34);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(101, 31);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(610, 15);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(102, 31);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Location = new System.Drawing.Point(28, 44);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.txtNomUtilisateur.TabIndex = 6;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(143, 44);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(100, 20);
            this.txtMdp.TabIndex = 7;
            // 
            // cmbTypeUtilisateur
            // 
            this.cmbTypeUtilisateur.DataSource = this.typeUtilisateurBindingSource1;
            this.cmbTypeUtilisateur.DisplayMember = "identification";
            this.cmbTypeUtilisateur.FormattingEnabled = true;
            this.cmbTypeUtilisateur.Location = new System.Drawing.Point(268, 44);
            this.cmbTypeUtilisateur.Name = "cmbTypeUtilisateur";
            this.cmbTypeUtilisateur.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeUtilisateur.TabIndex = 8;
            this.cmbTypeUtilisateur.ValueMember = "id_typeUtil";
            // 
            // typeUtilisateurBindingSource1
            // 
            this.typeUtilisateurBindingSource1.DataMember = "typeUtilisateur";
            this.typeUtilisateurBindingSource1.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // typeUtilisateurBindingSource
            // 
            this.typeUtilisateurBindingSource.DataMember = "typeUtilisateur";
            this.typeUtilisateurBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type d\'utilisateur :";
            // 
            // typeUtilisateurTableAdapter
            // 
            this.typeUtilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(348, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(280, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gestion des utilisateurs :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbTypeUtilisateur);
            this.panel1.Controls.Add(this.txtMdp);
            this.panel1.Controls.Add(this.txtNomUtilisateur);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Location = new System.Drawing.Point(30, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 104);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btnSupprimer);
            this.panel2.Controls.Add(this.dgvUtilisateurs);
            this.panel2.Location = new System.Drawing.Point(30, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 339);
            this.panel2.TabIndex = 15;
            // 
            // frmGestionUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Name = "frmGestionUtilisateurs";
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.frmGestionUtilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

