using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using proyectoMantenimiento.Presentacion;

namespace proyectoMantenimiento
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
            PInicioSesion inicio = new PInicioSesion();
            Application.Run(inicio);
            Application.Run(new Form1());
            
        }
    }
}
