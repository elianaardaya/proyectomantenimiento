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
    public partial class RInventario : Form
    {
        String cad;
        public RInventario(String cadena)
        {
            InitializeComponent();
            cad = cadena;
        }

        private void RInventario_Load(object sender, EventArgs e)
        {
            poblardb();
        }

        public void poblardb()
        {
            String sqlProveedor = "Select * from proveedor";
            String sqlInventario = "Select * from inventario";
            String sqlMaterial = "Select * from material_herramienta";
            dsInventario dset = new dsInventario();
            try
            {
                SqlConnection con = new SqlConnection(cad);
                SqlDataAdapter SqlDaProv = new SqlDataAdapter(sqlProveedor, con);
                SqlDataAdapter SqlDaInv = new SqlDataAdapter(sqlInventario, con);
                SqlDataAdapter SqlDaMat = new SqlDataAdapter(sqlMaterial, con);
                SqlDaProv.Fill(dset, "proveedor");
                SqlDaInv.Fill(dset, "inventario");
                SqlDaMat.Fill(dset, "material_herramienta");
                ReporteInventario ret = new ReporteInventario();
                ret.SetDataSource(dset);
                crystalReportViewer1.ReportSource = ret;
            }
            catch
            {

            }
        }
    }
}
