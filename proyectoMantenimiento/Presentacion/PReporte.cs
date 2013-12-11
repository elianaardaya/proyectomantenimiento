using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Reportes;
using System.Configuration;

namespace proyectoMantenimiento.Presentacion
{
    public partial class PReporte : Form
    {
        public PReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 visor = new Form3(ConfigurationManager.AppSettings["cadena_conexion"]);

            visor.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RSolicitud visor = new RSolicitud(ConfigurationManager.AppSettings["cadena_conexion"]);
            visor.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RInventario visor = new RInventario(ConfigurationManager.AppSettings["cadena_conexion"]);
            visor.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RProblema visor = new RProblema(ConfigurationManager.AppSettings["cadena_conexion"]);
            visor.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RReparacion visor = new RReparacion(ConfigurationManager.AppSettings["cadena_conexion"]);
            visor.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 visor = new Form2(ConfigurationManager.AppSettings["cadena_conexion"]);
            visor.ShowDialog(this);
        }
    }
}
