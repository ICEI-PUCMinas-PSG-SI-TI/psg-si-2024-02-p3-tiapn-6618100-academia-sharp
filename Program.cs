using BodyShape_TI;
using BodyShape_TI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

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
            Application.Run(new FormEndereco());

            //referencia para bioimpedancia:BodyShape_TI.Forms.
        }
    }
}
