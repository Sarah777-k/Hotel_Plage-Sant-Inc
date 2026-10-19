namespace Projet1SNG.GestionChambre
{
    partial class frmModifierChambre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifierChambre));
            System.Windows.Forms.Label id_chambreLabel;
            System.Windows.Forms.Label emplacementLabel;
            System.Windows.Forms.Label decorationLabel;
            System.Windows.Forms.Label id_typeChambreLabel;
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.chambreTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.chambreBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.chambreBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtIdChambre = new System.Windows.Forms.TextBox();
            this.txtEmplacement = new System.Windows.Forms.TextBox();
            this.txtDecoration = new System.Windows.Forms.TextBox();
            this.cboTypeChambre = new System.Windows.Forms.ComboBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.type_chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_chambreTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.type_chambreTableAdapter();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            id_chambreLabel = new System.Windows.Forms.Label();
            emplacementLabel = new System.Windows.Forms.Label();
            decorationLabel = new System.Windows.Forms.Label();
            id_typeChambreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingNavigator)).BeginInit();
            this.chambreBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.type_chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "chambre";
            this.chambreBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
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
            // chambreBindingNavigator
            // 
            this.chambreBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.chambreBindingNavigator.BindingSource = this.chambreBindingSource;
            this.chambreBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.chambreBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.chambreBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.chambreBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.chambreBindingNavigatorSaveItem});
            this.chambreBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.chambreBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.chambreBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.chambreBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.chambreBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.chambreBindingNavigator.Name = "chambreBindingNavigator";
            this.chambreBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.chambreBindingNavigator.Size = new System.Drawing.Size(660, 27);
            this.chambreBindingNavigator.TabIndex = 0;
            this.chambreBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // chambreBindingNavigatorSaveItem
            // 
            this.chambreBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chambreBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("chambreBindingNavigatorSaveItem.Image")));
            this.chambreBindingNavigatorSaveItem.Name = "chambreBindingNavigatorSaveItem";
            this.chambreBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.chambreBindingNavigatorSaveItem.Text = "Enregistrer les données";
            //this.chambreBindingNavigatorSaveItem.Click += new System.EventHandler(this.chambreBindingNavigatorSaveItem_Click_1);
            // 
            // id_chambreLabel
            // 
            id_chambreLabel.AutoSize = true;
            id_chambreLabel.Location = new System.Drawing.Point(188, 133);
            id_chambreLabel.Name = "id_chambreLabel";
            id_chambreLabel.Size = new System.Drawing.Size(77, 16);
            id_chambreLabel.TabIndex = 1;
            id_chambreLabel.Text = "Id chambre:";
            // 
            // txtIdChambre
            // 
            this.txtIdChambre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chambreBindingSource, "id_chambre", true));
            this.txtIdChambre.Location = new System.Drawing.Point(302, 130);
            this.txtIdChambre.Name = "txtIdChambre";
            this.txtIdChambre.ReadOnly = true;
            this.txtIdChambre.Size = new System.Drawing.Size(185, 22);
            this.txtIdChambre.TabIndex = 2;
            // 
            // emplacementLabel
            // 
            emplacementLabel.AutoSize = true;
            emplacementLabel.Location = new System.Drawing.Point(188, 176);
            emplacementLabel.Name = "emplacementLabel";
            emplacementLabel.Size = new System.Drawing.Size(93, 16);
            emplacementLabel.TabIndex = 3;
            emplacementLabel.Text = "Emplacement:";
            // 
            // txtEmplacement
            // 
            this.txtEmplacement.Location = new System.Drawing.Point(302, 173);
            this.txtEmplacement.Name = "txtEmplacement";
            this.txtEmplacement.Size = new System.Drawing.Size(185, 22);
            this.txtEmplacement.TabIndex = 4;
            // 
            // decorationLabel
            // 
            decorationLabel.AutoSize = true;
            decorationLabel.Location = new System.Drawing.Point(188, 222);
            decorationLabel.Name = "decorationLabel";
            decorationLabel.Size = new System.Drawing.Size(76, 16);
            decorationLabel.TabIndex = 5;
            decorationLabel.Text = "Décoration:";
            // 
            // txtDecoration
            // 
            this.txtDecoration.Location = new System.Drawing.Point(302, 219);
            this.txtDecoration.Name = "txtDecoration";
            this.txtDecoration.Size = new System.Drawing.Size(185, 22);
            this.txtDecoration.TabIndex = 6;
            // 
            // id_typeChambreLabel
            // 
            id_typeChambreLabel.AutoSize = true;
            id_typeChambreLabel.Location = new System.Drawing.Point(188, 263);
            id_typeChambreLabel.Name = "id_typeChambreLabel";
            id_typeChambreLabel.Size = new System.Drawing.Size(100, 16);
            id_typeChambreLabel.TabIndex = 7;
            id_typeChambreLabel.Text = "Type Chambre:";
            // 
            // cboTypeChambre
            // 
            this.cboTypeChambre.DataSource = this.type_chambreBindingSource;
            this.cboTypeChambre.DisplayMember = "description";
            this.cboTypeChambre.FormattingEnabled = true;
            this.cboTypeChambre.Location = new System.Drawing.Point(303, 263);
            this.cboTypeChambre.Name = "cboTypeChambre";
            this.cboTypeChambre.Size = new System.Drawing.Size(184, 24);
            this.cboTypeChambre.TabIndex = 8;
            this.cboTypeChambre.ValueMember = "id_typeChambre";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFermer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFermer.Location = new System.Drawing.Point(248, 333);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 30);
            this.btnFermer.TabIndex = 13;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(359, 333);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 30);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Modifier la chambre";
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
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmModifierChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cboTypeChambre);
            this.Controls.Add(id_chambreLabel);
            this.Controls.Add(this.txtIdChambre);
            this.Controls.Add(emplacementLabel);
            this.Controls.Add(this.txtEmplacement);
            this.Controls.Add(decorationLabel);
            this.Controls.Add(this.txtDecoration);
            this.Controls.Add(id_typeChambreLabel);
            this.Controls.Add(this.chambreBindingNavigator);
            this.Name = "frmModifierChambre";
            this.Text = "Modifier Chambre";
            this.Load += new System.EventHandler(this.frmModifierChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingNavigator)).EndInit();
            this.chambreBindingNavigator.ResumeLayout(false);
            this.chambreBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.type_chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56Projet1SNGDataSet bDB56Projet1SNGDataSet;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private BDB56Projet1SNGDataSetTableAdapters.chambreTableAdapter chambreTableAdapter;
        private BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator chambreBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton chambreBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtIdChambre;
        private System.Windows.Forms.TextBox txtEmplacement;
        private System.Windows.Forms.TextBox txtDecoration;
        private System.Windows.Forms.ComboBox cboTypeChambre;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label1;
        private BDB56Projet1SNGDataSetTableAdapters.type_chambreTableAdapter type_chambreTableAdapter;
        private System.Windows.Forms.BindingSource type_chambreBindingSource;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}