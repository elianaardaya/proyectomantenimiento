using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using proyectoMantenimiento.Negocio;
using Microsoft.VisualBasic;
using dbMantenimientoBiz;
namespace proyectoMantenimiento.Presentacion
{
    public partial class PGestorUsuario : Form
    {
        NRol negocioR;
        NUsuario negocioU;
        List<funcion> privilegios;
        int idrol;
        public PGestorUsuario()
        {
            InitializeComponent();
            negocioR = new NRol();
            negocioU = new NUsuario();
            cargarTabla();
            cargarCombo();
            privilegios = new List<funcion>();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarRol_Click(object sender, EventArgs e)
        {
            cargar_privilegios();
            if (verificarDatos())
            {
                if (idrol == 0)
                {
                    negocioR.insertar(edtNombreRol.Text, privilegios);
                    MessageBox.Show("DATOS REGISTRADOS CORRECTAMENTE!!!");
                    limpiar();
                }
                else
                {
                    negocioR.modificar(idrol, edtNombreRol.Text, privilegios);
                    MessageBox.Show("DATOS REGISTRADOS CORRECTAMENTE!!!");
                    limpiar();
                }
                cargarTabla();
                idrol = 0;
                bloquearRol();
            }
            else
            {
                MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
            }
            

        }

        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            //String id_busqueda = Interaction.InputBox("NOMBRE DE ROL:", "BUSQUEDA", "");
            //if (id_busqueda.Length != 0)
            //{
            //    rol nRol = negocioR.buscar(id_busqueda);
            //    if (nRol == null || nRol.estado==false)
            //    {
            //        MessageBox.Show("NO EXISTE REGISTRO CON ESE NOMBRE.");
            //    }
            //    else
            //    {
            //        edtNombreRol.Text = nRol.nombre;
            //        listAsignado.DataSource = nRol.privilegios;
            //        Console.Write(nRol.privilegios.Count);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("DEBE INGRESAR UN NOMBRE PARA INICIAR LA BUSQUEDA");
            //}
            bloquearRol();
            limpiar();

            idrol = 0;
        }

        public bool verificarDatos(){
            if(edtNombreRol.Text!="" ){
                return true;
            }else{
                return false;
            }
        }

        public void limpiar()
        {
            edtNombreRol.Text = "";

            limpiarchbox();

        }

        public void cargarTabla()
        {
            rolCollection rc = negocioR.Listar();
            if(rc.Count==0){
                dgvRol.Enabled = false;

            }
            dgvRol.DataSource = rc;
        }


        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            
            if (idrol != 0)
            {
                rol nRol = negocioR.buscar2(idrol);
                if (nRol == null && nRol.estado == false)
                {
                    MessageBox.Show("NO EXISTE REGISTRO CON ESE NOMBRE.");
                }
                else
                {
                    if (MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO?", "CONFIRMAR ACCION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        negocioR.eliminar2(idrol);
                        MessageBox.Show("SE COMPLETO LA ACCION CORRECTAMENTE");
                    }
                    bloquearRol();
                    cargarTabla();

                    limpiar();
                }
            }
           
        }

