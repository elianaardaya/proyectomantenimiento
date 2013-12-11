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
    public partial class RReparacion : Form
    {
        String cad;
        public RReparacion(String cadena)
        {
            InitializeComponent();
            cad = cadena;
        }

        private void RReparacion_Load(object sender, EventArgs e)
        {
            poblardb();
        }

        public void poblardb()
        {
            String sqlReparacion = "Select * from detalle_reparo";
            String sqlInventario = "Select * from inventario";
            String sqlMaterial = "Select * from material_herramienta";
            String sqlUsuario = "Select * from Usuario";
            String sqlComponente = "Select * from componente";
            String sqldetalleC = "Select * from detalleComponente";
            String sqldetalleMat = "Select * from materialusado";
            String sqlMaquina = "Select * from maquina";

            
            dsReparacion dset = new dsReparacion();
            try
            {
                SqlConnection con = new SqlConnection(cad);
                SqlDataAdapter SqlDaRep = new SqlDataAdapter(sqlReparacion, con);
                SqlDataAdapter SqlDaInv = new SqlDataAdapter(sqlInventario, con);
                SqlDataAdapter SqlDaMat = new SqlDataAdapter(sqlMaterial, con);
                SqlDataAdapter SqlDaUsuario = new SqlDataAdapter(sqlUsuario, con);
                SqlDataAdapter SqlDaComponente = new SqlDataAdapter(sqlComponente, con);
                SqlDataAdapter SqlDaDetalleC = new SqlDataAdapter(sqldetalleC, con);
                SqlDataAdapter SqlDaDetalleM = new SqlDataAdapter(sqldetalleMat, con);
                SqlDataAdapter SqlDaMaquina = new SqlDataAdapter(sqlMaquina, con);
                SqlDaRep.Fill(dset, "detalle_reparo");
                SqlDaInv.Fill(dset, "inventario");
                SqlDaMat.Fill(dset, "material_herramienta");
                SqlDaUsuario.Fill(dset, "Usuario");
                SqlDaComponente.Fill(dset, "componente");
                SqlDaDetalleC.Fill(dset, "detalleComponente");
                SqlDaDetalleM.Fill(dset, "materialusado");
                SqlDaMaquina.Fill(dset, "maquina");
                ReporteReparacion ret = new ReporteReparacion();
                ret.SetDataSource(dset);
                crystalReportViewer1.ReportSource = ret;
            }
            catch
            {

            }
        }
    }
}
