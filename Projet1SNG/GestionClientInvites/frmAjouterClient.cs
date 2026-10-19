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
    public partial class frmAjouterClient : Form
    {
        public BDB56Projet1SNGDataSet.clientRow unClient { get; set; }
        private Regex exprTexte = new Regex("^[A-Za-zÀ-ÿ' -]+$");

        public frmAjouterClient()
        {
            InitializeComponent();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "") errMessageClient.SetError(tbNom, "Le nom ne peut pas être vide");
            else if (!exprTexte.IsMatch(tbNom.Text.Trim())) errMessageClient.SetError(tbNom, "Le nom ne doit contenir que des lettres");
            else errMessageClient.SetError(tbNom, "");

            if (tbPrenom.Text.Trim() == "") errMessageClient.SetError(tbPrenom, "Le prénom ne peut pas être vide");
            else if (!exprTexte.IsMatch(tbPrenom.Text.Trim())) errMessageClient.SetError(tbPrenom, "Le prénom ne doit contenir que des lettres");
            else errMessageClient.SetError(tbPrenom, "");

            if (tbAdresse.Text.Trim() == "") errMessageClient.SetError(tbAdresse, "L'adresse ne peut pas être vide");
            else errMessageClient.SetError(tbAdresse, "");

            if (tbVille.Text.Trim() == "") errMessageClient.SetError(tbVille, "La ville ne peut pas être vide");
            else if (!exprTexte.IsMatch(tbVille.Text.Trim())) errMessageClient.SetError(tbVille, "La ville ne doit contenir que des lettres");
            else errMessageClient.SetError(tbVille, "");

            if (tbPays.Text.Trim() == "") errMessageClient.SetError(tbPays, "Le pays ne peut pas être vide");
            else if (!exprTexte.IsMatch(tbPays.Text.Trim())) errMessageClient.SetError(tbPays, "Le pays ne doit contenir que des lettres");
            else errMessageClient.SetError(tbPays, "");

            if (tbCodePostal.Text.Trim() == "") errMessageClient.SetError(tbCodePostal, "Le code postal ne peut pas être vide");
            else errMessageClient.SetError(tbCodePostal, "");

            if (tbTelephone.Text.Trim() == "") errMessageClient.SetError(tbTelephone, "Le téléphone ne peut pas être vide");
            else errMessageClient.SetError(tbTelephone, "");

            if (errMessageClient.GetError(tbNom) == "" && errMessageClient.GetError(tbPrenom) == "" &&
                errMessageClient.GetError(tbAdresse) == "" && errMessageClient.GetError(tbVille) == "" &&
                errMessageClient.GetError(tbPays) == "" && errMessageClient.GetError(tbCodePostal) == "" &&
                errMessageClient.GetError(tbTelephone) == "")
            {
                unClient.nom = tbNom.Text.Trim();
                unClient.prenom = tbPrenom.Text.Trim();
                unClient.adresse = tbAdresse.Text.Trim();
                unClient.ville = tbVille.Text.Trim();
                unClient.pays = tbPays.Text.Trim();
                unClient.codePostal = tbCodePostal.Text.Trim();
                unClient.telephone = tbTelephone.Text.Trim();
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAjouterClient_Load(object sender, EventArgs e)
        {
            tbDateInscription.Text = unClient.dateInscription.ToShortDateString();

        }
    }
}
