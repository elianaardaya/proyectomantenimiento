using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using proyectoMantenimiento.Negocio;
using System.Drawing.Imaging;
using System.IO;
using dbMantenimientoBiz;
namespace proyectoMantenimiento.Presentacion
{
    public partial class FConfig : Form
    {
        public FConfig()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbWin_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void rbWin_CheckedChanged(object sender, EventArgs e)
        {
            edtUser.Enabled = !edtUser.Enabled;
            edtPass.Enabled = !edtPass.Enabled;
        }

        private void FConfig_Load(object sender, EventArgs e)
        {
            string tipo = ConfigurationManager.AppSettings["tipo_conexion"];
            if(tipo.Equals("w")){
                rbWin.Checked = true;
                edtNombredb.Text = ConfigurationManager.AppSettings["nombre_db"];
                edtServer.Text = ConfigurationManager.AppSettings["nombre_server"];
                edtIp.Text = ConfigurationManager.AppSettings["ip"];
            }
            else{
                rbsql.Checked = true;
                edtNombredb.Text = ConfigurationManager.AppSettings["nombre_db"];
                edtServer.Text = ConfigurationManager.AppSettings["nombre_server"];
                edtIp.Text = ConfigurationManager.AppSettings["ip"];
                edtUser.Text = ConfigurationManager.AppSettings["usuario"];
                edtPass.Text = ConfigurationManager.AppSettings["pass"];
            }
            string miValor2 = ConfigurationManager.AppSettings["usuario"];
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            String nombre_db = edtNombredb.Text;
            string nombre_server = edtServer.Text;
            string cadConexion;
            if(rbWin.Checked){
                cadConexion = "Data Source=" + nombre_server + ";Initial Catalog="+nombre_db+";Integrated Security=True";
                config.AppSettings.Settings["tipo_conexion"].Value = "w";
            }else{
                string nombre_user= edtUser.Text;
                string pass= edtPass.Text;
                 cadConexion="Data Source="+nombre_server+";Initial Catalog="+nombre_db+";User ID="+nombre_user+";Password="+pass;
                 config.AppSettings.Settings["usuario"].Value = nombre_user;
                 config.AppSettings.Settings["pass"].Value = pass;
                 config.AppSettings.Settings["tipo_conexion"].Value = "s";
            }
            config.AppSettings.Settings["nombre_db"].Value = nombre_db;
            config.AppSettings.Settings["nombre_server"].Value = nombre_server;
            config.AppSettings.Settings["cadena_conexion"].Value = cadConexion;
            config.AppSettings.Settings["ip"].Value = edtIp.Text;
            config.Save();
            MessageBox.Show("CONFIGURACION ALMACENADA CORRECTAMENTE");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "JPEG|*.jpg";
            BuscarImagen.ShowDialog();
            if (!string.IsNullOrEmpty(BuscarImagen.FileName))
            {
                if (File.Exists(BuscarImagen.FileName))
                {
                    Image Imagen = Image.FromFile(BuscarImagen.FileName);
                    pictureBox1.Image = Imagen;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    

                  
                }
            }
                
               


            


        }

        #region Convertir Imagen

        ///De image a byte []:
        public byte[] ImageAArray(Image Imagen)
        {
            MemoryStream ms = new MemoryStream();
            Imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        ///De byte [] a image:
        public Image ArrayAImage(byte[] ArrBite)
        {
            MemoryStream ms = new MemoryStream(ArrBite);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        #endregion

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarE_Click(object sender, EventArgs e)
        {
            if(validar()){
                NEmpresa negocio = new NEmpresa();
                negocio.insertar(edtNombreE.Text, edtRubroE.Text, edtDirE.Text, edtTelefonoE.Text, ImageAArray(pictureBox1.Image));
                MessageBox.Show("DATOS REGISTRADOS CORRECTAMENTE!!!");
            }else{
                MessageBox.Show("DEBE LLENAR TODOS LOS DATOS !!!");
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool validar()
        {
            if (!edtDirE.Text.Equals("") && !edtNombreE.Text.Equals("") && !edtRubroE.Text.Equals("") && !edtTelefonoE.Text.Equals("") && pictureBox1.Image!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            NEmpresa negocio = new NEmpresa();
            empresa ee = negocio.recuperar();
            if (ee != null)
            {
                edtNombreE.Text = ee.nombre;
                edtRubroE.Text = ee.rubro;
                edtDirE.Text = ee.direccion;
                edtTelefonoE.Text = ee.telefono;
                pictureBox1.Image = ArrayAImage(ee.imagen.Value);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string tipo = ConfigurationManager.AppSettings["tipo_conexion"];
            if (tipo.Equals("w"))
            {
                rbWin.Checked = true;
                edtNombredb.Text = ConfigurationManager.AppSettings["nombre_db"];
                edtServer.Text = ConfigurationManager.AppSettings["nombre_server"];
                edtIp.Text = ConfigurationManager.AppSettings["ip"];
            }
            else
            {
                rbsql.Checked = true;
                edtNombredb.Text = ConfigurationManager.AppSettings["nombre_db"];
                edtServer.Text = ConfigurationManager.AppSettings["nombre_server"];
                edtIp.Text = ConfigurationManager.AppSettings["ip"];
                edtUser.Text = ConfigurationManager.AppSettings["usuario"];
                edtPass.Text = ConfigurationManager.AppSettings["pass"];
            }
            string miValor2 = ConfigurationManager.AppSettings["usuario"];
        }
    }
}
