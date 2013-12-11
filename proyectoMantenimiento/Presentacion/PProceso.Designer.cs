namespace proyectoMantenimiento.Presentacion
{
    partial class PProceso
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
            this.tabMaquinaria = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtNombreL = new System.Windows.Forms.TextBox();
            this.edtDescL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnML = new System.Windows.Forms.Button();
            this.btnEL = new System.Windows.Forms.Button();
            this.btnNL = new System.Windows.Forms.Button();
            this.btnCL = new System.Windows.Forms.Button();
            this.btnGuardarLinea = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLinea = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtCarM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edtFuncM = new System.Windows.Forms.TextBox();
            this.cbxLineaM = new System.Windows.Forms.ComboBox();
            this.edtIndM = new System.Windows.Forms.TextBox();
            this.edtCodM = new System.Windows.Forms.TextBox();
            this.edtAnhoM = new System.Windows.Forms.TextBox();
            this.edtNombreM = new System.Windows.Forms.TextBox();
            this.edtMarcaM = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnNM = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.btnGM = new System.Windows.Forms.Button();
            this.btnEM = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMaquina = new System.Windows.Forms.DataGridView();
            this.tabMaquinaria.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinea)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquina)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMaquinaria
            // 
            this.tabMaquinaria.Controls.Add(this.tabPage1);
            this.tabMaquinaria.Controls.Add(this.tabPage2);
            this.tabMaquinaria.Location = new System.Drawing.Point(2, 2);
            this.tabMaquinaria.Name = "tabMaquinaria";
            this.tabMaquinaria.SelectedIndex = 0;
            this.tabMaquinaria.Size = new System.Drawing.Size(564, 430);
            this.tabMaquinaria.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LINEA DE PRODUCCION";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.edtNombreL);
            this.groupBox4.Controls.Add(this.edtDescL);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(18, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 192);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DATOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOMBRE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // edtNombreL
            // 
            this.edtNombreL.Location = new System.Drawing.Point(96, 24);
            this.edtNombreL.Name = "edtNombreL";
            this.edtNombreL.Size = new System.Drawing.Size(259, 20);
            this.edtNombreL.TabIndex = 0;
            // 
            // edtDescL
            // 
            this.edtDescL.Location = new System.Drawing.Point(96, 74);
            this.edtDescL.Multiline = true;
            this.edtDescL.Name = "edtDescL";
            this.edtDescL.Size = new System.Drawing.Size(259, 67);
            this.edtDescL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DESCRIPCION:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnML);
            this.groupBox3.Controls.Add(this.btnEL);
            this.groupBox3.Controls.Add(this.btnNL);
            this.groupBox3.Controls.Add(this.btnCL);
            this.groupBox3.Controls.Add(this.btnGuardarLinea);
            this.groupBox3.Location = new System.Drawing.Point(411, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 192);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACCION";
            // 
            // btnML
            // 
            this.btnML.Location = new System.Drawing.Point(21, 48);
            this.btnML.Name = "btnML";
            this.btnML.Size = new System.Drawing.Size(75, 23);
            this.btnML.TabIndex = 27;
            this.btnML.Text = "MODIFICAR";
            this.btnML.UseVisualStyleBackColor = true;
            this.btnML.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEL
            // 
            this.btnEL.Location = new System.Drawing.Point(21, 77);
            this.btnEL.Name = "btnEL";
            this.btnEL.Size = new System.Drawing.Size(75, 23);
            this.btnEL.TabIndex = 4;
            this.btnEL.Text = "ELIMINAR";
            this.btnEL.UseVisualStyleBackColor = true;
            this.btnEL.Click += new System.EventHandler(this.btnEliminarL_Click);
            // 
            // btnNL
            // 
            this.btnNL.Location = new System.Drawing.Point(21, 19);
            this.btnNL.Name = "btnNL";
            this.btnNL.Size = new System.Drawing.Size(75, 23);
            this.btnNL.TabIndex = 28;
            this.btnNL.Text = "NUEVO";
            this.btnNL.UseVisualStyleBackColor = true;
            this.btnNL.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCL
            // 
            this.btnCL.Location = new System.Drawing.Point(21, 135);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(75, 24);
            this.btnCL.TabIndex = 26;
            this.btnCL.Text = "CANCELAR";
            this.btnCL.UseVisualStyleBackColor = true;
            this.btnCL.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnGuardarLinea
            // 
            this.btnGuardarLinea.Location = new System.Drawing.Point(21, 106);
            this.btnGuardarLinea.Name = "btnGuardarLinea";
            this.btnGuardarLinea.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarLinea.TabIndex = 3;
            this.btnGuardarLinea.Text = "GUARDAR";
            this.btnGuardarLinea.UseVisualStyleBackColor = true;
            this.btnGuardarLinea.Click += new System.EventHandler(this.btnGuardarLinea_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLinea);
            this.groupBox2.Location = new System.Drawing.Point(18, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 181);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EXPLORADOR";
            // 
            // dgvLinea
            // 
            this.dgvLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinea.EnableHeadersVisualStyles = false;
            this.dgvLinea.Location = new System.Drawing.Point(6, 19);
            this.dgvLinea.MultiSelect = false;
            this.dgvLinea.Name = "dgvLinea";
            this.dgvLinea.ReadOnly = true;
            this.dgvLinea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinea.Size = new System.Drawing.Size(505, 156);
            this.dgvLinea.TabIndex = 2;
            this.dgvLinea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinea_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(556, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MAQUINARIA";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.edtCarM);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.edtFuncM);
            this.groupBox6.Controls.Add(this.cbxLineaM);
            this.groupBox6.Controls.Add(this.edtIndM);
            this.groupBox6.Controls.Add(this.edtCodM);
            this.groupBox6.Controls.Add(this.edtAnhoM);
            this.groupBox6.Controls.Add(this.edtNombreM);
            this.groupBox6.Controls.Add(this.edtMarcaM);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(538, 194);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DATOS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "LINEA PRODUCCION:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "AÑO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CODIGO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "NOMBRE:";
            // 
            // edtCarM
            // 
            this.edtCarM.Location = new System.Drawing.Point(127, 148);
            this.edtCarM.Name = "edtCarM";
            this.edtCarM.Size = new System.Drawing.Size(395, 20);
            this.edtCarM.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "MARCA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "CARACTERISTICAS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "INDUSTRIA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-37, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "LINEA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "FUNCION:";
            // 
            // edtFuncM
            // 
            this.edtFuncM.Location = new System.Drawing.Point(76, 118);
            this.edtFuncM.Name = "edtFuncM";
            this.edtFuncM.Size = new System.Drawing.Size(446, 20);
            this.edtFuncM.TabIndex = 12;
            // 
            // cbxLineaM
            // 
            this.cbxLineaM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLineaM.FormattingEnabled = true;
            this.cbxLineaM.Location = new System.Drawing.Point(348, 90);
            this.cbxLineaM.Name = "cbxLineaM";
            this.cbxLineaM.Size = new System.Drawing.Size(174, 21);
            this.cbxLineaM.TabIndex = 6;
            // 
            // edtIndM
            // 
            this.edtIndM.Location = new System.Drawing.Point(75, 55);
            this.edtIndM.Name = "edtIndM";
            this.edtIndM.Size = new System.Drawing.Size(138, 20);
            this.edtIndM.TabIndex = 11;
            // 
            // edtCodM
            // 
            this.edtCodM.Location = new System.Drawing.Point(76, 23);
            this.edtCodM.Name = "edtCodM";
            this.edtCodM.Size = new System.Drawing.Size(137, 20);
            this.edtCodM.TabIndex = 7;
            // 
            // edtAnhoM
            // 
            this.edtAnhoM.Location = new System.Drawing.Point(265, 58);
            this.edtAnhoM.Name = "edtAnhoM";
            this.edtAnhoM.Size = new System.Drawing.Size(79, 20);
            this.edtAnhoM.TabIndex = 10;
            this.edtAnhoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtAnhoM_KeyPress);
            // 
            // edtNombreM
            // 
            this.edtNombreM.Location = new System.Drawing.Point(285, 23);
            this.edtNombreM.Name = "edtNombreM";
            this.edtNombreM.Size = new System.Drawing.Size(220, 20);
            this.edtNombreM.TabIndex = 8;
            // 
            // edtMarcaM
            // 
            this.edtMarcaM.Location = new System.Drawing.Point(76, 86);
            this.edtMarcaM.Name = "edtMarcaM";
            this.edtMarcaM.Size = new System.Drawing.Size(137, 20);
            this.edtMarcaM.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnNM);
            this.groupBox5.Controls.Add(this.btnCM);
            this.groupBox5.Controls.Add(this.btnGM);
            this.groupBox5.Controls.Add(this.btnEM);
            this.groupBox5.Controls.Add(this.btnMM);
            this.groupBox5.Location = new System.Drawing.Point(447, 227);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(97, 170);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ACCION";
            // 
            // btnNM
            // 
            this.btnNM.Location = new System.Drawing.Point(6, 19);
            this.btnNM.Name = "btnNM";
            this.btnNM.Size = new System.Drawing.Size(75, 23);
            this.btnNM.TabIndex = 28;
            this.btnNM.Text = "NUEVO";
            this.btnNM.UseVisualStyleBackColor = true;
            this.btnNM.Click += new System.EventHandler(this.btnNM_Click);
            // 
            // btnCM
            // 
            this.btnCM.Location = new System.Drawing.Point(6, 135);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(75, 24);
            this.btnCM.TabIndex = 26;
            this.btnCM.Text = "CANCELAR";
            this.btnCM.UseVisualStyleBackColor = true;
            this.btnCM.Click += new System.EventHandler(this.btnCM_Click);
            // 
            // btnGM
            // 
            this.btnGM.Location = new System.Drawing.Point(6, 106);
            this.btnGM.Name = "btnGM";
            this.btnGM.Size = new System.Drawing.Size(75, 23);
            this.btnGM.TabIndex = 24;
            this.btnGM.Text = "GUARDAR";
            this.btnGM.UseVisualStyleBackColor = true;
            this.btnGM.Click += new System.EventHandler(this.btnGM_Click);
            // 
            // btnEM
            // 
            this.btnEM.Location = new System.Drawing.Point(6, 77);
            this.btnEM.Name = "btnEM";
            this.btnEM.Size = new System.Drawing.Size(75, 23);
            this.btnEM.TabIndex = 25;
            this.btnEM.Text = "ELIMINAR";
            this.btnEM.UseVisualStyleBackColor = true;
            this.btnEM.Click += new System.EventHandler(this.btnEM_Click);
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(6, 48);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(75, 23);
            this.btnMM.TabIndex = 27;
            this.btnMM.Text = "MODIFICAR";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMaquina);
            this.groupBox1.Location = new System.Drawing.Point(6, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 175);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EXPLORADOR";
            // 
            // dgvMaquina
            // 
            this.dgvMaquina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquina.Location = new System.Drawing.Point(11, 19);
            this.dgvMaquina.MultiSelect = false;
            this.dgvMaquina.Name = "dgvMaquina";
            this.dgvMaquina.ReadOnly = true;
            this.dgvMaquina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaquina.Size = new System.Drawing.Size(391, 142);
            this.dgvMaquina.TabIndex = 0;
            this.dgvMaquina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaquina_CellClick);
            // 
            // PProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 433);
            this.Controls.Add(this.tabMaquinaria);
            this.Name = "PProceso";
            this.Text = "LINEA DE PRODUCCION Y MAQUINARIA";
            this.Load += new System.EventHandler(this.PProceso_Load);
            this.tabMaquinaria.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinea)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMaquinaria;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLinea;
        private System.Windows.Forms.TextBox edtDescL;
        private System.Windows.Forms.TextBox edtNombreL;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEL;
        private System.Windows.Forms.Button btnGuardarLinea;
        private System.Windows.Forms.ComboBox cbxLineaM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtCarM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtFuncM;
        private System.Windows.Forms.TextBox edtIndM;
        private System.Windows.Forms.TextBox edtAnhoM;
        private System.Windows.Forms.TextBox edtMarcaM;
        private System.Windows.Forms.TextBox edtNombreM;
        private System.Windows.Forms.TextBox edtCodM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMaquina;
        private System.Windows.Forms.Button btnNL;
        private System.Windows.Forms.Button btnML;
        private System.Windows.Forms.Button btnCL;
        private System.Windows.Forms.Button btnEM;
        private System.Windows.Forms.Button btnNM;
        private System.Windows.Forms.Button btnGM;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}