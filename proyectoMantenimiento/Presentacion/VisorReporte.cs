using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using Reportes;

namespace proyectoMantenimiento.Presentacion
{
    public partial class VisorReporte : Form
    {
        public VisorReporte()
        {
            InitializeComponent();
        }

        private void VisorReporte_Load(object sender, EventArgs e)
        {
            poblardb();
        }



        public void poblardb()
        {
            String sqlLinea = "Select * from linea_produccion";
            String sqlMaquina = "Select * from maquina";
            dsLineaMaquina dset = new dsLineaMaquina();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=MARCOANTONIO-PC;Initial Catalog=dbMantenimiento;Integrated Security=True");
                SqlDataAdapter SqlDaLinea = new SqlDataAdapter(sqlLinea, con);
                SqlDataAdapter SqlDaMaquina = new SqlDataAdapter(sqlMaquina, con);
                SqlDaLinea.Fill(dset, "linea_produccion");
                SqlDaMaquina.Fill(dset, "maquina");
                ReporteMaquinaria ret = new ReporteMaquinaria();
                ret.SetDataSource(dset);
                crystalReportViewer1.ReportSource = ret;
            }
            catch
            {

            }
        }
    }
}
