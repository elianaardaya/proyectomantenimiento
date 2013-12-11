using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimientoBiz;
using System.Configuration;
using System.Windows.Forms;
using proyectoMantenimiento.Presentacion;
using System.Data.SqlClient;

namespace proyectoMantenimiento.Negocio
{
   
    class NUsuario
    {
        private DataManager dm;

        public DataManager Dm
        {
            get { return dm; }
            set { dm = value; }
        }
        private UsuarioCollection uc;
        public NUsuario()
        {
            //try
            //{
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            dm = new DataManager(config.AppSettings.Settings["cadena_conexion"].Value);
                
                string cad = ConfigurationManager.AppSettings["cadena_conexion"];
                //SqlConnection sqlCon = new SqlConnection(ConfigurationManager.AppSettings["cadena_conexion"]);
                //sqlCon.Open();

                //if (cad == null)
                //{
                    


                //}
                //else
                //{
                    uc = dm.GetUsuarioCollection();

                //}


            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("ERROR AL ESTABLECER CONEXION CON EL SERVIDOR");
            //}
            
            
        }


        public void insertar(String nombre, String pass,int id_rol )
        {
            uc = dm.GetUsuarioCollection();
            List<Usuario> lu = uc.Cast<Usuario>().ToList();
            int id;
            if (lu.Count == 0)
            {
                id = 1;
            }
            else { id = lu.Last().id + 1; }
            rolCollection rc = dm.GetrolCollection();
            rol r = rc.FindByid(id_rol);
            dm.NewUsuario(id,nombre,pass,r.id,true,r);
          
            dm.CommitAll();

        }

        public void modificar( int id,String nombre, String pass, rol id_rol)
        {
            uc = dm.GetUsuarioCollection();
            Usuario u = uc.FindByid(id);
            u.usuario = nombre;
            u.password = pass;
            u.rol = id_rol;
            dm.CommitAll();
        }

        public void eliminar(string id)
        {
            uc = dm.GetUsuarioCollection();
            Usuario u = uc.FindByusuario(id);
            u.estado = false;
            dm.CommitAll();
        }

        public Usuario buscar(String id)
        {
            
            dm.GetprivilegioCollection();
            dm.GetrolCollection();
            rolCollection rc = dm.GetrolCollection();
            uc = dm.GetUsuarioCollection();
            Usuario u = uc.FindByusuario(id);
        return u;
        }



    }
}
