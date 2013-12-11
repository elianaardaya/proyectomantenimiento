namespace proyectoMantenimiento
{
    partial class Form1
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
            this.btnAcceso = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnMaq = new System.Windows.Forms.Button();
            this.btnMante = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcceso
            // 
            this.btnAcceso.Enabled = false;
            this.btnAcceso.Location = new System.Drawing.Point(43, 37);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(124, 58);
            this.btnAcceso.TabIndex = 0;
            this.btnAcceso.Text = "GESTIONAR ACCESO";
            this.btnAcceso.UseVisualStyleBackColor = true;
            this.btnAcceso.Click += new System.EventHandler(this.btnAcceso_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Enabled = false;
            this.btnConfig.Location = new System.Drawing.Point(43, 121);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(124, 60);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "CONFIGURACIONES";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMaq
            // 
            this.btnMaq.Enabled = false;
            this.btnMaq.Location = new System.Drawing.Point(219, 37);
            this.btnMaq.Name = "btnMaq";
            this.btnMaq.Size = new System.Drawing.Size(113, 58);
            this.btnMaq.TabIndex = 2;
            this.btnMaq.Text = "GESTIONAR MAQUINARIA";
            this.btnMaq.UseVisualStyleBackColor = true;
            this.btnMaq.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMante
            // 
            this.btnMante.Enabled = false;
            this.btnMante.Location = new System.Drawing.Point(358, 37);
            this.btnMante.Name = "btnMante";
            this.btnMante.Size = new System.Drawing.Size(124, 58);
            this.btnMante.TabIndex = 3;
            this.btnMante.Text = "REGISTRO DE MANTENIMIENTO";
            this.btnMante.UseVisualStyleBackColor = true;
            this.btnMante.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Enabled = false;
            this.btnReportes.Location = new System.Drawing.Point(219, 218);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(107, 54);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "CONSULTAS Y REPORTES";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.Enabled = false;
            this.btnPermisos.Location = new System.Drawing.Point(358, 121);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(124, 60);
            this.btnPermisos.TabIndex = 5;
            this.btnPermisos.Text = "GESTION DE PERMISOS";
            this.btnPermisos.UseVisualStyleBackColor = true;
            this.btnPermisos.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnInv
            // 
            this.btnInv.Enabled = false;
            this.btnInv.Location = new System.Drawing.Point(219, 121);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(113, 60);
            this.btnInv.TabIndex = 6;
            this.btnInv.Text = "GESTION DE INVENTARIO";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 310);
            this.Controls.Add(this.btnInv);
            this.Controls.Add(this.btnPermisos);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnMante);
            this.Controls.Add(this.btnMaq);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnAcceso);
            this.Name = "Form1";
            this.Text = "FORMULARIO PRINCIPAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcceso;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnMaq;
        private System.Windows.Forms.Button btnMante;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Button btnInv;
    }
}

