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
    public partial class FListaMaterial : Form
    {
        NMantenimiento negocio;
        int idrep;
        NInventario negocioI;
        public FListaMaterial(int id)
        {
            InitializeComponent();
            negocio = new NMantenimiento();
            idrep = id;
            negocioI = new NInventario();
          
            List<inventario>lm= negocioI.listar().Cast<inventario>().ToList();
            foreach(inventario i in lm){
                cbxLista.Items.Add(i.material_herramienta);
            
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cbxLista.SelectedIndex==-1 || nudCantidad.Value==0){

                MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS PARA CONTINUAR.");
            }else{
                material_herramienta m= (material_herramienta)cbxLista.SelectedItem;
                negocio.insertar_detalle_mat(m.id, idrep, Convert.ToInt32(nudCantidad.Value));
                Close();

            }
        }
    }
}
