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
    public partial class RRecomendacion : Form
    {
        private string cadena;
        public RRecomendacion(String cad)
        {
            InitializeComponent();
            cadena=cad;
        }

        private void RRecomendacion_Load(object sender, EventArgs e)
        {

        }

        public void poblardb()
        {
            String sqlRecom = "Select * from recomendacion";

            String sqlMaquina = "Select * from maquina";
            dsRecomendacion dset = new dsRecomendacion();
            try
            {
                SqlConnection con = new SqlConnection(cadena);
                SqlDataAdapter SqlDaProblema = new SqlDataAdapter(sqlRecom, con);

                SqlDataAdapter SqlDaMaquina = new SqlDataAdapter(sqlMaquina, con);
                SqlDaProblema.Fill(dset, "recomendacion");

                SqlDaMaquina.Fill(dset, "maquina");
                ReporteRecomendacion ret = new ReporteRecomendacion();
                ret.SetDataSource(dset);
                crystalReportViewer1.ReportSource = ret;
            }
            catch
            {

            }
        }
    }
}
