namespace Projet1SNG
{
    partial class frmRapportReservationsChambres
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblChambre;
        private System.Windows.Forms.ComboBox cboChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomComplet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNbPersonnes;
        private System.Windows.Forms.Label lblEtat;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnFermer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblChambre = new System.Windows.Forms.Label();
            this.cboChambre = new System.Windows.Forms.ComboBox();
            this.listeChambresRapportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.lblEtat = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.listeChambresRapportTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.ListeChambresRapportTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.historiqueReservationsChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historiqueReservationsChambreTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.HistoriqueReservationsChambreTableAdapter();
            this.dgvRapportReservation = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listeChambresRapportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiqueReservationsChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapportReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(35, 43);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(464, 29);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Rapport des réservations de chambres";
            // 
            // lblChambre
            // 
            this.lblChambre.AutoSize = true;
            this.lblChambre.Location = new System.Drawing.Point(36, 100);
            this.lblChambre.Name = "lblChambre";
            this.lblChambre.Size = new System.Drawing.Size(68, 16);
            this.lblChambre.TabIndex = 1;
            this.lblChambre.Text = "Chambre :";
            // 
            // cboChambre
            // 
            this.cboChambre.DataSource = this.listeChambresRapportBindingSource;
            this.cboChambre.DisplayMember = "chambreAffichage";
            this.cboChambre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChambre.FormattingEnabled = true;
            this.cboChambre.Location = new System.Drawing.Point(117, 97);
            this.cboChambre.Name = "cboChambre";
            this.cboChambre.Size = new System.Drawing.Size(385, 24);
            this.cboChambre.TabIndex = 0;
            this.cboChambre.ValueMember = "id_chambre";
            this.cboChambre.SelectedIndexChanged += new System.EventHandler(this.cboChambre_SelectedIndexChanged);
            this.cboChambre.SelectionChangeCommitted += new System.EventHandler(this.cboChambre_SelectionChangeCommitted);
            // 
            // listeChambresRapportBindingSource
            // 
            this.listeChambresRapportBindingSource.DataMember = "ListeChambresRapport";
            this.listeChambresRapportBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblEtat
            // 
            this.lblEtat.AutoSize = true;
            this.lblEtat.Location = new System.Drawing.Point(36, 139);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(0, 16);
            this.lblEtat.TabIndex = 2;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualiser.Location = new System.Drawing.Point(801, 92);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(112, 32);
            this.btnActualiser.TabIndex = 4;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFermer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFermer.Location = new System.Drawing.Point(807, 455);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(106, 32);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // listeChambresRapportTableAdapter
            // 
            this.listeChambresRapportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistant_soinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.ListeChambresRapportTableAdapter = this.listeChambresRapportTableAdapter;
            this.tableAdapterManager.planif_soinTableAdapter = null;
            this.tableAdapterManager.reservationTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.type_chambreTableAdapter = null;
            this.tableAdapterManager.type_soinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // historiqueReservationsChambreBindingSource
            // 
            this.historiqueReservationsChambreBindingSource.DataMember = "HistoriqueReservationsChambre";
            this.historiqueReservationsChambreBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // historiqueReservationsChambreTableAdapter
            // 
            this.historiqueReservationsChambreTableAdapter.ClearBeforeFill = true;
            // 
            // dgvRapportReservation
            // 
            this.dgvRapportReservation.AllowUserToAddRows = false;
            this.dgvRapportReservation.AllowUserToDeleteRows = false;
            this.dgvRapportReservation.AutoGenerateColumns = false;
            this.dgvRapportReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRapportReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapportReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvRapportReservation.DataSource = this.historiqueReservationsChambreBindingSource;
            this.dgvRapportReservation.Location = new System.Drawing.Point(40, 164);
            this.dgvRapportReservation.Name = "dgvRapportReservation";
            this.dgvRapportReservation.ReadOnly = true;
            this.dgvRapportReservation.RowHeadersWidth = 51;
            this.dgvRapportReservation.RowTemplate.Height = 24;
            this.dgvRapportReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRapportReservation.Size = new System.Drawing.Size(873, 268);
            this.dgvRapportReservation.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nomComplet";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom Complet";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dateArrivee";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date d\'arrivée";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dateDepart";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date de départ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nbPersonnes";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre de personnes";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // frmRapportReservationsChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 535);
            this.Controls.Add(this.dgvRapportReservation);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblChambre);
            this.Controls.Add(this.cboChambre);
            this.Controls.Add(this.lblEtat);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnFermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(800, 430);
            this.Name = "frmRapportReservationsChambres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historique des réservations par chambre";
            this.Load += new System.EventHandler(this.frmRapportReservationsChambres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeChambresRapportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiqueReservationsChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapportReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private System.Windows.Forms.BindingSource listeChambresRapportBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.ListeChambresRapportTableAdapter listeChambresRapportTableAdapter;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource historiqueReservationsChambreBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.HistoriqueReservationsChambreTableAdapter historiqueReservationsChambreTableAdapter;
        private System.Windows.Forms.DataGridView dgvRapportReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
