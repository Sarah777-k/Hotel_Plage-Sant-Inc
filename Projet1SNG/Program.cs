using Projet1SNG.GestionClientInvites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1SNG
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new frmConnexion());
            //Application.Run(new frmGestionUtilisateurs());
            //Application.Run(new FrmGestionAssistants());
            //Application.Run(new Form1());
            Application.Run(new frmGestionClientInvites());
        }
    }
}
