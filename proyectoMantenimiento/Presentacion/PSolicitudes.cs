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
    public partial class PSolicitudes : Form
    {
        private NMantenimiento negocioM;
        private NSolicitud negocio;
        private int id;
        public PSolicitudes()
        {
            InitializeComponent();
            negocio = new NSolicitud();
            negocioM = new NMantenimiento();
            cargar_lista();
            cargar_pendientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(id!=0){
                negocio.aprobar(id);
                solicitud s = negocio.obtener(id);

                negocioM.insertarDetalleReparo(s.idMaquina,Form1.user.id);

            }

            cargar_lista();
            cargar_pendientes();
        }


        public void cargar_pendientes()
        {
            solicitudCollection sc=negocio.listar2("PETICION");
            solicitudCollection sc2=negocio.listar2("PENDIENTE");
            foreach(solicitud s in sc2){
                sc.Add(s);
            }
            dgvPendiente.DataSource = sc;
        }

        public void cargar_lista()
        {
             solicitudCollection sc=negocio.listar2("APROBADA");
            solicitudCollection sc2=negocio.listar2("RECHAZADA");
            foreach(solicitud s in sc2){
                sc.Add(s);
            }
            dgvLista.DataSource = sc;
        }

        private void dgvPendiente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dgvPendiente.CurrentRow.Cells[0].Value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                negocio.rechazar(id);
                id = 0;
            }

            cargar_lista();
            cargar_pendientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                negocio.pendiente(id);
                id = 0;
            }

            cargar_lista();
            cargar_pendientes();
        }
        

    }
}
