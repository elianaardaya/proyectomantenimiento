using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimientoBiz;
using System.Configuration;
namespace proyectoMantenimiento.Negocio
{
    class NLineaP
    {
        private DataManager dm;
        private linea_produccionCollection lc;
        private maquinaCollection mc;
        public NLineaP()
        {
            dm = new DataManager(ConfigurationManager.AppSettings["cadena_conexion"]);
        }

        public void insertar(string nombre, string descrip)

        {
            lc = dm.Getlinea_produccionCollection();
            List<linea_produccion> llc = lc.Cast<linea_produccion>().ToList();
            int id;
            if (llc.Count == 0)
            {
                id = 1;
            }
            else { id = llc.Last().id + 1; }
            linea_produccion linea = dm.Newlinea_produccion(id, nombre, descrip, true);
            dm.CommitAll();
        }

        public void modificar(int id, String nombre,string des)
        {
            lc = dm.Getlinea_produccionCollection();
            linea_produccion u = lc.FindByid(id);
            u.nombre = nombre;
            u.descripcion = des;
            dm.CommitAll();

        }

        public void eliminar(string nombre)
        {
           lc = dm.Getlinea_produccionCollection();
            linea_produccion u = lc.FindBynombre(nombre);
            u.estado = false;
            dm.CommitAll();
        }

        public linea_produccion buscar(int id)
        {
            lc = dm.Getlinea_produccionCollection();
            linea_produccion u = lc.FindByid(id);
            return u;
        }

        public linea_produccionCollection listar()
        {
            lc = dm.Getlinea_produccionCollection().FilterByestado(true);
            
            return lc;
        }
        public List<linea_produccion> listar2()
        {
            lc = dm.Getlinea_produccionCollection().FilterByestado(true);
            List<linea_produccion> llc = lc.Cast<linea_produccion>().ToList();
            return llc;
        }
       
    }
}
