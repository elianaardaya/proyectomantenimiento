using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimientoBiz;
using System.Configuration;
using System.Windows.Forms;

namespace proyectoMantenimiento.Negocio
{
    class NInventario
    {
        DataManager dm;
        private proveedorCollection pc;
        private componenteCollection cc;
        private material_herramientaCollection mhc;
        private inventarioCollection ic;
        public NInventario()
        {
            dm = new DataManager(ConfigurationManager.AppSettings["cadena_conexion"]);
            pc = new proveedorCollection();
            cc = new componenteCollection();
            mhc = new material_herramientaCollection();
        }

        public void insertar_proveedor(string emp, string contac,string dir, string telf)
        {
            pc = dm.GetproveedorCollection();
            List<proveedor> lp = pc.Cast<proveedor>().ToList();
            int id;
            if (lp.Count == 0)
            {
                id = 1;
            }
            else { id = lp.Last().id + 1; }
            dm.Newproveedor(id, emp, contac, dir, telf,true);
            dm.CommitAll();
        }

        public void modificar_proveedor(int id,string emp, string contac, string dir, string telf)

        {
            pc = dm.GetproveedorCollection();
            proveedor p = pc.FindByid(id);
            p.empresa = emp;
            p.contacto = contac;
            p.direccion = dir;
            p.telefono = telf;
            dm.CommitAll();
        }

        public void eliminar_proveedor(int id)
        {
            pc = dm.GetproveedorCollection();
            proveedor p = pc.FindByid(id);
            p.estado = false;
            dm.CommitAll();
        }

        public void insertar_material(string nom,string marca,int id_prov,double valor)
        {
            mhc = dm.Getmaterial_herramientaCollection();
            List<material_herramienta> lp = mhc.Cast<material_herramienta>().ToList();
            int id;
            if (lp.Count == 0)
            {
                id = 1;
            }
            else { id = lp.Last().id + 1; }
            dm.Newmaterial_herramienta(id, nom, marca, id_prov, valor, true);
            dm.CommitAll();
        }

        public void modificar_material(int id,string nom, string marca, int id_prov, double valor)
        {
            mhc = dm.Getmaterial_herramientaCollection();
            material_herramienta m = mhc.FindByid(id);
            m.nombre = nom;
            m.marca = marca;
            m.idproveedor = id_prov;
            m.precio = valor;
            dm.CommitAll();
        }

        public void eliminar_material(int id)
        {
            mhc = dm.Getmaterial_herramientaCollection();
            mhc = dm.Getmaterial_herramientaCollection();
            material_herramienta m = mhc.FindByid(id);
            m.estado = false;
            dm.CommitAll();
        }

        public void insertar_componente(string id,string nombre, string marca,int id_prov)
        {
            cc = dm.GetcomponenteCollection();
            componente c = cc.FindByid(id);
            if(c==null){
                dm.Newcomponente(id, nombre, marca, id_prov, true);
                dm.CommitAll();
            }else{
                MessageBox.Show("YA EXISTE UN COMPONENTE CON CODIGO: "+ id);
            }
            

           

        }

        public void modificar_componente(string id, string nombre, string marca, int id_prov)
        {
            cc = dm.GetcomponenteCollection();
            componente c = cc.FindByid(id);
            c.nombre = nombre;
            c.marca = marca;
            c.idproveedor = id_prov;
            c.proveedor = buscar_p(id_prov);
            dm.CommitAll();
        }

        public void eliminar_componente(string id)
        {
            cc = dm.GetcomponenteCollection();
            componente c = cc.FindByid(id);
            c.estado = false;
            dm.CommitAll();
        }

        public void insertar_item(int id_material, int cantidad)
        {
            if (ic.FindByidmaterial(id_material) == null)
            {
                ic = dm.GetinventarioCollection();
                List<inventario> lp = ic.Cast<inventario>().ToList();
                int id;
                if (lp.Count == 0)
                {
                    id = 1;
                }
                else { id = lp.Last().id + 1; }
                mhc = dm.Getmaterial_herramientaCollection();

                dm.Newinventario(id, id_material, cantidad, mhc.FindByid(id_material));
                dm.CommitAll();
            }
            else
            {
                inventario inv = ic.FindByidmaterial(id_material);
                inv.cantidad = cantidad;
                dm.CommitAll();
            }
            
            
        }

        public void modificar_item(int id,int id_material, int cantidad)
        {
            ic = dm.GetinventarioCollection();
            inventario i = ic.FindByidmaterial(id);
            i.idmaterial = id_material;
            i.cantidad = cantidad;
            dm.CommitAll();
        }

        public void eliminar_item(int id)
        {
            ic = dm.GetinventarioCollection();
            inventario i = ic.FindByidmaterial(id);
            i.Delete();
            dm.CommitAll();
        }

        public inventario buscar_item(int id_material)
        {
            ic = dm.GetinventarioCollection();
            inventario i = ic.FindByidmaterial(id_material);
            return i;
        }

        public inventarioCollection listar()
        {
            dm.Getmaterial_herramientaCollection();
            ic = dm.GetinventarioCollection();
            return ic;
        }

        public List<material_herramienta> lista_mat()
        {
            mhc = dm.Getmaterial_herramientaCollection().FilterByestado(true);
            List<material_herramienta> lp = mhc.Cast<material_herramienta>().ToList();
            return lp;
        }

        public List<componente> lista_comp()
        {
            cc = dm.GetcomponenteCollection().FilterByestado(true);
            List<componente> lp = cc.Cast<componente>().ToList();
            return lp;
        }

        public proveedorCollection lista_prov()
        {
            return dm.GetproveedorCollection().FilterByestado(true);

        }

        public material_herramientaCollection lista_material()
        {
            return dm.Getmaterial_herramientaCollection().FilterByestado(true);
        }

        public componenteCollection lista_componente()
        {
            return dm.GetcomponenteCollection().FilterByestado(true);
        }

        public proveedorCollection lista_prov2()
        {
            return dm.GetproveedorCollection();

        }

        public material_herramientaCollection lista_material2()
        {
            return dm.Getmaterial_herramientaCollection();
        }

        public componenteCollection lista_componente2()
        {
            return dm.GetcomponenteCollection();
        }
        public proveedor buscar_p(int id){
            pc = dm.GetproveedorCollection();
            return pc.FindByid(id);
        }

         public material_herramienta buscar_m(int id){
             mhc = dm.Getmaterial_herramientaCollection();
             return mhc.FindByid(id);
        }

         public componente buscar_c(string id){
             cc = dm.GetcomponenteCollection();
             return cc.FindByid(id);
        }
    }
}
