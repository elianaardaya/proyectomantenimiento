using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimientoBiz;
using System.Configuration;

namespace proyectoMantenimiento.Negocio
{
    class NSolicitud
    {
        private DataManager dm;
        private solicitudCollection sc;
        public NSolicitud()
        {
            dm = new DataManager(ConfigurationManager.AppSettings["cadena_conexion"]);
           sc = dm.GetsolicitudCollection();
        }


        public void insertar(DateTime d, string obs,int id_u,string id_m,string tipo){
            sc = dm.GetsolicitudCollection();
            UsuarioCollection uc= dm.GetUsuarioCollection();
            Usuario u=uc.FindByid(id_u);

            maquinaCollection mc=dm.GetmaquinaCollection();
            maquina m=mc.FindByid(id_m);
            List<solicitud> ls = sc.Cast<solicitud>().ToList();
            int id;
            if (ls.Count == 0)
            {
                id = 1;
            }
            else { id = ls.Last().id + 1; }
            dm.Newsolicitud(id, id_u, d, obs, true, tipo, id_m,"PETICION");
            dm.CommitAll();
        }



        public solicitudCollection listar(int id)
        {
            dm.GetmaquinaCollection();
            sc = dm.GetsolicitudCollection().FilterByidusuario(id);
            return sc;

        }

        public solicitud obtener(int id)
        {
            sc = dm.GetsolicitudCollection();
            solicitud s = sc.FindByid(id);

            return s;

        }

        public bool aprobar(int id)
        {
            sc = dm.GetsolicitudCollection();
            solicitud s = sc.FindByid(id);
            s.estado_solicitud = "APROBADA";
            dm.CommitAll();
            return true;
        }

        public void pendiente(int id)
        {
            sc = dm.GetsolicitudCollection();
            solicitud s = sc.FindByid(id);
            s.estado_solicitud = "PENDIENTE";
            dm.CommitAll();
        }


        public void rechazar(int id)
        {
            sc = dm.GetsolicitudCollection();
            solicitud s = sc.FindByid(id);
            s.estado_solicitud = "RECHAZADA";
            dm.CommitAll();
        }

        public void cancelar(int id)
        {
            sc = dm.GetsolicitudCollection();
            solicitud s = sc.FindByid(id);
            s.estado_solicitud = "CANCELADA";
            dm.CommitAll();
        }

        public solicitudCollection listar2(string estado)
        {
            dm.GetmaquinaCollection();
            sc = dm.GetsolicitudCollection().FilterByestado_solicitud(estado);
            return sc;

        }
    }
}
