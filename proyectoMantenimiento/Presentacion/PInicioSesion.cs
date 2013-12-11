using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using proyectoMantenimiento.Negocio;
using dbMantenimientoBiz;

namespace proyectoMantenimiento.Presentacion
{
    public partial class PInicioSesion : Form
    {
        private NUsuario negocio;
        public static Usuario user;
        public PInicioSesion()
        {
            InitializeComponent();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    negocio = new NUsuario();


                    Usuario u = negocio.buscar(edtNombre.Text);
                    if (u != null && u.password.Equals(edtPass.Text) && u.estado == true)
                    {
                        user = u;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTAS.");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR AL ESTABLECER CONEXION CON EL SERVIDOR");
                    FConfig fc = new FConfig();
                    fc.ShowDialog(this);
                }
                    
                
               
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR TODOS LOS DATOS NECESARIOS");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        public bool validarCampos()
        {
            if(edtNombre.Text!="" && edtPass.Text!=""){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
