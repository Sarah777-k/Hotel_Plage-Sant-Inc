using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG.Rapport
{
    public partial class frmRapportSoinsOffertsClientsInvites : Form
    {
        public frmRapportSoinsOffertsClientsInvites()
        {
            InitializeComponent();
        }

        private void soinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.bDB56Projet1SNGDataSet);

        }

        private void frmRapportSoinsOffertsClientsInvites_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.nosEtNomsPersonnes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtNomsPersonnesTableAdapter.Fill(this.bDB56Projet1SNGDataSet.nosEtNomsPersonnes);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.

            if (cmbPersonne.SelectedValue == null)
                return;

            soinsOffertsTableAdapter.Fill(bDB56Projet1SNGDataSet.soinsOfferts,
                                          Convert.ToInt32(cmbPersonne.SelectedValue));

            decimal total = 0;
            foreach (BDB56Projet1SNGDataSet.soinsOffertsRow ligne in bDB56Projet1SNGDataSet.soinsOfferts)
                total += ligne.prix;

            tbTotal.Text = total.ToString("C");

        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersonne.SelectedValue == null)
                return;

            soinsOffertsTableAdapter.Fill(bDB56Projet1SNGDataSet.soinsOfferts,
                                          Convert.ToInt32(cmbPersonne.SelectedValue));

            decimal total = 0;
            foreach (BDB56Projet1SNGDataSet.soinsOffertsRow ligne in bDB56Projet1SNGDataSet.soinsOfferts)
                total += ligne.prix;

            tbTotal.Text = total.ToString("C");
        }
    }
}
