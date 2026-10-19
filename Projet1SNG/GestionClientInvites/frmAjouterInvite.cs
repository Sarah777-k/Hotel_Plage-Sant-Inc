using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG.GestionClientInvites
{
    public partial class frmAjouterInvite : Form
    {
        public BDB56Projet1SNGDataSet.inviteRow unInvite { get; set; }
        private Regex exprTexte = new Regex("^[A-Za-zÀ-ÿ' -]+$");

        public frmAjouterInvite()
        {
            InitializeComponent();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "")
            {
                errMessageInvite.SetError(tbNom, "Le nom ne peut pas être vide");
            }
            else if (!exprTexte.IsMatch(tbNom.Text.Trim()))
            {
                errMessageInvite.SetError(tbNom, "Le nom ne doit contenir que des lettres");
            }
            else
            {
                errMessageInvite.SetError(tbNom, "");
            }

            if (tbPrenom.Text.Trim() == "")
            {
                errMessageInvite.SetError(tbPrenom, "Le prénom ne peut pas être vide");
            }
            else if (!exprTexte.IsMatch(tbPrenom.Text.Trim()))
            {
                errMessageInvite.SetError(tbPrenom, "Le prénom ne doit contenir que des lettres");
            }
            else
            {
                errMessageInvite.SetError(tbPrenom, "");
            }

            if (errMessageInvite.GetError(tbNom) == "" && errMessageInvite.GetError(tbPrenom) == "")
            {
                unInvite.nom = tbNom.Text.Trim();
                unInvite.prenom = tbPrenom.Text.Trim();
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
