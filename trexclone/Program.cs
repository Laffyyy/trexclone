using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Rex_Endless_Runner_MOO_ICT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// idk what the hell this is
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainmenu());
        }
    }
}
