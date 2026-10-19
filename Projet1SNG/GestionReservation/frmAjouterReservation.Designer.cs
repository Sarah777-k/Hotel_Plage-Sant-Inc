namespace Projet1SNG.GestionReservation
{
    partial class frmAjouterReservation
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
            System.Windows.Forms.Label id_clientLabel;
            System.Windows.Forms.Label id_reservationLabel;
            System.Windows.Forms.Label nbPersonnesLabel;
            System.Windows.Forms.Label dateArriveeLabel;
            System.Windows.Forms.Label dateDepartLabel;
            System.Windows.Forms.Label id_chambreLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClient = new System.Windows.Forms.ComboBox();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.infoClientReservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.infoClientReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtReservation = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.dateArrivee = new System.Windows.Forms.DateTimePicker();
            this.dateDepart = new System.Windows.Forms.DateTimePicker();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.nbPersonne = new System.Windows.Forms.NumericUpDown();
            this.dgvReservationChambre = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationTypeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typechambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.reservationTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.chambreTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.chambreTableAdapter();
            this.type_chambreTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.type_chambreTableAdapter();
            this.reservationTypeChambreTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.ReservationTypeChambreTableAdapter();
            this.infoClientReservationTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.InfoClientReservationTableAdapter();
            id_clientLabel = new System.Windows.Forms.Label();
            id_reservationLabel = new System.Windows.Forms.Label();
            nbPersonnesLabel = new System.Windows.Forms.Label();
            dateArriveeLabel = new System.Windows.Forms.Label();
            dateDepartLabel = new System.Windows.Forms.Label();
            id_chambreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoClientReservationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoClientReservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPersonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationChambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationTypeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typechambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_clientLabel
            // 
            id_clientLabel.AutoSize = true;
            id_clientLabel.Location = new System.Drawing.Point(42, 408);
            id_clientLabel.Name = "id_clientLabel";
            id_clientLabel.Size = new System.Drawing.Size(43, 16);
            id_clientLabel.TabIndex = 4;
            id_clientLabel.Text = "Client:";
            // 
            // id_reservationLabel
            // 
            id_reservationLabel.AutoSize = true;
            id_reservationLabel.Location = new System.Drawing.Point(42, 109);
            id_reservationLabel.Name = "id_reservationLabel";
            id_reservationLabel.Size = new System.Drawing.Size(93, 16);
            id_reservationLabel.TabIndex = 6;
            id_reservationLabel.Text = "ID réservation:";
            // 
            // nbPersonnesLabel
            // 
            nbPersonnesLabel.AutoSize = true;
            nbPersonnesLabel.Location = new System.Drawing.Point(557, 406);
            nbPersonnesLabel.Name = "nbPersonnesLabel";
            nbPersonnesLabel.Size = new System.Drawing.Size(96, 16);
            nbPersonnesLabel.TabIndex = 8;
            nbPersonnesLabel.Text = "Nb Personnes:";
            // 
            // dateArriveeLabel
            // 
            dateArriveeLabel.AutoSize = true;
            dateArriveeLabel.Location = new System.Drawing.Point(557, 455);
            dateArriveeLabel.Name = "dateArriveeLabel";
            dateArriveeLabel.Size = new System.Drawing.Size(95, 16);
            dateArriveeLabel.TabIndex = 12;
            dateArriveeLabel.Text = "Date d\'arrivée:";
            // 
            // dateDepartLabel
            // 
            dateDepartLabel.AutoSize = true;
            dateDepartLabel.Location = new System.Drawing.Point(43, 461);
            dateDepartLabel.Name = "dateDepartLabel";
            dateDepartLabel.Size = new System.Drawing.Size(100, 16);
            dateDepartLabel.TabIndex = 14;
            dateDepartLabel.Text = "Date de départ:";
            // 
            // id_chambreLabel
            // 
            id_chambreLabel.AutoSize = true;
            id_chambreLabel.Location = new System.Drawing.Point(43, 150);
            id_chambreLabel.Name = "id_chambreLabel";
            id_chambreLabel.Size = new System.Drawing.Size(65, 16);
            id_chambreLabel.TabIndex = 2;
            id_chambreLabel.Text = "Chambre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter une réservation de chambre";
            // 
            // cboClient
            // 
            this.cboClient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reservationBindingSource, "id_client", true));
            this.cboClient.DataSource = this.infoClientReservationBindingSource1;
            this.cboClient.DisplayMember = "Nom Complet";
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(151, 405);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(202, 24);
            this.cboClient.TabIndex = 5;
            this.cboClient.ValueMember = "id_client";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "reservation";
            this.reservationBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoClientReservationBindingSource1
            // 
            this.infoClientReservationBindingSource1.DataMember = "InfoClientReservation";
            this.infoClientReservationBindingSource1.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // infoClientReservationBindingSource
            // 
            this.infoClientReservationBindingSource.DataMember = "InfoClientReservation";
            this.infoClientReservationBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // txtReservation
            // 
            this.txtReservation.Location = new System.Drawing.Point(149, 106);
            this.txtReservation.Name = "txtReservation";
            this.txtReservation.ReadOnly = true;
            this.txtReservation.Size = new System.Drawing.Size(72, 22);
            this.txtReservation.TabIndex = 7;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(501, 516);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(77, 32);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFermer.Location = new System.Drawing.Point(385, 514);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(87, 34);
            this.btnFermer.TabIndex = 11;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // dateArrivee
            // 
            this.dateArrivee.Location = new System.Drawing.Point(665, 455);
            this.dateArrivee.Name = "dateArrivee";
            this.dateArrivee.Size = new System.Drawing.Size(200, 22);
            this.dateArrivee.TabIndex = 13;
            // 
            // dateDepart
            // 
            this.dateDepart.Location = new System.Drawing.Point(151, 456);
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.Size = new System.Drawing.Size(200, 22);
            this.dateDepart.TabIndex = 15;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // nbPersonne
            // 
            this.nbPersonne.Location = new System.Drawing.Point(665, 406);
            this.nbPersonne.Name = "nbPersonne";
            this.nbPersonne.Size = new System.Drawing.Size(200, 22);
            this.nbPersonne.TabIndex = 16;
            // 
            // dgvReservationChambre
            // 
            this.dgvReservationChambre.AllowUserToAddRows = false;
            this.dgvReservationChambre.AllowUserToDeleteRows = false;
            this.dgvReservationChambre.AutoGenerateColumns = false;
            this.dgvReservationChambre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReservationChambre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservationChambre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservationChambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationChambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvReservationChambre.DataSource = this.reservationTypeChambreBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservationChambre.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservationChambre.Location = new System.Drawing.Point(149, 150);
            this.dgvReservationChambre.Name = "dgvReservationChambre";
            this.dgvReservationChambre.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservationChambre.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservationChambre.RowHeadersWidth = 21;
            this.dgvReservationChambre.RowTemplate.Height = 24;
            this.dgvReservationChambre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservationChambre.Size = new System.Drawing.Size(716, 204);
            this.dgvReservationChambre.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_chambre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id chambre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "emplacement";
            this.dataGridViewTextBoxColumn2.HeaderText = "Emplacement";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 119;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "decoration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Décoration";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 102;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prix saison haut";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prix saison haut";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 119;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Prix saison Moyen";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prix saison Moyen";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 133;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Prix saison bas";
            this.dataGridViewTextBoxColumn6.HeaderText = "Prix saison bas";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 117;
            // 
            // reservationTypeChambreBindingSource
            // 
            this.reservationTypeChambreBindingSource.DataMember = "ReservationTypeChambre";
            this.reservationTypeChambreBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // typechambreBindingSource
            // 
            this.typechambreBindingSource.DataMember = "type_chambre";
            this.typechambreBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "chambre";
            this.chambreBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.reservationTableAdapter = this.reservationTableAdapter;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.type_chambreTableAdapter = null;
            this.tableAdapterManager.type_soinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // type_chambreTableAdapter
            // 
            this.type_chambreTableAdapter.ClearBeforeFill = true;
            // 
            // reservationTypeChambreTableAdapter
            // 
            this.reservationTypeChambreTableAdapter.ClearBeforeFill = true;
            // 
            // infoClientReservationTableAdapter
            // 
            this.infoClientReservationTableAdapter.ClearBeforeFill = true;
            // 
            // frmAjouterReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 565);
            this.Controls.Add(this.dgvReservationChambre);
            this.Controls.Add(this.nbPersonne);
            this.Controls.Add(dateDepartLabel);
            this.Controls.Add(this.dateDepart);
            this.Controls.Add(dateArriveeLabel);
            this.Controls.Add(this.dateArrivee);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(nbPersonnesLabel);
            this.Controls.Add(id_reservationLabel);
            this.Controls.Add(this.txtReservation);
            this.Controls.Add(id_clientLabel);
            this.Controls.Add(this.cboClient);
            this.Controls.Add(id_chambreLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAjouterReservation";
            this.Text = "Ajouter Réservation";
            this.Load += new System.EventHandler(this.frmAjouterReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoClientReservationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoClientReservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPersonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationChambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationTypeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typechambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.reservationTableAdapter reservationTableAdapter;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboClient;
        private System.Windows.Forms.TextBox txtReservation;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DateTimePicker dateArrivee;
        private System.Windows.Forms.DateTimePicker dateDepart;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.NumericUpDown nbPersonne;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.chambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.BindingSource typechambreBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.type_chambreTableAdapter type_chambreTableAdapter;
        private System.Windows.Forms.BindingSource reservationTypeChambreBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.ReservationTypeChambreTableAdapter reservationTypeChambreTableAdapter;
        private System.Windows.Forms.DataGridView dgvReservationChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource infoClientReservationBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.InfoClientReservationTableAdapter infoClientReservationTableAdapter;
        private System.Windows.Forms.BindingSource infoClientReservationBindingSource1;
    }
}