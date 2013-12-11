using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reportes
{
    public partial class Form3 : Form
    {
        String cad;
        public Form3(String cadena)
        {
            InitializeComponent();
            cad = cadena;
        }

        private void Form1_Load(object sender, EventArgs e)
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
                SqlConnection con = new SqlConnection(cad);
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
