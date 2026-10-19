namespace Projet1SNG.Rapport
{
    partial class frmRapportSoinsOffertsClientsInvites
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.cmbPersonne = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.soinsOffertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinsOffertsTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.soinsOffertsTableAdapter();
            this.dggvSoinsOfferts = new System.Windows.Forms.DataGridView();
            this.nosEtNomsPersonnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtNomsPersonnesTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.nosEtNomsPersonnesTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinsOffertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dggvSoinsOfferts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsPersonnesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rapports des soins offerts aux client et aux invités";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnQuitter.Location = new System.Drawing.Point(354, 495);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Fermer";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // cmbPersonne
            // 
            this.cmbPersonne.DataSource = this.nosEtNomsPersonnesBindingSource;
            this.cmbPersonne.DisplayMember = "nomComplet";
            this.cmbPersonne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonne.FormattingEnabled = true;
            this.cmbPersonne.Location = new System.Drawing.Point(40, 33);
            this.cmbPersonne.Name = "cmbPersonne";
            this.cmbPersonne.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonne.TabIndex = 0;
            this.cmbPersonne.ValueMember = "id_personne";
            this.cmbPersonne.SelectedIndexChanged += new System.EventHandler(this.cmbPersonne_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.dggvSoinsOfferts);
            this.panel1.Location = new System.Drawing.Point(62, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 324);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total: ";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(61, 34);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.tbTotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(436, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 71);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbPersonne);
            this.panel3.Location = new System.Drawing.Point(117, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 71);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client ou invité: ";
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.type_chambreTableAdapter = null;
            this.tableAdapterManager.type_soinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // soinsOffertsBindingSource
            // 
            this.soinsOffertsBindingSource.DataMember = "soinsOfferts";
            this.soinsOffertsBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // soinsOffertsTableAdapter
            // 
            this.soinsOffertsTableAdapter.ClearBeforeFill = true;
            // 
            // dggvSoinsOfferts
            // 
            this.dggvSoinsOfferts.AllowUserToAddRows = false;
            this.dggvSoinsOfferts.AllowUserToDeleteRows = false;
            this.dggvSoinsOfferts.AutoGenerateColumns = false;
            this.dggvSoinsOfferts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dggvSoinsOfferts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dggvSoinsOfferts.DataSource = this.soinsOffertsBindingSource;
            this.dggvSoinsOfferts.Location = new System.Drawing.Point(69, 66);
            this.dggvSoinsOfferts.Name = "dggvSoinsOfferts";
            this.dggvSoinsOfferts.ReadOnly = true;
            this.dggvSoinsOfferts.Size = new System.Drawing.Size(523, 236);
            this.dggvSoinsOfferts.TabIndex = 0;
            // 
            // nosEtNomsPersonnesBindingSource
            // 
            this.nosEtNomsPersonnesBindingSource.DataMember = "nosEtNomsPersonnes";
            this.nosEtNomsPersonnesBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // nosEtNomsPersonnesTableAdapter
            // 
            this.nosEtNomsPersonnesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dateHeure";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date et heure";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prix";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nomAssistant";
            this.dataGridViewTextBoxColumn4.HeaderText = "Assistant";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // frmRapportSoinsOffertsClientsInvites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label1);
            this.Name = "frmRapportSoinsOffertsClientsInvites";
            this.Text = "Rapport des soins offerts aux clients et aux invités";
            this.Load += new System.EventHandler(this.frmRapportSoinsOffertsClientsInvites_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinsOffertsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dggvSoinsOfferts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsPersonnesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPersonne;
        private System.Windows.Forms.Button btnQuitter;
        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource soinsOffertsBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.soinsOffertsTableAdapter soinsOffertsTableAdapter;
        private System.Windows.Forms.DataGridView dggvSoinsOfferts;
        private System.Windows.Forms.BindingSource nosEtNomsPersonnesBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.nosEtNomsPersonnesTableAdapter nosEtNomsPersonnesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}