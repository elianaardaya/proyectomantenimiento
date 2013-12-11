namespace proyectoMantenimiento.Presentacion
{
    partial class PGestorUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRol = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvRol = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnNR = new System.Windows.Forms.Button();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.btnBuscarRol = new System.Windows.Forms.Button();
            this.btnGuardarRol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtNombreRol = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbxReportes = new System.Windows.Forms.CheckBox();
            this.chbxRM = new System.Windows.Forms.CheckBox();
            this.chbxGP = new System.Windows.Forms.CheckBox();
            this.chbxGM = new System.Windows.Forms.CheckBox();
            this.chbxGI = new System.Windows.Forms.CheckBox();
            this.chbxConfig = new System.Windows.Forms.CheckBox();
            this.chbxGA = new System.Windows.Forms.CheckBox();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtPass = new System.Windows.Forms.TextBox();
            this.edtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabRol.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRol);
            this.tabControl1.Controls.Add(this.tabUsuario);
            this.tabControl1.Location = new System.Drawing.Point(2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRol
            // 
            this.tabRol.Controls.Add(this.groupBox4);
            this.tabRol.Controls.Add(this.groupBox3);
            this.tabRol.Controls.Add(this.groupBox2);
            this.tabRol.Controls.Add(this.groupBox1);
            this.tabRol.Location = new System.Drawing.Point(4, 22);
            this.tabRol.Name = "tabRol";
            this.tabRol.Padding = new System.Windows.Forms.Padding(3);
            this.tabRol.Size = new System.Drawing.Size(560, 361);
            this.tabRol.TabIndex = 0;
            this.tabRol.Text = "ROL";
            this.tabRol.UseVisualStyleBackColor = true;
            this.tabRol.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabRol.Enter += new System.EventHandler(this.tabRol_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvRol);
            this.groupBox4.Location = new System.Drawing.Point(6, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 213);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EXPLORADOR";
            // 
            // dgvRol
            // 
            this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRol.Location = new System.Drawing.Point(6, 19);
            this.dgvRol.Name = "dgvRol";
            this.dgvRol.ReadOnly = true;
            this.dgvRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRol.Size = new System.Drawing.Size(284, 188);
            this.dgvRol.TabIndex = 0;
            this.dgvRol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRol_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMR);
            this.groupBox3.Controls.Add(this.btnNR);
            this.groupBox3.Controls.Add(this.btnEliminarRol);
            this.groupBox3.Controls.Add(this.btnBuscarRol);
            this.groupBox3.Controls.Add(this.btnGuardarRol);
            this.groupBox3.Location = new System.Drawing.Point(324, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 131);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACCION";
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(13, 58);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(75, 23);
            this.btnMR.TabIndex = 4;
            this.btnMR.Text = "MODIFICAR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnNR
            // 
            this.btnNR.Location = new System.Drawing.Point(13, 29);
            this.btnNR.Name = "btnNR";
            this.btnNR.Size = new System.Drawing.Size(75, 23);
            this.btnNR.TabIndex = 3;
            this.btnNR.Text = "NUEVO";
            this.btnNR.UseVisualStyleBackColor = true;
            this.btnNR.Click += new System.EventHandler(this.btnNR_Click);
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Location = new System.Drawing.Point(13, 87);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarRol.TabIndex = 2;
            this.btnEliminarRol.Text = "ELIMINAR";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // btnBuscarRol
            // 
            this.btnBuscarRol.Location = new System.Drawing.Point(107, 29);
            this.btnBuscarRol.Name = "btnBuscarRol";
            this.btnBuscarRol.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRol.TabIndex = 1;
            this.btnBuscarRol.Text = "CANCELAR";
            this.btnBuscarRol.UseVisualStyleBackColor = true;
            this.btnBuscarRol.Click += new System.EventHandler(this.btnBuscarRol_Click);
            // 
            // btnGuardarRol
            // 
            this.btnGuardarRol.Location = new System.Drawing.Point(107, 58);
            this.btnGuardarRol.Name = "btnGuardarRol";
            this.btnGuardarRol.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRol.TabIndex = 0;
            this.btnGuardarRol.Text = "GUARDAR";
            this.btnGuardarRol.UseVisualStyleBackColor = true;
            this.btnGuardarRol.Click += new System.EventHandler(this.btnGuardarRol_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.edtNombreRol);
            this.groupBox2.Location = new System.Drawing.Point(6, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 116);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "NOMBRE:";
            // 
            // edtNombreRol
            // 
            this.edtNombreRol.Location = new System.Drawing.Point(95, 28);
            this.edtNombreRol.Name = "edtNombreRol";
            this.edtNombreRol.Size = new System.Drawing.Size(178, 20);
            this.edtNombreRol.TabIndex = 7;
            this.edtNombreRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtNombreRol_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbxReportes);
            this.groupBox1.Controls.Add(this.chbxRM);
            this.groupBox1.Controls.Add(this.chbxGP);
            this.groupBox1.Controls.Add(this.chbxGM);
            this.groupBox1.Controls.Add(this.chbxGI);
            this.groupBox1.Controls.Add(this.chbxConfig);
            this.groupBox1.Controls.Add(this.chbxGA);
            this.groupBox1.Location = new System.Drawing.Point(320, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 198);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCESO";
            // 
            // chbxReportes
            // 
            this.chbxReportes.AutoSize = true;
            this.chbxReportes.Location = new System.Drawing.Point(28, 168);
            this.chbxReportes.Name = "chbxReportes";
            this.chbxReportes.Size = new System.Drawing.Size(85, 17);
            this.chbxReportes.TabIndex = 6;
            this.chbxReportes.Text = "REPORTES";
            this.chbxReportes.UseVisualStyleBackColor = true;
            // 
            // chbxRM
            // 
            this.chbxRM.AutoSize = true;
            this.chbxRM.Location = new System.Drawing.Point(28, 145);
            this.chbxRM.Name = "chbxRM";
            this.chbxRM.Size = new System.Drawing.Size(176, 17);
            this.chbxRM.TabIndex = 5;
            this.chbxRM.Text = "REGISTRO MANTENIMIENTO";
            this.chbxRM.UseVisualStyleBackColor = true;
            // 
            // chbxGP
            // 
            this.chbxGP.AutoSize = true;
            this.chbxGP.Location = new System.Drawing.Point(28, 122);
            this.chbxGP.Name = "chbxGP";
            this.chbxGP.Size = new System.Drawing.Size(148, 17);
            this.chbxGP.TabIndex = 4;
            this.chbxGP.Text = "GESTIONAR PERMISOS";
            this.chbxGP.UseVisualStyleBackColor = true;
            // 
            // chbxGM
            // 
            this.chbxGM.AutoSize = true;
            this.chbxGM.Location = new System.Drawing.Point(28, 99);
            this.chbxGM.Name = "chbxGM";
            this.chbxGM.Size = new System.Drawing.Size(160, 17);
            this.chbxGM.TabIndex = 3;
            this.chbxGM.Text = "GESTIONAR MAQUINARIA";
            this.chbxGM.UseVisualStyleBackColor = true;
            // 
            // chbxGI
            // 
            this.chbxGI.AutoSize = true;
            this.chbxGI.Location = new System.Drawing.Point(28, 76);
            this.chbxGI.Name = "chbxGI";
            this.chbxGI.Size = new System.Drawing.Size(158, 17);
            this.chbxGI.TabIndex = 2;
            this.chbxGI.Text = "GESTIONAR INVENTARIO";
            this.chbxGI.UseVisualStyleBackColor = true;
            // 
            // chbxConfig
            // 
            this.chbxConfig.AutoSize = true;
            this.chbxConfig.Location = new System.Drawing.Point(28, 53);
            this.chbxConfig.Name = "chbxConfig";
            this.chbxConfig.Size = new System.Drawing.Size(115, 17);
            this.chbxConfig.TabIndex = 1;
            this.chbxConfig.Text = "CONFIGURACION";
            this.chbxConfig.UseVisualStyleBackColor = true;
            // 
            // chbxGA
            // 
            this.chbxGA.AutoSize = true;
            this.chbxGA.Location = new System.Drawing.Point(28, 30);
            this.chbxGA.Name = "chbxGA";
            this.chbxGA.Size = new System.Drawing.Size(135, 17);
            this.chbxGA.TabIndex = 0;
            this.chbxGA.Text = "GESTIONAR ACCESO";
            this.chbxGA.UseVisualStyleBackColor = true;
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.groupBox5);
            this.tabUsuario.Controls.Add(this.btnBuscar);
            this.tabUsuario.Controls.Add(this.btnEliminar);
            this.tabUsuario.Controls.Add(this.btnGuardar);
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(560, 361);
            this.tabUsuario.TabIndex = 1;
            this.tabUsuario.Text = "USUARIO";
            this.tabUsuario.UseVisualStyleBackColor = true;
            this.tabUsuario.Click += new System.EventHandler(this.tabUsuario_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.cbxRol);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.edtPass);
            this.groupBox5.Controls.Add(this.edtNombre);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(10, 42);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(413, 138);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DATOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DE USUARIO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxRol
            // 
            this.cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Items.AddRange(new object[] {
            "seleccionar"});
            this.cbxRol.Location = new System.Drawing.Point(44, 87);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(192, 21);
            this.cbxRol.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA DE USUARIO:";
            // 
            // edtPass
            // 
            this.edtPass.Location = new System.Drawing.Point(157, 61);
            this.edtPass.Name = "edtPass";
            this.edtPass.Size = new System.Drawing.Size(192, 20);
            this.edtPass.TabIndex = 7;
            // 
            // edtNombre
            // 
            this.edtNombre.Location = new System.Drawing.Point(157, 25);
            this.edtNombre.Name = "edtNombre";
            this.edtNombre.Size = new System.Drawing.Size(192, 20);
            this.edtNombre.TabIndex = 6;
            this.edtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ROL:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(455, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(455, 123);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(455, 42);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PGestorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 384);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "PGestorUsuario";
            this.Text = "GESTOR DE USUARIO";
            this.Load += new System.EventHandler(this.PGestorUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRol.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabUsuario.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRol;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNombreRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.Button btnBuscarRol;
        private System.Windows.Forms.Button btnGuardarRol;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.TextBox edtPass;
        private System.Windows.Forms.TextBox edtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbxGP;
        private System.Windows.Forms.CheckBox chbxGM;
        private System.Windows.Forms.CheckBox chbxGI;
        private System.Windows.Forms.CheckBox chbxConfig;
        private System.Windows.Forms.CheckBox chbxGA;
        private System.Windows.Forms.CheckBox chbxRM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvRol;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnNR;
        private System.Windows.Forms.CheckBox chbxReportes;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}