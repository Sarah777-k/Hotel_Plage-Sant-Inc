using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG
{
    public partial class frmPlanifSoins : Form
    {
        public frmPlanifSoins()
        {
            InitializeComponent();
        }


        private void frmPlanifSoins_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.nosEtNomsAssistants'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtNomsAssistantsTableAdapter.Fill(this.bDB56Projet1SNGDataSet.nosEtNomsAssistants);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.soinTableAdapter.Fill(this.bDB56Projet1SNGDataSet.soin);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.nosEtNomsPersonnes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtNomsPersonnesTableAdapter.Fill(this.bDB56Projet1SNGDataSet.nosEtNomsPersonnes);
            // TODO: cette ligne de code charge les données dans la table 'bDB56Projet1SNGDataSet.planif_soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.planif_soinTableAdapter.Fill(this.bDB56Projet1SNGDataSet.planif_soin);

            assistantsParSoinTableAdapter.Fill(bDB56Projet1SNGDataSet.assistantsParSoin, Convert.ToInt32(cmbSoin.SelectedValue));

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPlanifSoins.CurrentRow == null)
            {
                MessageBox.Show("Vous devez choisir une réservation à supprimer.","Aucune sélection");
                return;
            }

            DataRowView drv = (DataRowView)dgvPlanifSoins.CurrentRow.DataBoundItem;

            if (Convert.ToBoolean(drv["fait"]))
            {
                MessageBox.Show("On ne peut pas supprimer un soin déjà offert.","Suppression impossible");
                return;
            }

            if (MessageBox.Show("Voulez-vous vraiment supprimer cette réservation ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                planif_soinBindingSource.RemoveCurrent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                planif_soinBindingSource.EndEdit();
                planif_soinTableAdapter.Update(bDB56Projet1SNGDataSet.planif_soin);
                MessageBox.Show("Les modifications ont été enregistrées.","Enregistrement");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message,"Erreur");
            }
        }

        private void btnPlanifier_Click(object sender, EventArgs e)
        {
            if (cmbPersonne.SelectedValue == null || cmbSoin.SelectedValue == null || cmbAssistant.SelectedValue == null)
            {
                MessageBox.Show("Vous devez choisir une personne, un soin et un assistant.","Champs manquants");
                return;
            }

            if (dtpDate.Value.Date < DateTime.Now.Date)
                errMessage.SetError(dtpDate, "La date ne peut pas être antérieure à aujourd'hui");
            else if (dtpDate.Value.DayOfWeek == DayOfWeek.Saturday || dtpDate.Value.DayOfWeek == DayOfWeek.Sunday)
                errMessage.SetError(dtpDate, "La date ne peut pas être un samedi ou un dimanche");
            else
            {
                errMessage.SetError(dtpDate, "");

                if (dtpHeure.Value.Hour < 8 || dtpHeure.Value.Hour > 17)
                    errMessage.SetError(dtpHeure, "L'heure doit être entre 8h et 17h");
                else
                {
                    errMessage.SetError(dtpHeure, "");

                    DateTime dateHeure = dtpDate.Value.Date.Add(dtpHeure.Value.TimeOfDay);
                    int idAssistant = Convert.ToInt32(cmbAssistant.SelectedValue);

                    bool conflit = false;
                    foreach (BDB56Projet1SNGDataSet.planif_soinRow ligne in bDB56Projet1SNGDataSet.planif_soin)
                    {
                        if (ligne.RowState != DataRowState.Deleted &&
                            ligne.id_assistant == idAssistant &&
                            ligne.dateHeure == dateHeure)
                            conflit = true;
                    }

                    if (conflit)
                        errMessage.SetError(cmbAssistant, "Cet assistant donne déjà un soin à cette date et à cette heure");
                    else
                    {
                        errMessage.SetError(cmbAssistant, "");

                        BDB56Projet1SNGDataSet.planif_soinRow unSoin = bDB56Projet1SNGDataSet.planif_soin.Newplanif_soinRow();
                        unSoin.id_personne = Convert.ToInt32(cmbPersonne.SelectedValue);
                        unSoin.id_assistant = idAssistant;
                        unSoin.dateHeure = dateHeure;
                        unSoin.id_soin = Convert.ToInt32(cmbSoin.SelectedValue);
                        unSoin.fait = false;
                        bDB56Projet1SNGDataSet.planif_soin.Addplanif_soinRow(unSoin);

                        planif_soinBindingSource.MoveLast();
                        MessageBox.Show("Le soin a été planifié.", "Confirmation");
                    }
                }
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            assistantsParSoinTableAdapter.Fill(bDB56Projet1SNGDataSet.assistantsParSoin, Convert.ToInt32(cmbSoin.SelectedValue));
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bDB56Projet1SNGDataSet.planif_soin.RejectChanges();
            planif_soinBindingSource.ResetBindings(false);
        }
    }
}
