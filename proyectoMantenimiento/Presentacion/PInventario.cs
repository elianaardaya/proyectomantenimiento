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
    public partial class PInventario : Form
    {
        private int id_prov;
        private int id_material;
        private string id_comp;
        private int id_inv;
        private NInventario negocio;
        public PInventario()
        {
            InitializeComponent();
            negocio = new NInventario();
            cargar_combos();
            
        }

        private void PInventario_Load(object sender, EventArgs e)
        {
            cargar_proveedor();
            
            id_prov = 0;
            id_material = 0;
            id_comp = "";
            id_inv = 0;
            edtTelfP.Text = "";
            bloquearP();
        }

        public void limpiar_proveedor()
        {
            edtContactoP.Text = "";
            edtDirP.Text = "";
            edtNombreP.Text = "";
            edtTelfP.Text = "";
            id_prov = 0;
        }

        public void limpiarInv()
        {
            edtCantI.Text = "";
            cbxItem.SelectedIndex = -1;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            id_prov = 0;
            limpiar_proveedor();
            bloquearP();
        }

       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(validarProv()){
                if (id_prov != 0)
                {
                    negocio.modificar_proveedor(id_prov, edtNombreP.Text, edtContactoP.Text, edtDirP.Text, edtTelfP.Text);
                }
                else
                {
                    negocio.insertar_proveedor(edtNombreP.Text, edtContactoP.Text, edtDirP.Text, edtTelfP.Text);
                }

                cargar_proveedor();
                limpiar_proveedor();
                bloquearP();
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("CLic en tab"+ tabControl1.SelectedTab.Name);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(id_prov!=0){
                negocio.eliminar_proveedor(id_prov);
                cargar_proveedor();
                limpiar_proveedor();
                bloquearP();
            }
            
            
            
        }

        private void dgvProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvProv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_prov = (int)dgvProv.CurrentRow.Cells[0].Value;
            proveedor p = negocio.buscar_p(id_prov);
            edtNombreP.Text = p.empresa;
            edtContactoP.Text = p.contacto;
            edtDirP.Text = p.direccion;
            edtTelfP.Text = p.telefono;
            btnModP.Enabled = true; btnEliminar.Enabled = true;
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            if(validarMat()){
                proveedor p = (proveedor)cbxProv1.SelectedItem;
                if (id_material != 0)
                {

                    negocio.modificar_material(id_material, edtNombreM.Text, edtMarcaM.Text, p.id, Convert.ToDouble(edtPrecioM.Text));
                }
                else
                {
                    negocio.insertar_material(edtNombreM.Text, edtMarcaM.Text, p.id, Convert.ToDouble(edtPrecioM.Text));
                }
                limpiar_material();
                cargar_material();
                bloquearM();
            }
            

        }

        public void limpiar_material()
        {
            id_material = 0;
            edtMarcaM.Text = "";
            edtNombreM.Text = "";
            edtPrecioM.Text = "";
            cbxProv1.SelectedIndex=-1;
        }

        
        public void cargar_combos()
        {
            List<proveedor> lp = negocio.lista_prov().Cast<proveedor>().ToList();
            cbxProv1.Items.Clear(); cbxProv2.Items.Clear();
            foreach(proveedor p in lp){
                cbxProv1.Items.Add(p);
                cbxProv2.Items.Add(p);
            }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            cargar_combos();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            if(validarComp()){
                proveedor p = (proveedor)cbxProv2.SelectedItem;
                if (id_comp != "")
                {

                    negocio.modificar_componente(id_comp, edtNombreC.Text, edtMarcaC.Text, p.id);
                }
                else
                {
                    negocio.insertar_componente(edtCodC.Text, edtNombreC.Text, edtMarcaC.Text, p.id);
                }

                limpiar_comp();
                bloquearC();
                cargar_comp();
            }
            
        }

        public void limpiar_comp(){
            edtMarcaC.Text = "";
            edtNombreC.Text = "";
            edtCodC.Text = "";
            cbxProv2.SelectedItem = null;
        }
        public void cargar_comp()
        {

            dgvComp.DataSource = negocio.lista_componente();
            dgvComp.Columns["idproveedor"].Visible = false;
            dgvComp.Columns["estado"].Visible = false;
            dgvComp.Columns[0].HeaderText = "CODIGO";
            dgvComp.Columns[1].HeaderText = "NOMBRE";
            dgvComp.Columns[2].HeaderText = "MARCA";
            dgvComp.Columns[5].HeaderText = "PROVEEDOR";
            dgvComp.Columns["id"].Width = 70;
        }

        public void cargar_material()
        {

            material_herramientaCollection mc = negocio.lista_material();
            dgvMat.DataSource = mc;
            if(mc.Count==0){
                dgvMat.Enabled = false;
            }
            dgvMat.Columns["id"].Visible = false;
            dgvMat.Columns["estado"].Visible = false;
            dgvMat.Columns["idproveedor"].Visible = false;
            dgvMat.Columns[1].HeaderText = "NOMBRE";
            dgvMat.Columns[2].HeaderText = "MARCA";
            dgvMat.Columns[4].HeaderText = "PRECIO";
            dgvMat.Columns[6].HeaderText = "PROVEEDOR";
            dgvMat.Columns["nombre"].Width = 150;
            dgvMat.Columns["precio"].Width = 50;
        }

        private void cargar_proveedor()
        {
            proveedorCollection pc = negocio.lista_prov();
            dgvProv.DataSource = pc;
            if(pc.Count==0){
                dgvProv.Enabled = false;
            }
            dgvProv.Columns["id"].Visible = false;
            dgvProv.Columns["estado"].Visible = false;
            dgvProv.Columns[1].HeaderText = "EMPRESA";
            dgvProv.Columns[2].HeaderText = "CONTACTO";
            dgvProv.Columns[3].HeaderText = "DIRECCION";
            dgvProv.Columns[4].HeaderText = "TELEFONO";
            dgvProv.Columns["empresa"].Width = 190;
            dgvProv.Columns["telefono"].Width =70;

        }

        public void cargar_inventario()
        {
            inventarioCollection ic = negocio.listar();
            dgvInv.DataSource = ic;
            if(ic.Count==0){
                dgvInv.Enabled = false;
            }

            dgvInv.Columns["id"].Visible = false;
            dgvInv.Columns["idmaterial"].Visible = false;
            dgvInv.Columns["material_herramienta"].DisplayIndex = 0;
            dgvInv.Columns["cantidad"].DisplayIndex = 1;
            dgvInv.Columns[3].HeaderText = "MATERIAL";
            dgvInv.Columns[2].HeaderText = "CANTIDAD";
            dgvInv.Columns["material_herramienta"].Width = 190;
        }

        public void cargar_combo_inv()
        {
            List<material_herramienta> l = negocio.lista_mat();
            cbxItem.Items.Clear();
            foreach(material_herramienta m in l ){
                cbxItem.Items.Add(m);

            }
        }

        private void btnNP_Click(object sender, EventArgs e)
        {
            habilitarP();
            limpiar_proveedor();
            btnModP.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            id_prov = 0;
        }


        private void bloquearP(){
            edtNombreP.Enabled = false;
            edtContactoP.Enabled = false;
            edtTelfP.Enabled = false;
            edtDirP.Enabled = false;
            btnGuardar.Enabled = false; btnEliminar.Enabled = false; btnModP.Enabled = false;
            dgvProv.Enabled = true; btnNP.Enabled = true;
        }

        private void bloquearC()
        {
            edtNombreC.Enabled = false;
            edtCodC.Enabled = false;
            edtMarcaC.Enabled = false;
            cbxProv2.Enabled = false;
            dgvComp.Enabled = true;
            btnElimC.Enabled = false;
            btnModC.Enabled = false;
            btnNC.Enabled = true;
            btnAddC.Enabled = false;
        }
        private void habilitarC()
        {
            edtNombreC.Enabled = true;
            edtCodC.Enabled = true;
            edtMarcaC.Enabled = true;
            cbxProv2.Enabled = true;
            dgvComp.Enabled = false;
            btnAddC.Enabled = true; btnModC.Enabled = false; btnElimC.Enabled = false;
            btnNC.Enabled = false;
        }
        private void habilitarP()
        {
            edtNombreP.Enabled = true;
            edtContactoP.Enabled = true;
            edtTelfP.Enabled = true;
            edtDirP.Enabled = true;
            btnGuardar.Enabled = true;
            dgvProv.Enabled = false;
        }

        private void habilitarM()
        {
            edtNombreM.Enabled = true;
            edtPrecioM.Enabled = true;
            edtMarcaM.Enabled = true;
            cbxProv1.Enabled = true;
            btnAddM.Enabled = true;
            dgvMat.Enabled = false; btnNM.Enabled = false; btnMM.Enabled = false; btnElimM.Enabled = false;
        }
        private void bloquearM()
        {
            edtNombreM.Enabled = false;
            edtPrecioM.Enabled = false;
            edtMarcaM.Enabled = false;
            cbxProv1.Enabled = false;
            btnAddM.Enabled = false; btnNM.Enabled = true; btnMM.Enabled = false;
            btnElimM.Enabled = false;
            dgvMat.Enabled=true;
        }

        public void bloquearInv()
        {
            edtCantI.Enabled = false;
            cbxItem.Enabled = false;
            btnGA.Enabled = false;
            btnMA.Enabled = false; btnNa.Enabled = true;
            btnDA.Enabled = false;
            dgvInv.Enabled = true;
        }

        public void habilitarInv()
        {
            edtCantI.Enabled = true;
            cbxItem.Enabled = true;
            btnGA.Enabled = true;
            btnMA.Enabled = false; btnNa.Enabled = false;
            btnDA.Enabled = false;
            dgvInv.Enabled = false;
        }
        private void btnModP_Click(object sender, EventArgs e)
        {
            habilitarP();
            btnEliminar.Enabled = false;
            btnNP.Enabled = false;
        }

        private void btnElimM_Click(object sender, EventArgs e)
        {
            if(id_material!=0){
                negocio.eliminar_material(id_material);
                limpiar_material();
                bloquearM();
                cargar_material();
            }
        }

        private bool validarInv()
        {
            if(edtCantI.Text!="" && cbxItem.SelectedIndex!=-1){
                return true;
            }else{
                MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
                return false;
            }
        }
        private bool validarMat()
        {
            if(edtNombreM.Text!="" && edtMarcaM.Text!="" && edtPrecioM.Text!="" && cbxProv1.SelectedIndex!=-1){
                return true;
            }else{
                MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
                return false;

            }
        }
        private bool validarProv()
        {
            if(edtNombreP.Text!="" && edtContactoP.Text!="" && edtTelfP.Text!="" && edtDirP.Text!=""){
                return true;
            }else{
                MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
                return false;

            }
        }
        private bool validarComp()
        {
            if(edtCodC.Text!="" && edtNombreC.Text!="" && edtMarcaC.Text!="" && cbxProv2.SelectedIndex!=-1){
                return true;
            }else{
                MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
                return false;
            }
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            bloquearC();
            cargar_combos();
            cargar_comp();
        }

        private void btnNC_Click(object sender, EventArgs e)
        {
            id_comp = "";
            habilitarC();
            limpiar_comp();
        }

        private void btnCanC_Click(object sender, EventArgs e)
        {
            id_comp = "";
            limpiar_comp();
            bloquearC();
        }

        private void dgvComp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            id_comp = (String)dgvComp.CurrentRow.Cells[0].Value;
            componente c = negocio.buscar_c(id_comp);
            edtNombreC.Text = c.nombre;
            edtMarcaC.Text = c.marca;
            edtCodC.Text = c.id;
           
            btnModC.Enabled = true;
            btnElimC.Enabled = true;
            proveedorCollection pc = negocio.lista_prov();
            int cc = 0;
            foreach (proveedor p in pc)
            {
                if (p.id == c.idproveedor)
                {
                    cbxProv2.SelectedIndex = cc;
                    return;
                }
                cc++;

            }
            MessageBox.Show("DEBE ACTUALIZAR EL CAMPO PROVEEDOR.");
            cbxProv1.SelectedIndex = -1;

        }

        private void btnModC_Click(object sender, EventArgs e)
        {
            if(id_comp!=""){
                habilitarC();
                btnElimC.Enabled = false;
                btnNC.Enabled = false;
            }
        }

        private void btnCanM_Click(object sender, EventArgs e)
        {
            id_material = 0;
            limpiar_material();
            bloquearM();
        }

        private void btnElimC_Click(object sender, EventArgs e)
        {
            negocio.eliminar_componente(id_comp);
            id_comp = "";
            bloquearC();
            limpiar_comp();
            cargar_comp();
        }

        private void btnNM_Click(object sender, EventArgs e)
        {
            id_material = 0;
            habilitarM();
            limpiar_material();


        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            habilitarM();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            bloquearM();
            cargar_material();
            cargar_combos();
        }

        private void dgvMat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnElimM.Enabled = true; btnMM.Enabled = true;
            id_material = (int)dgvMat.CurrentRow.Cells[0].Value;
            material_herramienta m= negocio.buscar_m(id_material);
            edtMarcaM.Text = m.marca;
            edtNombreM.Text = m.nombre;
            edtPrecioM.Text = Convert.ToString(m.precio);
            proveedorCollection pc = negocio.lista_prov();
            int c = 0;
            foreach(proveedor p in pc){
                if (p.id == m.proveedor.id && m.estado != false)
                {
                    cbxProv1.SelectedIndex = c;
                    return;
                }
                c++;
                
            }
            MessageBox.Show("DEBE ACTUALIZAR EL CAMPO PROVEEDOR.");
            cbxProv1.SelectedIndex = -1;

        }

        private void dgvMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            limpiarInv();
            habilitarInv();
            id_inv = 0;
        }

        private void btnGA_Click(object sender, EventArgs e)
        {
            if(validarInv()){
                material_herramienta m= (material_herramienta)cbxItem.SelectedItem;
                if(id_inv==0){

                    negocio.insertar_item(m.id,Convert.ToInt32(edtCantI.Text));
                }else{
                    negocio.modificar_item(id_inv, m.id, Convert.ToInt32(edtCantI.Text));
                }
                limpiarInv();
                bloquearInv();
                cargar_inventario();
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            bloquearInv();
            cargar_inventario();
           
            cargar_combo_inv();
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            id_inv = 0;
            bloquearInv();
            limpiarInv();
        }

        private void btnMA_Click(object sender, EventArgs e)
        {
            if(id_inv!=0){
                habilitarInv();
            }
        }

        private void dgvInv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_inv = (int)dgvInv.CurrentRow.Cells[1].Value;
            btnNa.Enabled = false;
            btnMA.Enabled = true;
            btnDA.Enabled = true;
            inventario m= negocio.buscar_item(id_inv);
            edtCantI.Text = Convert.ToString(m.cantidad);
            List<material_herramienta> il = negocio.lista_mat();
            int c = 0;
            foreach (material_herramienta p in il)
            {
                if (p.id==m.material_herramienta.id)
                {
                    cbxItem.SelectedIndex = c;
                    return;
                }
                c++;

            }
            MessageBox.Show("DEBE ACTUALIZAR EL CAMPO MATERIAL HERRAMIENTA.");
            cbxItem.SelectedIndex = -1;

        }

        private void btnDA_Click(object sender, EventArgs e)
        {
            if(id_inv!=0){
                negocio.eliminar_item(id_inv);
                limpiarInv();
                cargar_inventario();
                bloquearInv();
            }
        }

        private void edtCantI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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

        private void edtTelfP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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

        private void edtPrecioM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < edtPrecioM.Text.Length; i++)
            {
                if (edtPrecioM.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 4)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

     

     

    }
}
