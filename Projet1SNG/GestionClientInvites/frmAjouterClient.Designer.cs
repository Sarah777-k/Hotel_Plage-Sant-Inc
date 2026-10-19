namespace Projet1SNG.GestionClientInvites
{
    partial class frmAjouterClient
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDateInscription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errMessageClient = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errMessageClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnuler.Location = new System.Drawing.Point(77, 477);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Fermer";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.Location = new System.Drawing.Point(205, 477);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 12;
            this.btnCreer.Text = "Ajouter";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ajouter un client: ";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(120, 132);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(138, 20);
            this.tbPrenom.TabIndex = 10;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(120, 83);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(138, 20);
            this.tbNom.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenom: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom: ";
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(120, 186);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(138, 20);
            this.tbAdresse.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adresse: ";
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(120, 235);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(138, 20);
            this.tbVille.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ville: ";
            // 
            // tbPays
            // 
            this.tbPays.Location = new System.Drawing.Point(120, 279);
            this.tbPays.Name = "tbPays";
            this.tbPays.Size = new System.Drawing.Size(138, 20);
            this.tbPays.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pays: ";
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Location = new System.Drawing.Point(133, 356);
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(125, 20);
            this.tbCodePostal.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Code postal: ";
            // 
            // tbDateInscription
            // 
            this.tbDateInscription.Location = new System.Drawing.Point(158, 399);
            this.tbDateInscription.Name = "tbDateInscription";
            this.tbDateInscription.ReadOnly = true;
            this.tbDateInscription.Size = new System.Drawing.Size(100, 20);
            this.tbDateInscription.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Date d\'inscription: ";
            // 
            // errMessageClient
            // 
            this.errMessageClient.ContainerControl = this;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(133, 322);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(125, 20);
            this.tbTelephone.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Telephone:";
            // 
            // frmAjouterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 542);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbDateInscription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAjouterClient";
            this.Text = "Ajouter un nouveau client";
            this.Load += new System.EventHandler(this.frmAjouterClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMessageClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDateInscription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errMessageClient;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label label9;
    }
}