        private void edtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatosU())
            {
                rol rb = (rol)cbxRol.SelectedItem;
                rol rolS = negocioR.buscar(rb.nombre);
                negocioU.insertar(edtNombre.Text,edtPass.Text,rb.id);
                MessageBox.Show("DATOS REGISTRADOS CORRECTAMENTE!!!");
                limpiarCamposU();
            }
            else
            {
                MessageBox.Show("DEBE INTRODUCIR LOS DATOS CORRECTAMENTE");
            }


        }

        public bool validarDatosU(){
            if(edtNombre.Text!="" && edtPass.Text!="" && cbxRol.SelectedItem!=null){
                return true;
            }
            else { return false; }
            
            
        }

        public void habilitarRol(){
            edtNombreRol.Enabled = true;
            btnBuscarRol.Enabled = true;
            btnNR.Enabled = false;
            btnMR.Enabled = false;
            btnEliminarRol.Enabled = false;
            dgvRol.Enabled = false;
            btnGuardarRol.Enabled = true;
            
        }
        public void bloquearRol()
        {
            edtNombreRol.Enabled = false;
            btnBuscarRol.Enabled = true;
            btnNR.Enabled = true;
            btnMR.Enabled = false;
            btnEliminarRol.Enabled = false;
            dgvRol.Enabled = true;
            btnEliminarRol.Enabled = false;
        }


        public void limpiarCamposU()
        {
            edtPass.Text = "";
            edtNombre.Text = "";
            cbxRol.SelectedItem = null;
        }

        private void PGestorUsuario_Load(object sender, EventArgs e)
        {

        }

        private void cargarCombo()
        {
          //  List<rol> lista= negocioR.Listar();
          //foreach(rol r in lista){
          //    cbxRol.Items.Add(r);

          //}
            cbxRol.DataSource = negocioR.Listar();
        }

        private void tabUsuario_Click(object sender, EventArgs e)
        {

        }

        private void edtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String id_busqueda = Interaction.InputBox("NOMBRE DE USUARIO:", "BUSQUEDA", "");
            if (id_busqueda.Length != 0)
            {
                Usuario nUser = negocioU.buscar(id_busqueda);
                if (nUser == null || nUser.estado == false)
                {
                    MessageBox.Show("NO EXISTE REGISTRO CON ESE NOMBRE.");
                }
                else
                {
                    edtNombre.Text = nUser.usuario;
                    edtPass.Text = nUser.password;
                    rolCollection rc= negocioR.Listar();
                    int c=0;
                    foreach(rol r in rc){
                        if (r.id == nUser.rol.id)
                        {
                           break;
                        }
                        c++;
                    }
                    cbxRol.SelectedIndex=c;
                   
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE PARA INICIAR LA BUSQUEDA");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String id_busqueda = Interaction.InputBox("NOMBRE DE USUARIO:", "BUSQUEDA", "");
            if (id_busqueda.Length != 0)
            {
                Usuario nUser = negocioU.buscar(id_busqueda);
                if (nUser == null && nUser.estado == false)
                {
                    MessageBox.Show("NO EXISTE REGISTRO CON ESE NOMBRE.");
                }
                else
                {
                    if (MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO?", "CONFIRMAR ACCION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        negocioU.eliminar(id_busqueda);
                        MessageBox.Show("SE COMPLETO LA ACCION CORRECTAMENTE");
                    }
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE PARA INICIAR LA BUSQUEDA");
            }
        }

        private void btnNR_Click(object sender, EventArgs e)
        {
            idrol = 0;
            habilitarRol();

        }


        private void cargar_privilegios()
        {
            List<funcion>lf= negocioR.Listarfuncion();
            privilegios.Clear();
            if(chbxConfig.Checked){
                //privilegio p = new privilegio();
                //p.id = 0;
                privilegios.Add(lf[0]);
            }
            if(chbxGA.Checked){
                //privilegio p = new privilegio();
                //p.id = 1;
                privilegios.Add(lf[1]);
            }
             if(chbxGI.Checked){
                 //privilegio p = new privilegio();
                 //p.id = 3;
                 privilegios.Add(lf[3]);
            }
            if(chbxGM.Checked){
                //privilegio p = new privilegio();
                //p.id = 2;
                privilegios.Add(lf[2]);
            }
            if (chbxGP.Checked)
            {
                //privilegio p = new privilegio();
                //p.id = 4;
                privilegios.Add(lf[4]);
            }
             if (chbxRM.Checked)
             {
                 //privilegio p = new privilegio();
                 //p.id = 5;
                 privilegios.Add(lf[5]);
            }
             if (chbxReportes.Checked)
             {
                 //privilegio p = new privilegio();
                 //p.id = 6;
                 privilegios.Add(lf[6]);
             }
        }


        public void cargarchbox(List<privilegio> lp){

            foreach (privilegio o in lp)
            {
                switch ((int)o.idfuncion)
                {
                    case 1:
                        chbxConfig.Checked = true;
                        break;
                    case 2:
                        chbxGA.Checked = true;
                        break;
                    case 3:
                        chbxGM.Checked = true;
                        break;
                    case 4:
                        chbxGI.Checked = true;
                        break;
                    case 5:
                        chbxGP.Checked = true;
                        break;
                    case 6:
                        chbxRM.Checked = true;
                        break;
                    case 7:
                        chbxReportes.Checked = true;
                        break;
                    default:
                        break;
                }
            }

        }



        public void limpiarchbox()
        {
            
                        chbxConfig.Checked = false;

                        chbxGA.Checked = false;

                        chbxGM.Checked = false;

                        chbxGI.Checked = false;

                        chbxGP.Checked = false;

                        chbxRM.Checked = false;

                        chbxReportes.Checked = false;
                        
        }

        private void tabRol_Enter(object sender, EventArgs e)
        {
            bloquearRol();
            cargarTabla();
        }

        private void dgvRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idrol = (int)dgvRol.CurrentRow.Cells[0].Value;
            rol rb = negocioR.buscar2(idrol);
            btnEliminarRol.Enabled = true;
            btnMR.Enabled = true;
            edtNombreRol.Text = rb.nombre;
            limpiarchbox();
            cargarchbox(rb.privilegios.Cast<privilegio>().ToList());
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            if(idrol!=0){

                habilitarRol();

            }
        }
    }
}
