namespace Projet1SNG.GestionChambre
{
    partial class frmGestionChambre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionChambre));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSupChambre = new System.Windows.Forms.Button();
            this.btnModifierChambre = new System.Windows.Forms.Button();
            this.btnAjouterChambre = new System.Windows.Forms.Button();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDB56Projet1SNGDataSet = new Projet1SNG.BDB56Projet1SNGDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSupType = new System.Windows.Forms.Button();
            this.btnModifierType = new System.Windows.Forms.Button();
            this.type_chambreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouterType = new System.Windows.Forms.Button();
            this.chambreTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.chambreTableAdapter();
            this.tableAdapterManager = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.TableAdapterManager();
            this.type_chambreTableAdapter = new Projet1SNG.BDB56Projet1SNGDataSetTableAdapters.type_chambreTableAdapter();
            this.chambreBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chambreBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.chambreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_chambreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingNavigator)).BeginInit();
            this.chambreBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chambreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des chambres et leurs types";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(39, 133);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.type_chambreDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnSupType);
            this.splitContainer1.Panel1.Controls.Add(this.btnModifierType);
            this.splitContainer1.Panel1.Controls.Add(this.btnAjouterType);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.chambreDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.btnSupChambre);
            this.splitContainer1.Panel2.Controls.Add(this.btnAjouterChambre);
            this.splitContainer1.Panel2.Controls.Add(this.btnModifierChambre);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 480);
            this.splitContainer1.SplitterDistance = 523;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Les chambres";
            // 
            // btnSupChambre
            // 
            this.btnSupChambre.Location = new System.Drawing.Point(354, 393);
            this.btnSupChambre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupChambre.Name = "btnSupChambre";
            this.btnSupChambre.Size = new System.Drawing.Size(124, 33);
            this.btnSupChambre.TabIndex = 4;
            this.btnSupChambre.Text = "Supprimer";
            this.btnSupChambre.UseVisualStyleBackColor = true;
            // 
            // btnModifierChambre
            // 
            this.btnModifierChambre.Location = new System.Drawing.Point(203, 393);
            this.btnModifierChambre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifierChambre.Name = "btnModifierChambre";
            this.btnModifierChambre.Size = new System.Drawing.Size(124, 33);
            this.btnModifierChambre.TabIndex = 3;
            this.btnModifierChambre.Text = "Modifier";
            this.btnModifierChambre.UseVisualStyleBackColor = true;
            // 
            // btnAjouterChambre
            // 
            this.btnAjouterChambre.Location = new System.Drawing.Point(56, 393);
            this.btnAjouterChambre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterChambre.Name = "btnAjouterChambre";
            this.btnAjouterChambre.Size = new System.Drawing.Size(124, 33);
            this.btnAjouterChambre.TabIndex = 2;
            this.btnAjouterChambre.Text = "Ajouter";
            this.btnAjouterChambre.UseVisualStyleBackColor = true;
            this.btnAjouterChambre.Click += new System.EventHandler(this.btnAjouterChambre_Click);
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "chambre";
            this.chambreBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // bDB56Projet1SNGDataSet
            // 
            this.bDB56Projet1SNGDataSet.DataSetName = "BDB56Projet1SNGDataSet";
            this.bDB56Projet1SNGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Les type de la chambre";
            // 
            // btnSupType
            // 
            this.btnSupType.Location = new System.Drawing.Point(348, 393);
            this.btnSupType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupType.Name = "btnSupType";
            this.btnSupType.Size = new System.Drawing.Size(124, 33);
            this.btnSupType.TabIndex = 7;
            this.btnSupType.Text = "Supprimer";
            this.btnSupType.UseVisualStyleBackColor = true;
            this.btnSupType.Click += new System.EventHandler(this.btnSupType_Click);
            // 
            // btnModifierType
            // 
            this.btnModifierType.Location = new System.Drawing.Point(197, 393);
            this.btnModifierType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifierType.Name = "btnModifierType";
            this.btnModifierType.Size = new System.Drawing.Size(124, 33);
            this.btnModifierType.TabIndex = 6;
            this.btnModifierType.Text = "Modifier";
            this.btnModifierType.UseVisualStyleBackColor = true;
            this.btnModifierType.Click += new System.EventHandler(this.btnModifierType_Click);
            // 
            // type_chambreDataGridView
            // 
            this.type_chambreDataGridView.AutoGenerateColumns = false;
            this.type_chambreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.type_chambreDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.type_chambreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.type_chambreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.type_chambreDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.chambreBindingSource, "id_typeChambre", true));
            this.type_chambreDataGridView.DataSource = this.type_chambreBindingSource;
            this.type_chambreDataGridView.Location = new System.Drawing.Point(14, 87);
            this.type_chambreDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.type_chambreDataGridView.Name = "type_chambreDataGridView";
            this.type_chambreDataGridView.ReadOnly = true;
            this.type_chambreDataGridView.RowHeadersWidth = 24;
            this.type_chambreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.type_chambreDataGridView.Size = new System.Drawing.Size(485, 278);
            this.type_chambreDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_typeChambre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type chambre";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "prixHaut";
            this.dataGridViewTextBoxColumn7.HeaderText = "Prix Haut";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "prixMoyen";
            this.dataGridViewTextBoxColumn8.HeaderText = "Prix Moyen";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "prixBas";
            this.dataGridViewTextBoxColumn9.HeaderText = "Prix Bas";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // type_chambreBindingSource
            // 
            this.type_chambreBindingSource.DataMember = "type_chambre";
            this.type_chambreBindingSource.DataSource = this.bDB56Projet1SNGDataSet;
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.Location = new System.Drawing.Point(43, 393);
            this.btnAjouterType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(124, 33);
            this.btnAjouterType.TabIndex = 5;
            this.btnAjouterType.Text = "Ajouter";
            this.btnAjouterType.UseVisualStyleBackColor = true;
            this.btnAjouterType.Click += new System.EventHandler(this.btnAjouterType_Click);
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
            // type_chambreTableAdapter
            // 
            this.type_chambreTableAdapter.ClearBeforeFill = true;
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
            this.chambreBindingNavigator.Size = new System.Drawing.Size(1123, 31);
            this.chambreBindingNavigator.TabIndex = 3;
            this.chambreBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // chambreBindingNavigatorSaveItem
            // 
            this.chambreBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chambreBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("chambreBindingNavigatorSaveItem.Image")));
            this.chambreBindingNavigatorSaveItem.Name = "chambreBindingNavigatorSaveItem";
            this.chambreBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.chambreBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.chambreBindingNavigatorSaveItem.Click += new System.EventHandler(this.chambreBindingNavigatorSaveItem_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEnregistrer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnregistrer.Location = new System.Drawing.Point(588, 638);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(124, 33);
            this.btnEnregistrer.TabIndex = 9;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFermer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFermer.Location = new System.Drawing.Point(433, 638);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(124, 33);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            // 
            // chambreDataGridView
            // 
            this.chambreDataGridView.AutoGenerateColumns = false;
            this.chambreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chambreDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chambreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chambreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.chambreDataGridView.DataSource = this.chambreBindingSource1;
            this.chambreDataGridView.Location = new System.Drawing.Point(56, 87);
            this.chambreDataGridView.Name = "chambreDataGridView";
            this.chambreDataGridView.ReadOnly = true;
            this.chambreDataGridView.RowHeadersWidth = 24;
            this.chambreDataGridView.RowTemplate.Height = 24;
            this.chambreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chambreDataGridView.Size = new System.Drawing.Size(407, 278);
            this.chambreDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_chambre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id chambre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "emplacement";
            this.dataGridViewTextBoxColumn2.HeaderText = "Emplacement";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "decoration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Décoration";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // chambreBindingSource1
            // 
            this.chambreBindingSource1.DataMember = "fk_typeChambre";
            this.chambreBindingSource1.DataSource = this.type_chambreBindingSource;
            // 
            // frmGestionChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 686);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.chambreBindingNavigator);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGestionChambre";
            this.Text = "Gestion Chambre";
            this.Load += new System.EventHandler(this.frmGestionChambre_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56Projet1SNGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_chambreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingNavigator)).EndInit();
            this.chambreBindingNavigator.ResumeLayout(false);
            this.chambreBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chambreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private BDB56Projet1SNGDataSetTableAdapters.type_chambreTableAdapter type_chambreTableAdapter;
        private System.Windows.Forms.BindingSource type_chambreBindingSource;
        private System.Windows.Forms.DataGridView type_chambreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnSupChambre;
        private System.Windows.Forms.Button btnModifierChambre;
        private System.Windows.Forms.Button btnAjouterChambre;
        private System.Windows.Forms.Button btnSupType;
        private System.Windows.Forms.Button btnModifierType;
        private System.Windows.Forms.Button btnAjouterType;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView chambreDataGridView;
        private System.Windows.Forms.BindingSource chambreBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}