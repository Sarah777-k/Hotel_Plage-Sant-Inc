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
    public partial class menuAdmin : Form
    {
        public string noAdmin;
        public menuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConnexion frmCo = new frmConnexion();
            frmCo.Show();
            this.Hide();
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {
            lblIdAdmin.Text = "Numéros d'employé: " + noAdmin;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
