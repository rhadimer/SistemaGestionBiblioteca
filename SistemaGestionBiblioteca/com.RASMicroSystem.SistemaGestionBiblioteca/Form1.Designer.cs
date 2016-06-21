namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip_Menu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton_Consultas = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_consultarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarBibliotecarioToolStripMenuItem_consultarBibliotecario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.label_minimizar = new System.Windows.Forms.Label();
            this.label_cerrar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip_Menu
            // 
            this.toolStrip_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip_Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_Menu.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.toolStrip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton2,
            this.toolStripDropDownButton_Consultas,
            this.toolStripButton4,
            this.toolStripButton3});
            this.toolStrip_Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip_Menu.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Menu.Name = "toolStrip_Menu";
            this.toolStrip_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip_Menu.Size = new System.Drawing.Size(114, 615);
            this.toolStrip_Menu.TabIndex = 0;
            this.toolStrip_Menu.Text = "Menu";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ForeColor = System.Drawing.Color.Coral;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(111, 119);
            this.toolStripButton5.Text = "Estado";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.Coral;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(111, 119);
            this.toolStripButton2.Text = "Libros";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripDropDownButton_Consultas
            // 
            this.toolStripDropDownButton_Consultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_consultarUsuario,
            this.consultarBibliotecarioToolStripMenuItem_consultarBibliotecario});
            this.toolStripDropDownButton_Consultas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton_Consultas.ForeColor = System.Drawing.Color.Coral;
            this.toolStripDropDownButton_Consultas.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_Consultas.Image")));
            this.toolStripDropDownButton_Consultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Consultas.Name = "toolStripDropDownButton_Consultas";
            this.toolStripDropDownButton_Consultas.Size = new System.Drawing.Size(111, 119);
            this.toolStripDropDownButton_Consultas.Text = "Personas";
            this.toolStripDropDownButton_Consultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem_consultarUsuario
            // 
            this.toolStripMenuItem_consultarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem_consultarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_consultarUsuario.Image")));
            this.toolStripMenuItem_consultarUsuario.Name = "toolStripMenuItem_consultarUsuario";
            this.toolStripMenuItem_consultarUsuario.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItem_consultarUsuario.Text = "Consultar Usuarios";
            this.toolStripMenuItem_consultarUsuario.Click += new System.EventHandler(this.toolStripMenuItem_consultarUsuario_Click);
            // 
            // consultarBibliotecarioToolStripMenuItem_consultarBibliotecario
            // 
            this.consultarBibliotecarioToolStripMenuItem_consultarBibliotecario.BackColor = System.Drawing.Color.Maroon;
            this.consultarBibliotecarioToolStripMenuItem_consultarBibliotecario.Image = ((System.Drawing.Image)(resources.GetObject("consultarBibliotecarioToolStripMenuItem_consultarBibliotecario.Image")));
            this.consultarBibliotecarioToolStripMenuItem_consultarBibliotecario.Name = "consultarBibliotecarioToolStripMenuItem_consultarBibliotecario";
            this.consultarBibliotecarioToolStripMenuItem_consultarBibliotecario.Size = new System.Drawing.Size(194, 22);
            this.consultarBibliotecarioToolStripMenuItem_consultarBibliotecario.Text = "Consultar Bibliotecario";
            this.consultarBibliotecarioToolStripMenuItem_consultarBibliotecario.Click += new System.EventHandler(this.consultarBibliotecarioToolStripMenuItem_consultarBibliotecario_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ForeColor = System.Drawing.Color.Coral;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(111, 119);
            this.toolStripButton4.Text = "Prestamo";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.Coral;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(111, 119);
            this.toolStripButton3.Text = "Devoluciones";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.Color.White;
            this.panel_Contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Contenedor.Location = new System.Drawing.Point(114, 61);
            this.panel_Contenedor.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(822, 553);
            this.panel_Contenedor.TabIndex = 1;
            // 
            // label_minimizar
            // 
            this.label_minimizar.AutoSize = true;
            this.label_minimizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minimizar.Location = new System.Drawing.Point(845, 1);
            this.label_minimizar.Name = "label_minimizar";
            this.label_minimizar.Size = new System.Drawing.Size(36, 37);
            this.label_minimizar.TabIndex = 37;
            this.label_minimizar.Text = "_";
            this.label_minimizar.Click += new System.EventHandler(this.label_minimizar_Click_1);
            this.label_minimizar.MouseEnter += new System.EventHandler(this.label_minimizar_MouseEnter);
            this.label_minimizar.MouseLeave += new System.EventHandler(this.label_minimizar_MouseLeave);
            // 
            // label_cerrar
            // 
            this.label_cerrar.AutoSize = true;
            this.label_cerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cerrar.Location = new System.Drawing.Point(886, 9);
            this.label_cerrar.Name = "label_cerrar";
            this.label_cerrar.Size = new System.Drawing.Size(38, 37);
            this.label_cerrar.TabIndex = 36;
            this.label_cerrar.Text = "X";
            this.label_cerrar.Click += new System.EventHandler(this.label_cerrar_Click_1);
            this.label_cerrar.MouseEnter += new System.EventHandler(this.label_cerrar_MouseEnter);
            this.label_cerrar.MouseLeave += new System.EventHandler(this.label_cerrar_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(236, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bodoni MT Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(114, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(822, 61);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sistema De Gestión Bibliotecario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label4_MouseUp);
            // 
            // FormPrincipal
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 615);
            this.Controls.Add(this.label_minimizar);
            this.Controls.Add(this.label_cerrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.toolStrip_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestor Bibliotecario v1.0";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.toolStrip_Menu.ResumeLayout(false);
            this.toolStrip_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarBibliotecariosToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip_Menu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_Consultas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_consultarUsuario;
        private System.Windows.Forms.ToolStripMenuItem consultarBibliotecarioToolStripMenuItem_consultarBibliotecario;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label label_minimizar;
        private System.Windows.Forms.Label label_cerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Panel panel_Contenedor;

    }
}

