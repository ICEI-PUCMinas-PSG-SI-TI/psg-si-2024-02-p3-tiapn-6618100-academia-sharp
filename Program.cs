using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BS_Projeto
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPlanos());
        }
    }
}
