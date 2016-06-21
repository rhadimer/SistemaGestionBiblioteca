namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    partial class FormAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutor));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nacionalidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_fotografia = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_examinar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fotografia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(615, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.SteelBlue;
            this.label24.Dock = System.Windows.Forms.DockStyle.Top;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(673, 37);
            this.label24.TabIndex = 56;
            this.label24.Text = "Registro de Autores";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nombre";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_nombre.Location = new System.Drawing.Point(152, 54);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(166, 20);
            this.textBox_nombre.TabIndex = 59;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_apellido.Location = new System.Drawing.Point(152, 141);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(166, 20);
            this.textBox_apellido.TabIndex = 61;
            this.textBox_apellido.TextChanged += new System.EventHandler(this.textBox_apellido_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Apellido";
            // 
            // textBox_nacionalidad
            // 
            this.textBox_nacionalidad.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_nacionalidad.Location = new System.Drawing.Point(152, 98);
            this.textBox_nacionalidad.Name = "textBox_nacionalidad";
            this.textBox_nacionalidad.Size = new System.Drawing.Size(166, 20);
            this.textBox_nacionalidad.TabIndex = 63;
            this.textBox_nacionalidad.TextChanged += new System.EventHandler(this.textBox_nacionalidad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Nacionalidad";
            // 
            // pictureBox_fotografia
            // 
            this.pictureBox_fotografia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_fotografia.BackgroundImage")));
            this.pictureBox_fotografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_fotografia.Location = new System.Drawing.Point(6, 19);
            this.pictureBox_fotografia.Name = "pictureBox_fotografia";
            this.pictureBox_fotografia.Size = new System.Drawing.Size(188, 154);
            this.pictureBox_fotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_fotografia.TabIndex = 64;
            this.pictureBox_fotografia.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_examinar);
            this.groupBox1.Controls.Add(this.pictureBox_fotografia);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 272);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR FOTOGRACIA";
            // 
            // button_examinar
            // 
            this.button_examinar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_examinar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_examinar.ForeColor = System.Drawing.Color.White;
            this.button_examinar.Image = ((System.Drawing.Image)(resources.GetObject("button_examinar.Image")));
            this.button_examinar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_examinar.Location = new System.Drawing.Point(36, 202);
            this.button_examinar.Name = "button_examinar";
            this.button_examinar.Size = new System.Drawing.Size(127, 41);
            this.button_examinar.TabIndex = 65;
            this.button_examinar.Text = "Examinar";
            this.button_examinar.UseVisualStyleBackColor = false;
            this.button_examinar.Click += new System.EventHandler(this.button_examinar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_nombre);
            this.groupBox2.Controls.Add(this.textBox_nacionalidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_apellido);
            this.groupBox2.Location = new System.Drawing.Point(230, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 199);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INGRESAR DATOS";
            // 
            // button_limpiar
            // 
            this.button_limpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_limpiar.ForeColor = System.Drawing.Color.White;
            this.button_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("button_limpiar.Image")));
            this.button_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_limpiar.Location = new System.Drawing.Point(230, 285);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(127, 41);
            this.button_limpiar.TabIndex = 68;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = false;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancelar.ForeColor = System.Drawing.Color.White;
            this.button_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("button_cancelar.Image")));
            this.button_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancelar.Location = new System.Drawing.Point(525, 285);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(127, 41);
            this.button_cancelar.TabIndex = 69;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_guardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_guardar.ForeColor = System.Drawing.Color.White;
            this.button_guardar.Image = ((System.Drawing.Image)(resources.GetObject("button_guardar.Image")));
            this.button_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guardar.Location = new System.Drawing.Point(377, 285);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(127, 41);
            this.button_guardar.TabIndex = 67;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = false;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 355);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label24);
            this.Name = "FormAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAutor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fotografia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nacionalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_fotografia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_examinar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}