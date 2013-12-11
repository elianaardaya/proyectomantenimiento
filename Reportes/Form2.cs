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
    public partial class Form2 : Form
    {
        String cad;
        public Form2(String cadena)
        {
            InitializeComponent();
            cad = cadena;
        }

        public Form2()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            poblardb();
        }

        public void poblardb()
        {
            String sqlProveedor = "Select * from proveedor";
            
            dsPrueba dset = new dsPrueba();
            try
            {
                SqlConnection con = new SqlConnection(cad);
                SqlDataAdapter SqlDproveedor = new SqlDataAdapter(sqlProveedor, con);
                
                SqlDproveedor.Fill(dset,"proveedor");
               
                ReporteProveedor ret = new ReporteProveedor();
                ret.SetDataSource(dset);
                crystalReportViewer1.ReportSource = ret;
            }
            catch
            {

            }
        }
    }
}
