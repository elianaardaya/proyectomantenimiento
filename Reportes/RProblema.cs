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
    public partial class RProblema : Form
    {
        String cad;
        public RProblema(String cadena)
        {
            InitializeComponent();
            cad = cadena;
        }

        private void RProblema_Load(object sender, EventArgs e)
        {
            poblardb();
        }

        public void poblardb()
        {
            String sqlProblema = "Select * from problema";
           
            String sqlMaquina = "Select * from maquina";
            dsProblema dset = new dsProblema();
            try
            {
                SqlConnection con = new SqlConnection(cad);
                SqlDataAdapter SqlDaProblema = new SqlDataAdapter(sqlProblema, con);
                
                SqlDataAdapter SqlDaMaquina = new SqlDataAdapter(sqlMaquina, con);
                SqlDaProblema.Fill(dset, "problema");
                
                SqlDaMaquina.Fill(dset, "maquina");
                ReporteProblema ret = new ReporteProblema();
                ret.SetDataSource(dset);
                crystalReportViewer1.ReportSource = ret;
            }
            catch
            {

            }
        }
    }
}
