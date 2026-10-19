namespace Projet1SNG.Soins
{
    partial class frmGestionSoins
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.soinTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.dgvSoins = new System.Windows.Forms.DataGridView();
            this.typesoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTypeSoin = new System.Windows.Forms.ComboBox();
            this.type_soinTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.type_soinTableAdapter();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.dgvIdSoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDuree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTypeSoin = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(849, 114);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 28);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(849, 33);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soinBindingSource
            // 
            this.soinBindingSource.DataMember = "soin";
            this.soinBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.soinTableAdapter = this.soinTableAdapter;
            this.tableAdapterManager.type_chambreTableAdapter = null;
            this.tableAdapterManager.type_soinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // dgvSoins
            // 
            this.dgvSoins.AllowUserToAddRows = false;
            this.dgvSoins.AllowUserToDeleteRows = false;
            this.dgvSoins.AutoGenerateColumns = false;
            this.dgvSoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdSoin,
            this.dgvDescription,
            this.dgvDuree,
            this.dgvTypeSoin,
            this.dgvPrix});
            this.dgvSoins.DataSource = this.soinBindingSource;
            this.dgvSoins.Location = new System.Drawing.Point(41, 88);
            this.dgvSoins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSoins.MultiSelect = false;
            this.dgvSoins.Name = "dgvSoins";
            this.dgvSoins.RowHeadersWidth = 51;
            this.dgvSoins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoins.Size = new System.Drawing.Size(908, 321);
            this.dgvSoins.TabIndex = 4;
            this.dgvSoins.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvSoins_RowValidating);
            // 
            // typesoinBindingSource
            // 
            this.typesoinBindingSource.DataMember = "type_soin";
            this.typesoinBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(41, 84);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(188, 22);
            this.tbDescription.TabIndex = 5;
            // 
            // tbDuree
            // 
            this.tbDuree.Location = new System.Drawing.Point(41, 138);
            this.tbDuree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.ReadOnly = true;
            this.tbDuree.Size = new System.Drawing.Size(188, 22);
            this.tbDuree.TabIndex = 6;
            this.tbDuree.Text = "60";
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(322, 147);
            this.tbPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(189, 22);
            this.tbPrix.TabIndex = 8;
            this.tbPrix.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrix_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Durée :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Identifiant du type de soin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Prix : ";
            // 
            // cmbTypeSoin
            // 
            this.cmbTypeSoin.DataSource = this.typesoinBindingSource;
            this.cmbTypeSoin.DisplayMember = "description";
            this.cmbTypeSoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeSoin.FormattingEnabled = true;
            this.cmbTypeSoin.Location = new System.Drawing.Point(322, 89);
            this.cmbTypeSoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTypeSoin.Name = "cmbTypeSoin";
            this.cmbTypeSoin.Size = new System.Drawing.Size(189, 24);
            this.cmbTypeSoin.TabIndex = 13;
            this.cmbTypeSoin.ValueMember = "id_typeSoin";
            // 
            // type_soinTableAdapter
            // 
            this.type_soinTableAdapter.ClearBeforeFill = true;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(605, 682);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(125, 28);
            this.btnEnregistrer.TabIndex = 14;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(480, 684);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ajout de soins: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Modification et suppression de soins: ";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitter.Location = new System.Drawing.Point(350, 684);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 28);
            this.btnQuitter.TabIndex = 18;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // dgvIdSoin
            // 
            this.dgvIdSoin.DataPropertyName = "id_soin";
            this.dgvIdSoin.HeaderText = "Numéro du soin";
            this.dgvIdSoin.MinimumWidth = 6;
            this.dgvIdSoin.Name = "dgvIdSoin";
            this.dgvIdSoin.ReadOnly = true;
            this.dgvIdSoin.Width = 125;
            // 
            // dgvDescription
            // 
            this.dgvDescription.DataPropertyName = "description";
            this.dgvDescription.HeaderText = "Description";
            this.dgvDescription.MinimumWidth = 6;
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.Width = 125;
            // 
            // dgvDuree
            // 
            this.dgvDuree.DataPropertyName = "duree";
            this.dgvDuree.HeaderText = "Durée";
            this.dgvDuree.MinimumWidth = 6;
            this.dgvDuree.Name = "dgvDuree";
            this.dgvDuree.ReadOnly = true;
            this.dgvDuree.Width = 125;
            // 
            // dgvTypeSoin
            // 
            this.dgvTypeSoin.DataPropertyName = "id_typeSoin";
            this.dgvTypeSoin.DataSource = this.typesoinBindingSource;
            this.dgvTypeSoin.DisplayMember = "description";
            this.dgvTypeSoin.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvTypeSoin.HeaderText = "Type de soin";
            this.dgvTypeSoin.MinimumWidth = 6;
            this.dgvTypeSoin.Name = "dgvTypeSoin";
            this.dgvTypeSoin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTypeSoin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvTypeSoin.ValueMember = "id_typeSoin";
            this.dgvTypeSoin.Width = 125;
            // 
            // dgvPrix
            // 
            this.dgvPrix.DataPropertyName = "prix";
            this.dgvPrix.HeaderText = "Prix";
            this.dgvPrix.MinimumWidth = 6;
            this.dgvPrix.Name = "dgvPrix";
            this.dgvPrix.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Gestion des soins";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 63);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.tbPrix);
            this.splitContainer1.Panel1.Controls.Add(this.tbDescription);
            this.splitContainer1.Panel1.Controls.Add(this.tbDuree);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btnAjouter);
            this.splitContainer1.Panel1.Controls.Add(this.cmbTypeSoin);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnSupprimer);
            this.splitContainer1.Panel2.Controls.Add(this.dgvSoins);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(989, 614);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 20;
            // 
            // frmGestionSoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 725);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGestionSoins";
            this.Text = "Gestion des soins";
            this.Load += new System.EventHandler(this.frmGestionSoins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
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

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.soinTableAdapter soinTableAdapter;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvSoins;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTypeSoin;
        private System.Windows.Forms.BindingSource typesoinBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.type_soinTableAdapter type_soinTableAdapter;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdSoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDuree;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvTypeSoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}