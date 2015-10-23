using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Capitulo09_Laboratorio01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new cap09_Lab01Form());
        }
    }
}
