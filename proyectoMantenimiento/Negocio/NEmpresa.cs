using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimientoBiz;
using System.Configuration;
namespace proyectoMantenimiento.Negocio
{
    class NEmpresa
    {
        DataManager dm;
        
        public NEmpresa()
        {
            dm = new DataManager(ConfigurationManager.AppSettings["cadena_conexion"]);
        }

        public void insertar(string nombre,string rubro,string dir,string telefono,byte[] imagen)
        {
            empresaCollection ec = dm.GetempresaCollection();
            if(ec.Count!=0){
                empresa e = ec.FindByid(1);
                e.nombre = nombre;
                e.rubro = rubro;
                e.direccion = dir;
                e.telefono=telefono;
                e.imagen=imagen;
                dm.CommitAll();
            }else{
                dm.Newempresa(1, nombre, rubro, dir, telefono, imagen);
                dm.CommitAll();
            }
            
        }

        public empresa recuperar()
        {   empresaCollection ec= dm.GetempresaCollection();
        empresa e = ec.FindByid(1);
        return e;
        }
    }
}
