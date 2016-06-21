namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    partial class FormUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_examinar = new System.Windows.Forms.Button();
            this.pictureBox_fotografia = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox_cedula = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telefono = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_foto = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fotografia)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_examinar);
            this.groupBox1.Controls.Add(this.pictureBox_fotografia);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 278);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR FOTOGRAFIA";
            // 
            // button_examinar
            // 
            this.button_examinar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_examinar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_examinar.ForeColor = System.Drawing.Color.White;
            this.button_examinar.Image = ((System.Drawing.Image)(resources.GetObject("button_examinar.Image")));
            this.button_examinar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_examinar.Location = new System.Drawing.Point(47, 216);
            this.button_examinar.Name = "button_examinar";
            this.button_examinar.Size = new System.Drawing.Size(127, 41);
            this.button_examinar.TabIndex = 9;
            this.button_examinar.Text = "Examinar";
            this.toolTip1.SetToolTip(this.button_examinar, "Buscar la fotografia");
            this.button_examinar.UseVisualStyleBackColor = false;
            this.button_examinar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_fotografia
            // 
            this.pictureBox_fotografia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_fotografia.BackgroundImage")));
            this.pictureBox_fotografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_fotografia.Location = new System.Drawing.Point(6, 19);
            this.pictureBox_fotografia.Name = "pictureBox_fotografia";
            this.pictureBox_fotografia.Size = new System.Drawing.Size(211, 184);
            this.pictureBox_fotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_fotografia.TabIndex = 0;
            this.pictureBox_fotografia.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_fotografia, "Fotografia del usuario");
            this.pictureBox_fotografia.Click += new System.EventHandler(this.pictureBox_fotografia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.maskedTextBox_cedula);
            this.groupBox2.Controls.Add(this.maskedTextBox_telefono);
            this.groupBox2.Controls.Add(this.comboBox_categoria);
            this.groupBox2.Controls.Add(this.dateTimePicker_fecha);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_email);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_direccion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_apellido);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_nombre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(252, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 278);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INGRESAR DATOS";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(386, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 132);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(228, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "*";
            this.toolTip1.SetToolTip(this.label16, "Campos Obligatorios");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(41, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(255, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "NOTA: Los campos con (*) son obligatorios.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(182, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "*";
            this.toolTip1.SetToolTip(this.label13, "Campos Obligatorios");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(324, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "*";
            this.toolTip1.SetToolTip(this.label12, "Campos Obligatorios");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(324, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "*";
            this.toolTip1.SetToolTip(this.label11, "Campos Obligatorios");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(277, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "*";
            this.toolTip1.SetToolTip(this.label10, "Campos Obligatorios");
            // 
            // maskedTextBox_cedula
            // 
            this.maskedTextBox_cedula.BackColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox_cedula.Location = new System.Drawing.Point(99, 176);
            this.maskedTextBox_cedula.Mask = "000-0000000-0";
            this.maskedTextBox_cedula.Name = "maskedTextBox_cedula";
            this.maskedTextBox_cedula.Size = new System.Drawing.Size(84, 20);
            this.maskedTextBox_cedula.TabIndex = 7;
            this.maskedTextBox_cedula.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_cedula_MaskInputRejected);
            // 
            // maskedTextBox_telefono
            // 
            this.maskedTextBox_telefono.BackColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox_telefono.Location = new System.Drawing.Point(99, 124);
            this.maskedTextBox_telefono.Mask = "000-000-0000";
            this.maskedTextBox_telefono.Name = "maskedTextBox_telefono";
            this.maskedTextBox_telefono.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBox_telefono.TabIndex = 5;
            this.maskedTextBox_telefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_telefono_MaskInputRejected);
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Items.AddRange(new object[] {
            "Profesor",
            "Estudiante"});
            this.comboBox_categoria.Location = new System.Drawing.Point(101, 202);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(121, 21);
            this.comboBox_categoria.TabIndex = 8;
            this.comboBox_categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_categoria_SelectedIndexChanged);
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(118, 149);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker_fecha.TabIndex = 6;
            this.dateTimePicker_fecha.TextChanged += new System.EventHandler(this.dateTimePicker_fecha_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Categoria";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cedula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha de nacimineto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_email.Location = new System.Drawing.Point(99, 98);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(219, 20);
            this.textBox_email.TabIndex = 4;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dirección";
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_direccion.Location = new System.Drawing.Point(99, 72);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(219, 20);
            this.textBox_direccion.TabIndex = 3;
            this.textBox_direccion.TextChanged += new System.EventHandler(this.textBox_direccion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos ";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_apellido.Location = new System.Drawing.Point(99, 46);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(219, 20);
            this.textBox_apellido.TabIndex = 2;
            this.textBox_apellido.TextChanged += new System.EventHandler(this.textBox_apellido_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_nombre.Location = new System.Drawing.Point(99, 20);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(172, 20);
            this.textBox_nombre.TabIndex = 1;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            // 
            // button_guardar
            // 
            this.button_guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_guardar.ForeColor = System.Drawing.Color.White;
            this.button_guardar.Image = ((System.Drawing.Image)(resources.GetObject("button_guardar.Image")));
            this.button_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guardar.Location = new System.Drawing.Point(332, 373);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(127, 41);
            this.button_guardar.TabIndex = 10;
            this.button_guardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.button_guardar, "Guardar los datos");
            this.button_guardar.UseVisualStyleBackColor = false;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancelar.ForeColor = System.Drawing.Color.White;
            this.button_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("button_cancelar.Image")));
            this.button_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancelar.Location = new System.Drawing.Point(602, 373);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(127, 41);
            this.button_cancelar.TabIndex = 12;
            this.button_cancelar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.button_cancelar, "Cancelar el registro de usuario");
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_limpiar
            // 
            this.button_limpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_limpiar.ForeColor = System.Drawing.Color.White;
            this.button_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("button_limpiar.Image")));
            this.button_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_limpiar.Location = new System.Drawing.Point(59, 373);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(127, 41);
            this.button_limpiar.TabIndex = 11;
            this.button_limpiar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.button_limpiar, "Limpiar todos los campos");
            this.button_limpiar.UseVisualStyleBackColor = false;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(731, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.pictureBox_foto);
            this.groupBox3.Location = new System.Drawing.Point(12, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 278);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INGRESAR FOTOGRAFIA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(47, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_foto
            // 
            this.pictureBox_foto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_foto.BackgroundImage")));
            this.pictureBox_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_foto.Location = new System.Drawing.Point(6, 19);
            this.pictureBox_foto.Name = "pictureBox_foto";
            this.pictureBox_foto.Size = new System.Drawing.Size(211, 184);
            this.pictureBox_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_foto.TabIndex = 0;
            this.pictureBox_foto.TabStop = false;
            this.pictureBox_foto.Click += new System.EventHandler(this.pictureBox_fotografia_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(332, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(602, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(59, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 41);
            this.button4.TabIndex = 11;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 448);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fotografia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_examinar;
        private System.Windows.Forms.PictureBox pictureBox_fotografia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cedula;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefono;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox_foto;
    }
}