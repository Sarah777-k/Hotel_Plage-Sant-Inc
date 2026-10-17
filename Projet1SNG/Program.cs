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
            
            //Application.Run(new Menu());
            Application.Run(new GestionChambre.frmGestionChambre());

            //Application.Run(new FrmGestionAssistants());
            //Application.Run(new Form1());
        }
    }
}
