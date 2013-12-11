using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using proyectoMantenimiento.Presentacion;
using dbMantenimientoBiz;

namespace proyectoMantenimiento
{
    public partial class Form1 : Form
    {
        public static Usuario user;
        public Form1()
        {
            InitializeComponent();
            user = PInicioSesion.user;
            habilitar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            String s = "";
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            PGestorUsuario pUsuario = new PGestorUsuario();
            pUsuario.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PProceso pProc = new PProceso();
            pProc.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PMantenimiento pMant = new PMantenimiento();
            pMant.Visible = true;
            //pMant.SetBounds(0, 0, 600, 500);
            //if (pMant.Modal == true)
            //{
            //    pMant.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //    pMant.TopLevel = false;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FConfig fc = new FConfig();
            fc.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PInventario pantalla_inventario = new PInventario();
            pantalla_inventario.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PSolicitudes fsol = new PSolicitudes();
            fsol.Visible = true;
        }

        public void habilitar()
        {
            try
            {
                privilegioCollection pc = user.rol.privilegios;
                foreach (privilegio p in pc)
                {

                    switch ((int)p.idfuncion)
                    {
                        case 1:
                            btnConfig.Enabled = true;
                            break;
                        case 2:
                            btnAcceso.Enabled = true;
                            break;
                        case 3:
                            btnMaq.Enabled = true;
                            break;
                        case 4:
                            btnInv.Enabled = true;
                            break;
                        case 5:
                            btnPermisos.Enabled = true;
                            break;
                        case 6:
                            btnMante.Enabled = true;
                            break;
                        case 7:
                            btnReportes.Enabled = true;
                            break;

                        default:
                            break;
                    }
                }
            }
            catch
            {

            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            PReporte prep = new PReporte();
            prep.Visible = true;
        }
    }
}
