using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Final.Senai.VIEW
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
            Application.Run(new AbtApresentação());

            //FrmUsuario usuario = new FrmUsuario();
            //if (usuario.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new AboutBox1());
            //}
        }
    }
}
