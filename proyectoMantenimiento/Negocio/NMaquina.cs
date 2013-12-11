using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimientoBiz;
using System.Configuration;
namespace proyectoMantenimiento.Negocio
{
    class NMaquina
    {
        DataManager dm;
        maquinaCollection mc;
        
        public NMaquina()
        {
            dm = new DataManager(ConfigurationManager.AppSettings["cadena_conexion"]);
        }

        public void insertar(string cod, string nombre, string marca,int id_linea,int anho,string funcion,string caracteristicas,string industria,string estado)
        {
            mc = dm.GetmaquinaCollection();
             
            
           
            dm.Newmaquina(cod, nombre, marca, anho, industria, funcion, caracteristicas, id_linea, estado, true);
            dm.CommitAll();
        }

        public void modificar(string cod,string cond_n, string nombre, string marca, int id_linea, int anho, string funcion, string caracteristicas, string industria, string estado)
        {
            mc = dm.GetmaquinaCollection();
            maquina m = mc.FindByid(cod);
            m.nombre = nombre;
            m.marca = marca;
            m.idlinea = id_linea;
            m.anho = anho;
            m.funcion = funcion;
            m.caracteristicas = caracteristicas;
            m.industria = industria;
            m.id = cond_n;
            dm.CommitAll();
        }

        public void eliminar(string cod)
        {
            mc = dm.GetmaquinaCollection();
            maquina m = mc.FindByid(cod);
            m.estado2 = false;
            dm.CommitAll();
        }

        public List<maquina> listar()
        {
            mc = dm.GetmaquinaCollection().FilterByestado2(true);
            List<maquina> lm = mc.Cast<maquina>().ToList();
            return lm;
        }

        public List<maquina> listar2()
        {
            mc = dm.GetmaquinaCollection();
            List<maquina> lm = mc.Cast<maquina>().ToList();
            return lm;
        }

        public maquinaCollection listarM()
        {
            mc = dm.GetmaquinaCollection().FilterByestado2(true);
         
            return mc;
        }
        public maquina buscar(string cod)
        {
            mc = dm.GetmaquinaCollection();
            maquina m = mc.FindByid(cod);
            return m;
        }
    }
}
