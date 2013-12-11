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
    public partial class PMantenimiento : Form
    {
        NMaquina negocioM;
        NSolicitud negocioS;
        NMantenimiento negocioMant;
        NInventario negocioInv;
        private Usuario user;
        private int id_recomendacion;
        private int id_fproblema;
        private int id_freparo;
        private int id_sol;
        private int index_c;
        private int index_m;
        private List<string[]> listac;
        private List<materialusado> listam;
        private bool modificar = false;
        public PMantenimiento()
        {
            InitializeComponent();
            user = Form1.user;
            negocioM= new NMaquina();
            negocioS = new NSolicitud();
            negocioMant = new NMantenimiento();
            negocioInv = new NInventario();
            cargarCMaquina();
            //cargarGSol();
            listac = new List<string[]>();
            listam = new List<materialusado>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PMantenimiento_Load(object sender, EventArgs e)
        {
            user = Form1.user;
        }

        public void cargarCMaquina()
        {   List<maquina>lista=negocioM.listar();
            foreach(maquina m in lista){
                cbxMaquina.Items.Add(m);
                cbxMaquinaP2.Items.Add(m);
                cbxMaqP.Items.Add(m);
               
                cbxMaquinaR.Items.Add(m);
                cbxMaquinaR2.Items.Add(m);
            }
        }

        public bool validar_solicitud()
        {
            if(cbxMaquina.SelectedIndex!=-1 && cbxTipo.SelectedIndex!=-1 && edtObser.Text!=""){
                maquina m = (maquina)cbxMaquina.SelectedItem;
                if(m.estado2!=false){
                    return true;
                }
                MessageBox.Show("LA MAQUINA SELECCIONADA HA SIDO DADA DE BAJA.");
                return false;
            }else{
                return false;
            }
        }
        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            
            if(validar_solicitud()){
                maquina m = (maquina)cbxMaquina.SelectedItem;

                negocioS.insertar(dtpFecha.Value, edtObser.Text, user.id, m.id, (string)cbxTipo.SelectedItem);
                cargarGSol();
                MessageBox.Show("SOLICITUD PROCESADA CON EXITO.");
            }else{
                MessageBox.Show("DEBES INTRODUCIR LOS DATOS CORRECTAMENTE.");
            }
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cargarGSol()
        {

            dgvSol.DataSource = negocioS.listar(user.id);
            
            dgvSol.Columns["idusuario"].Visible = false;
            dgvSol.Columns["estado"].Visible = false;
            dgvSol.Columns["idmaquina"].Visible = false;
            dgvSol.Columns["Usuario"].Visible = false;
            dgvSol.Columns[0].HeaderText = "NRO";
            dgvSol.Columns[0].Width = 50;
            dgvSol.Columns[2].HeaderText = "FECHA";
            dgvSol.Columns[3].HeaderText = "OBSERVACION";
            dgvSol.Columns[5].HeaderText = "TIPO";
            dgvSol.Columns[7].HeaderText = "ESTADO";
            dgvSol.Columns[8].HeaderText = "MAQUINA";
         
            dgvSol.Columns[2].DisplayIndex=5;
            dgvSol.Columns[3].DisplayIndex=2;
            dgvSol.Columns[5].DisplayIndex=3;
            dgvSol.Columns[7].DisplayIndex=4;
            dgvSol.Columns[8].DisplayIndex=1;

        }

        private void btnModP_Click(object sender, EventArgs e)
        {

        }

        private void btnDelP_Click(object sender, EventArgs e)
        {

        }

        private void btnAddP_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnNR_Click(object sender, EventArgs e)
        {
            habilitarRecomendacion();
            id_recomendacion = 0;
        }

        //metodo para limpiar los campos de la pestaña recomendacion
        private void limpiarRecomendacion()
        {
          
            edtRecR.Text = "";
            cbxMaquinaR.SelectedIndex = -1;
            cbxTipoR.SelectedIndex = -1;
            cbxMaquinaR2.SelectedIndex = -1;

        }
        //metodo encargado de verificar que todos los campos tienen datos.
        private bool validarRecomendacion()
        {
            if(edtRecR.Text!="" && cbxTipoR.SelectedIndex!=-1 && cbxMaquinaR.SelectedIndex!=-1){
                maquina m= (maquina)cbxMaquinaR.SelectedItem;
                if(m.estado2){
                    return true;
                }
                MessageBox.Show("LA MAQUINA SELECCIONADA HA SIDO DADA DE BAJA.");
                return false;
            }else{
                 MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
                return false;
            }
        }
        private bool validarFProblema()
        {
            if(edtMotivoP.Text!="" && cbxMaqP.SelectedIndex!=-1){
                maquina m= (maquina)cbxMaqP.SelectedItem;
                if(m.estado2){
                    return true;
                }
                MessageBox.Show("LA MAQUINA SELECCIONADA HA SIDO DADA DE BAJA.");
                return false;
            }else{
                 MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
                return false;
            }
        }
        private bool validarFReparo()
        {
            if( dgvCompFR.RowCount!=0 && dgvMatFR.RowCount!=0){
                return true;
            }else{
                 MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
                return false;
            }
        }
        //metodo que habilita los campos ya sea para modificar o añadir un nuevo registro
        private void habilitarRecomendacion()
        {
            edtRecR.Enabled = true;
            cbxMaquinaR.Enabled = true;
            cbxTipoR.Enabled = true;
            cbxMaquinaR2.Enabled = false;
            dgvHRec.Enabled = false;
            dgvRec.Enabled = false;
            btnGR.Enabled = true;
            btnMR.Enabled = false;
            btnER.Enabled = false; btnNR.Enabled = false;
        }
        //bloquea los campos luego realizar alguna operacion ABM
        private void bloquearRecomendacion()
        {
            edtRecR.Enabled =false;
            cbxMaquinaR.Enabled = false;
            cbxTipoR.Enabled = false;
            cbxMaquinaR2.Enabled = true;
            dgvHRec.Enabled = true;
            dgvRec.Enabled = true;
            btnGR.Enabled = false;
            btnMR.Enabled = false;
            btnER.Enabled = false;
            btnNR.Enabled = true;
        }
        private void limpiarFProblema()
        {
            edtMotivoP.Text = "";
            cbxMaqP.SelectedIndex = -1;
            cbxMaquinaP2.SelectedIndex = -1;
        }
     
        private void habilitarFProblema()
        {
            edtMotivoP.Enabled = true;
            cbxMaqP.Enabled = true;
            cbxMaquinaP2.Enabled = false;
            btnNFP.Enabled = false;
            btnMFP.Enabled = false; btnGFP.Enabled = true;
            btnEFP.Enabled = false;
            dgvHistorialP.Enabled = false;
            dgvListaP.Enabled = false;

        }
        private void bloquearFProblema()
        {
            edtMotivoP.Enabled = false;
            cbxMaqP.Enabled = false;
            cbxMaquinaP2.Enabled = true;
            btnNFP.Enabled = true;
            btnMFP.Enabled = false;
            btnEFP.Enabled = false; btnGFP.Enabled = false;
            dgvHistorialP.Enabled = true;
            dgvListaP.Enabled = true;
        }
        private void limpiarFReparacion()
        {
            edtMaquinaFR.Text = "";
            dgvMatFR.DataSource = null;
            dgvCompFR.DataSource = null;
        }

        private void habilitarFReparacion()
        {
            dgvFRep.Enabled = false;
            btnMFR.Enabled = true;
            //btnGFR.Enabled = true;
            btnAddComp.Enabled = true;
            btnRemoveComp.Enabled = true;
            btnAMatU.Enabled = true;
            btnDMAtU.Enabled = true;
            dgvCompFR.Enabled = true;
            dgvMatFR.Enabled = true;
        }
        private void bloquearFReparacion()
        {
            dgvFRep.Enabled = true;
            btnMFR.Enabled = false;
            //btnGFR.Enabled = false;
            btnAddComp.Enabled = false;
            btnRemoveComp.Enabled = false;
            btnAMatU.Enabled = false;
            btnDMAtU.Enabled = false;
            dgvCompFR.Enabled = false;
            dgvMatFR.Enabled = false;

        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            bloquearRecomendacion();
            cargarRecomendacion();
            
        }

        private void btnCR_Click(object sender, EventArgs e)
        {
            limpiarRecomendacion();
            bloquearRecomendacion();
            id_recomendacion = 0;
            modificar = false;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            if(id_recomendacion!=0){
                habilitarRecomendacion();
                modificar = true;
            }
        }

        private void dgvRec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_recomendacion = (int)dgvRec.CurrentRow.Cells[0].Value;
            recomendacion rec = negocioMant.buscarRecomendacion(id_recomendacion);
            edtRecR.Text = rec.Propertyrecomendacion;
            List<maquina> mc = negocioM.listar();
            int c=0;
            foreach (maquina m in mc)
            {
                if(m.id==rec.idmaquina ){
                    cbxMaquinaR.SelectedIndex = c;
                    if (rec.tipo == "PREVENTIVO")
                    {
                        cbxTipoR.SelectedIndex = 0;
                    }
                    else
                    {
                        cbxTipoR.SelectedIndex = 1;
                    }
                    btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
                    return;
                }
                c++;
            }
            //MessageBox.Show("DEBE ACTUALIZAR EL CAMPO MAQUINA.");
            //cbxMaquinaR.SelectedIndex = -1;
            if (rec.tipo == "PREVENTIVO")
            {
                cbxTipoR.SelectedIndex = 0;
            }
            else
            {
                cbxTipoR.SelectedIndex = 1;
            }
            btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
        }

        private void cargarRecomendacion()
        {
         
            recomendacionCollection rc = negocioMant.listarRecomendacion();
            
            dgvRec.DataSource = rc;
            if(rc.Count==0){
                dgvRec.Enabled = false;
            }
            dgvRec.Columns["id"].Visible = false;
            dgvRec.Columns["estado"].Visible = false;
            dgvRec.Columns["idmaquina"].Visible = false;
            dgvRec.Columns[2].HeaderText = "RECOMENDACION";
            dgvRec.Columns[3].HeaderText = "TIPO";
            dgvRec.Columns[5].HeaderText = "MAQUINA";
            dgvRec.Columns["maquina"].Width = 200;
            dgvRec.Columns[2].Width = 250;

        }

        private void cargarFProblema()
        {
            problemaCollection pc = negocioMant.listarProblema();
            dgvListaP.DataSource = pc;
            if(pc.Count==0){
                dgvListaP.Enabled = false;
            }
            dgvListaP.Columns["id"].Visible = false;
            dgvListaP.Columns["estado"].Visible = false;
            dgvListaP.Columns["idmaquina"].Visible = false;
            dgvListaP.Columns[1].HeaderText = "FECHA";
            dgvListaP.Columns[1].Width = 120;
            dgvListaP.Columns[3].HeaderText = "MOTIVO";
            dgvListaP.Columns[3].Width = 250;
            dgvListaP.Columns[5].HeaderText = "MAQUINA";
            dgvListaP.Columns[5].Width = 150;
             dgvListaP.Columns[1].DisplayIndex=2;
             dgvListaP.Columns[3].DisplayIndex=1;
             dgvListaP.Columns[5].DisplayIndex=0;
        }

        private void btnGR_Click(object sender, EventArgs e)
        {
            if(validarRecomendacion() || modificar){
                maquina m= (maquina) cbxMaquinaR.SelectedItem;
                if(id_recomendacion==0){
                    negocioMant.insertarRecomendacion(m.id, edtRecR.Text, (string)cbxTipoR.SelectedItem);
                }else{
                    negocioMant.modificarRecomendacion(id_recomendacion, m.id, edtRecR.Text, (string)cbxTipoR.SelectedItem);
                    modificar = false;
                }
                limpiarRecomendacion();
                bloquearRecomendacion();
                cargarRecomendacion();
            }
        }

        private void dgvHRec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_recomendacion = (int)dgvHRec.CurrentRow.Cells[0].Value;
            recomendacion rec = negocioMant.buscarRecomendacion(id_recomendacion);
            edtRecR.Text = rec.Propertyrecomendacion;
            List<maquina> mc = negocioM.listar();
            int c = 0;
            foreach (maquina m in mc)
            {
                if (m.id == rec.idmaquina )
                {
                    cbxMaquinaR.SelectedIndex = c;
                    if (rec.tipo == "PREVENTIVO")
                    {
                        cbxTipoR.SelectedIndex = 0;
                    }
                    else
                    {
                        cbxTipoR.SelectedIndex = 1;
                    }
                    btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
                    return;
                }
                c++;
            }
            //MessageBox.Show("DEBE ACTUALIZAR EL CAMPO MAQUINA.");
            //cbxMaquinaR.SelectedIndex = -1;
            if (rec.tipo == "PREVENTIVO")
            {
                cbxTipoR.SelectedIndex = 0;
            }
            else
            {
                cbxTipoR.SelectedIndex = 1;
            }
            btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
        }

        private void cbxMaquinaR2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaquinaR2.SelectedIndex != -1)
            {
                recomendacionCollection rc = negocioMant.listarRecomendacion2((maquina)cbxMaquinaR2.SelectedItem);
                dgvHRec.DataSource = rc;
                if (rc.Count == 0)
                {
                    dgvHRec.Enabled = false;
                }
                dgvHRec.Columns["id"].Visible = false;
                dgvHRec.Columns["estado"].Visible = false;
                dgvHRec.Columns["idmaquina"].Visible = false;
                dgvHRec.Columns[2].HeaderText = "RECOMENDACION";
                dgvHRec.Columns[3].HeaderText = "TIPO";
                dgvHRec.Columns[5].HeaderText = "MAQUINA";
                dgvHRec.Columns["maquina"].Width = 200;
                dgvHRec.Columns[2].Width = 250;
            }
            else
            {
                dgvHRec.DataSource = null;
            }

        }

        private void btnER_Click(object sender, EventArgs e)
        {
            if(id_recomendacion!=0){
                negocioMant.eliminarRecomendacion(id_recomendacion);
                cargarRecomendacion();
                limpiarRecomendacion();
                bloquearRecomendacion();
            }
        }

        private void btnCFP_Click(object sender, EventArgs e)
        {
            limpiarFProblema();
            bloquearFProblema();
            id_fproblema = 0;
            modificar = false;
        }

        private void btnNFP_Click(object sender, EventArgs e)
        {
            id_fproblema = 0;
            habilitarFProblema();

        }

        private void btnGFP_Click(object sender, EventArgs e)
        {
            if(validarFProblema()|| modificar){
                maquina m= (maquina) cbxMaqP.SelectedItem;
                if(id_fproblema==0){
                    negocioMant.insertarProblema(dtpFechaP.Value, edtMotivoP.Text, m.id);
                }else{
                    negocioMant.modificarProblema(id_fproblema, dtpFechaP.Value, edtMotivoP.Text, m.id);
                    modificar = false; ;
                }

                limpiarFProblema();
                bloquearFProblema();
                cargarFProblema();
            }
        }

        private void dgvListaP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEFP.Enabled = true;
            btnMFP.Enabled = true;
            id_fproblema = (int)dgvListaP.CurrentRow.Cells[0].Value;
            problema p = negocioMant.buscarProblema(id_fproblema);
            edtMotivoP.Text = p.motivo;
            dtpFechaP.Value = (DateTime)p.fecha;
            List<maquina> mc = negocioM.listar();
            int c = 0;
            foreach (maquina m in mc)
            {
                if (m.id == p.idmaquina )
                {
                    cbxMaqP.SelectedIndex = c;
                    
                    btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
                    return;
                }
                c++;
            }
           // MessageBox.Show("DEBE ACTUALIZAR EL CAMPO MAQUINA.");
            //cbxMaqP.SelectedIndex = -1;

        }

        private void dgvHistorialP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEFP.Enabled = true;
            btnMFP.Enabled = true;
            id_fproblema = (int)dgvHistorialP.CurrentRow.Cells[0].Value;
            problema p = negocioMant.buscarProblema(id_fproblema);
            edtMotivoP.Text = p.motivo;
            dtpFechaP.Value = (DateTime)p.fecha;
            List<maquina> mc = negocioM.listar();
            int c = 0;
            foreach (maquina m in mc)
            {
                if (m.id == p.idmaquina)
                {
                    cbxMaqP.SelectedIndex = c;

                    btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
                    return;
                }
                c++;
            }
            //MessageBox.Show("DEBE ACTUALIZAR EL CAMPO MAQUINA.");
            //cbxMaquinaR.SelectedIndex = -1;

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            bloquearFProblema();
            cargarFProblema();
        }

        private void btnEFP_Click(object sender, EventArgs e)
        {
            if(id_fproblema!=0){
                negocioMant.eliminarProblema(id_fproblema);
                limpiarFProblema();
                cargarFProblema();
                bloquearFProblema();
                id_fproblema = 0;
            }
        }

        private void btnMFP_Click(object sender, EventArgs e)
        {
            if (id_fproblema != 0)
            {
                habilitarFProblema();
                modificar = true;
            }
        }

        private void cbxMaquinaP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaquinaP2.SelectedIndex != -1)
            {

                problemaCollection pc = negocioMant.listarProblema2((maquina)cbxMaquinaP2.SelectedItem);
                dgvHistorialP.DataSource = pc;
                if (pc.Count == 0)
                {
                    dgvHistorialP.Enabled = false;
                }
                dgvHistorialP.Columns["id"].Visible = false;
                dgvHistorialP.Columns["estado"].Visible = false;
                dgvHistorialP.Columns["idmaquina"].Visible = false;
                dgvHistorialP.Columns[1].HeaderText = "FECHA";
                dgvHistorialP.Columns[1].Width = 120;
                dgvHistorialP.Columns[3].HeaderText = "MOTIVO";
                dgvHistorialP.Columns[3].Width = 250;
                dgvHistorialP.Columns[5].HeaderText = "MAQUINA";
                dgvHistorialP.Columns[5].Width = 150;
                dgvHistorialP.Columns[1].DisplayIndex = 2;
                dgvHistorialP.Columns[3].DisplayIndex = 1;
                dgvHistorialP.Columns[5].DisplayIndex = 0;
            }
            else
            {
                dgvHistorialP.DataSource = null;
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddComp_Click(object sender, EventArgs e)
        {
            if(id_freparo!=0){

                FListaComponente form = new FListaComponente(id_freparo);
                form.ShowDialog(this);
                cargar_tabla_detalle_c();
                dgvCompFR.Enabled = true;
                
            }
           
            //componente c = negocioInv.buscar_c(FListaComponente.id);

            //if (!verificar_c(c))
            //{

            //}
            
            
        }


        //public void preparar_grilla_comp()
        //{
        //    dgvCompFR.ColumnCount = 3;
        //    dgvCompFR.Columns[0].Name = "NOMBRE";
        //    dgvCompFR.Columns[1].Name = "CANTIDAD";
        //    dgvCompFR.Columns[2].Name = "PRECIO";
        //    //dgvCompFR.
        //}

       

        private bool verificar_c(componente c)
        {
            int cn = 0;
            foreach (string[] cmp in listac)
            {
           
               if(cmp[0]==c.nombre){
                  
                   return true;
               }
               cn++;
           }
           return false;
        }

        private bool verificar_mat(material_herramienta m)
        {
            foreach(materialusado mh in listam){
           
               if(mh.idmaterial==m.id){
                   return true;
               }
           
           }
           return false;
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            edtMecanico.Text = user.usuario;
            
        }

        private void btnNFR_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelS_Click(object sender, EventArgs e)
        {
            if(id_sol!=0){
                solicitud s = negocioS.obtener(id_sol);
                if (MessageBox.Show("ESTA SEGURO DE CANCELAR LA SOLICITUD # "+s.id+"?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    negocioS.cancelar(id_sol);
                    cargarGSol();
                }
                id_sol = 0;
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            id_sol = 0;
            cargarGSol();
        }

        private void dgvSol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_sol = (int)dgvSol.CurrentRow.Cells[0].Value;
            solicitud s = negocioS.obtener(id_sol);
            edtObser.Text = s.observacion;
           


        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            limpiarFReparacion();
            cargarFReparo();
            bloquearFReparacion();
            //preparar_grilla_comp();
        }

        public void cargarFReparo()
        {
            
            detalle_reparoCollection drc= negocioMant.listarDetalle_Re(user.id);
            dgvFRep.DataSource = drc;
        }

  

        private void dgvFRep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarFReparacion();
            id_freparo = (int)dgvFRep.CurrentRow.Cells[2].Value;
            detalle_reparo dr = negocioMant.buscar_detalle_reparo(id_freparo);
            dateTimePicker1.Value = (DateTime)dr.fecha;
            edtMaquinaFR.Text = dr.maquina.nombre;
            dgvCompFR.Enabled = true;
            dgvMatFR.Enabled = true;
            cargar_tabla_detalle_m();
            cargar_tabla_detalle_c();
        }

        public void cargar_detalle_c(int id)
        {
            detalleComponenteCollection dcc= negocioMant.listar_detalle_c(id);

            if (dcc.Count != 0)
            {
                dgvCompFR.DataSource = dcc;
            }
            else {
                dgvCompFR.DataSource = null;
            }
        }

        public void cargar_detalle_m(int id){


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(id_freparo!=0){

                FListaMaterial flm = new FListaMaterial(id_freparo);
                flm.ShowDialog(this);
                cargar_tabla_detalle_m();
                dgvMatFR.Enabled = true;
            }
           
        }

        public void cargar_tabla_detalle_c()
        {


            dgvCompFR.ClearSelection();
            
                detalleComponenteCollection drc = negocioMant.listar_detalle_c(id_freparo);
                try
                {
                    dgvCompFR.DataSource = drc;
                }
                catch { }

                if (drc.Count == 0)
                {
                    dgvCompFR.Enabled = false;
                }

                dgvCompFR.Columns["id_componente"].Visible = false;
                dgvCompFR.Columns["id"].Visible = false;
                dgvCompFR.Columns["id_reparo"].Visible = false;
                dgvCompFR.Columns["detalle_reparo"].Visible = false;
                dgvCompFR.Columns[2].HeaderText = "CANTIDAD";
                dgvCompFR.Columns[3].HeaderText = "MONTO";
                dgvCompFR.Columns[5].HeaderText = "COMPONENTE";
                // dgvCompFR.Refresh();
          
        }


        public void cargar_tabla_detalle_m()
        {
            materialusadoCollection muc = negocioMant.listar_detalle_matu(id_freparo);
            dgvMatFR.DataSource = muc;
            if(muc.Count==0){
                dgvMatFR.Enabled = false;
            }
            dgvMatFR.Columns["idmaterial"].Visible = false;
            dgvMatFR.Columns["id"].Visible = false;
            dgvMatFR.Columns["id_reparo"].Visible = false;
            dgvMatFR.Columns["detalle_reparo"].Visible = false;
            dgvMatFR.Columns[2].HeaderText = "CANTIDAD";
            dgvMatFR.Columns[5].HeaderText = "MATERIAL";

        }

        private void btnCFR_Click(object sender, EventArgs e)
        {
            limpiarFReparacion();
            bloquearFReparacion();
            id_freparo = 0;
            dgvCompFR.DataSource = null;
            dgvMatFR.DataSource = null;
        }

        private void btnMFR_Click(object sender, EventArgs e)
        {
            bloquearFReparacion();
            limpiarFReparacion();

        }

        private void dgvCompFR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index_c =(int)dgvCompFR.CurrentRow.Cells[4].Value;
        }

        private void dgvMatFR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index_m = (int)dgvMatFR.CurrentRow.Cells[0].Value;
        }

        private void btnRemoveComp_Click(object sender, EventArgs e)
        {
            if(index_c!=0){
                dgvCompFR.DataSource = null;
                negocioMant.eliminar_det_comp(index_c);
                cargar_tabla_detalle_c();
                index_c = 0;
            }

        }

        private void btnDMAtU_Click(object sender, EventArgs e)
        {
            if(index_m!=0){
                try
                {
                    dgvMatFR.DataSource = null;
                    negocioMant.eliminar_detalle_mat(index_m);
                    cargar_tabla_detalle_m();
                    index_m = 0;
                }
                catch
                {

                }
                
            }
        }

        private void btnGFR_Click(object sender, EventArgs e)
        {

        }

        private void dgvCompFR_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index_c = (int)dgvCompFR.CurrentRow.Cells[4].Value;
        }

        private void dgvMatFR_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index_m = (int)dgvMatFR.CurrentRow.Cells[0].Value;
        }
    
        

    }
}
