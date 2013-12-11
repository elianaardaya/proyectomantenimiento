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
    public partial class RSolicitud : Form
    {
        String cad;
        public RSolicitud(String cadena)
        {
            InitializeComponent();
            cad = cadena;
        }

        private void RSolicitud_Load(object sender, EventArgs e)
        {
            poblardb();
        }


        public void poblardb()
        {
            String sqlUsuario = "Select * from Usuario";
            String sqlMaquina = "Select * from maquina";
            String sqlSolicitud = "Select * from solicitud";
            dsSolicitud dset = new dsSolicitud();
            try
            {
                SqlConnection con = new SqlConnection(cad);
                SqlDataAdapter SqlDaUser = new SqlDataAdapter(sqlUsuario, con);
                SqlDataAdapter SqlDaMaquina = new SqlDataAdapter(sqlMaquina, con);
                SqlDataAdapter SqlDaSolicitud = new SqlDataAdapter(sqlSolicitud, con);
                SqlDaUser.Fill(dset, "Usuario");
                SqlDaMaquina.Fill(dset, "maquina");
                SqlDaSolicitud.Fill(dset, "solicitud");
                ReporteSolicitud ret = new ReporteSolicitud();
                ret.SetDataSource(dset);
                crystalReportViewer1.ReportSource = ret;
            }
            catch
            {

            }
        }
    }
}
