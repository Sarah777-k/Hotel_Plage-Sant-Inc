namespace Projet1SNG.GestionChambre
{
    partial class frmModifierTypeChambre
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
            System.Windows.Forms.Label id_typeChambreLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label prixHautLabel;
            System.Windows.Forms.Label prixMoyenLabel;
            System.Windows.Forms.Label prixBasLabel;
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.type_chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_chambreTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.type_chambreTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.txtIdTypeChambre = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrixHaut = new System.Windows.Forms.TextBox();
            this.txtPrixMoyen = new System.Windows.Forms.TextBox();
            this.txtPrixBas = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            id_typeChambreLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            prixHautLabel = new System.Windows.Forms.Label();
            prixMoyenLabel = new System.Windows.Forms.Label();
            prixBasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // id_typeChambreLabel
            // 
            id_typeChambreLabel.AutoSize = true;
            id_typeChambreLabel.Location = new System.Drawing.Point(231, 132);
            id_typeChambreLabel.Name = "id_typeChambreLabel";
            id_typeChambreLabel.Size = new System.Drawing.Size(108, 16);
            id_typeChambreLabel.TabIndex = 1;
            id_typeChambreLabel.Text = "ID type chambre:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(231, 171);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // prixHautLabel
            // 
            prixHautLabel.AutoSize = true;
            prixHautLabel.Location = new System.Drawing.Point(231, 209);
            prixHautLabel.Name = "prixHautLabel";
            prixHautLabel.Size = new System.Drawing.Size(60, 16);
            prixHautLabel.TabIndex = 5;
            prixHautLabel.Text = "Prix haut:";
            // 
            // prixMoyenLabel
            // 
            prixMoyenLabel.AutoSize = true;
            prixMoyenLabel.Location = new System.Drawing.Point(231, 249);
            prixMoyenLabel.Name = "prixMoyenLabel";
            prixMoyenLabel.Size = new System.Drawing.Size(76, 16);
            prixMoyenLabel.TabIndex = 7;
            prixMoyenLabel.Text = "Prix moyen:";
            // 
            // prixBasLabel
            // 
            prixBasLabel.AutoSize = true;
            prixBasLabel.Location = new System.Drawing.Point(231, 287);
            prixBasLabel.Name = "prixBasLabel";
            prixBasLabel.Size = new System.Drawing.Size(58, 16);
            prixBasLabel.TabIndex = 9;
            prixBasLabel.Text = "Prix bas:";
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // type_chambreBindingSource
            // 
            this.type_chambreBindingSource.DataMember = "type_chambre";
            this.type_chambreBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // type_chambreTableAdapter
            // 
            this.type_chambreTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.type_chambreTableAdapter = this.type_chambreTableAdapter;
            this.tableAdapterManager.type_soinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // txtIdTypeChambre
            // 
            this.txtIdTypeChambre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.type_chambreBindingSource, "id_typeChambre", true));
            this.txtIdTypeChambre.Location = new System.Drawing.Point(345, 129);
            this.txtIdTypeChambre.Name = "txtIdTypeChambre";
            this.txtIdTypeChambre.ReadOnly = true;
            this.txtIdTypeChambre.Size = new System.Drawing.Size(127, 22);
            this.txtIdTypeChambre.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.type_chambreBindingSource, "description", true));
            this.txtDescription.Location = new System.Drawing.Point(345, 168);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(127, 22);
            this.txtDescription.TabIndex = 4;
            // 
            // txtPrixHaut
            // 
            this.txtPrixHaut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.type_chambreBindingSource, "prixHaut", true));
            this.txtPrixHaut.Location = new System.Drawing.Point(345, 206);
            this.txtPrixHaut.Name = "txtPrixHaut";
            this.txtPrixHaut.Size = new System.Drawing.Size(127, 22);
            this.txtPrixHaut.TabIndex = 6;
            // 
            // txtPrixMoyen
            // 
            this.txtPrixMoyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.type_chambreBindingSource, "prixMoyen", true));
            this.txtPrixMoyen.Location = new System.Drawing.Point(345, 246);
            this.txtPrixMoyen.Name = "txtPrixMoyen";
            this.txtPrixMoyen.Size = new System.Drawing.Size(127, 22);
            this.txtPrixMoyen.TabIndex = 8;
            // 
            // txtPrixBas
            // 
            this.txtPrixBas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.type_chambreBindingSource, "prixBas", true));
            this.txtPrixBas.Location = new System.Drawing.Point(345, 284);
            this.txtPrixBas.Name = "txtPrixBas";
            this.txtPrixBas.Size = new System.Drawing.Size(127, 22);
            this.txtPrixBas.TabIndex = 10;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(202, 75);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(285, 25);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "Modifier un type de chambre";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFermer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFermer.Location = new System.Drawing.Point(250, 353);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 30);
            this.btnFermer.TabIndex = 15;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(361, 353);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 30);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "$";
            // 
            // frmModifierTypeChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lbl);
            this.Controls.Add(id_typeChambreLabel);
            this.Controls.Add(this.txtIdTypeChambre);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(prixHautLabel);
            this.Controls.Add(this.txtPrixHaut);
            this.Controls.Add(prixMoyenLabel);
            this.Controls.Add(this.txtPrixMoyen);
            this.Controls.Add(prixBasLabel);
            this.Controls.Add(this.txtPrixBas);
            this.Name = "frmModifierTypeChambre";
            this.Text = "Modifier Type Chambre";
            this.Load += new System.EventHandler(this.frmModifierTypeChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private System.Windows.Forms.BindingSource type_chambreBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.type_chambreTableAdapter type_chambreTableAdapter;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtIdTypeChambre;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrixHaut;
        private System.Windows.Forms.TextBox txtPrixMoyen;
        private System.Windows.Forms.TextBox txtPrixBas;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}