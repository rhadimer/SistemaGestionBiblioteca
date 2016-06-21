namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    partial class FormPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestamo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_cedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_categoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox_fotografia = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_prestadoPor = new System.Windows.Forms.ComboBox();
            this.tblBibliotecarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet();
            this.maskedTextBox_horaEntrega = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_horaPrestamo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_listaLibros = new System.Windows.Forms.ComboBox();
            this.tblLibroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tblLibroTableAdapter = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSetTableAdapters.tblLibroTableAdapter();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox_imagenLibro = new System.Windows.Forms.PictureBox();
            this.tblBibliotecarioTableAdapter = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSetTableAdapters.tblBibliotecarioTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fotografia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBibliotecarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLibroBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagenLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_telefono);
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_direccion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_cedula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_categoria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_apellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL LECTOR";
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_email.Location = new System.Drawing.Point(383, 101);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.ReadOnly = true;
            this.textBox_email.Size = new System.Drawing.Size(253, 20);
            this.textBox_email.TabIndex = 61;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Email";
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_telefono.Location = new System.Drawing.Point(85, 101);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.ReadOnly = true;
            this.textBox_telefono.Size = new System.Drawing.Size(100, 20);
            this.textBox_telefono.TabIndex = 59;
            this.textBox_telefono.TextChanged += new System.EventHandler(this.textBox_telefono_TextChanged);
            // 
            // button_buscar
            // 
            this.button_buscar.Enabled = false;
            this.button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_buscar.Image = ((System.Drawing.Image)(resources.GetObject("button_buscar.Image")));
            this.button_buscar.Location = new System.Drawing.Point(191, 9);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(48, 34);
            this.button_buscar.TabIndex = 12;
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Teléfono";
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_direccion.Location = new System.Drawing.Point(383, 75);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.ReadOnly = true;
            this.textBox_direccion.Size = new System.Drawing.Size(253, 20);
            this.textBox_direccion.TabIndex = 11;
            this.textBox_direccion.TextChanged += new System.EventHandler(this.textBox_direccion_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección";
            // 
            // textBox_cedula
            // 
            this.textBox_cedula.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_cedula.Location = new System.Drawing.Point(383, 49);
            this.textBox_cedula.Name = "textBox_cedula";
            this.textBox_cedula.ReadOnly = true;
            this.textBox_cedula.Size = new System.Drawing.Size(100, 20);
            this.textBox_cedula.TabIndex = 9;
            this.textBox_cedula.TextChanged += new System.EventHandler(this.textBox_cedula_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cedula";
            // 
            // textBox_categoria
            // 
            this.textBox_categoria.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_categoria.Location = new System.Drawing.Point(383, 23);
            this.textBox_categoria.Name = "textBox_categoria";
            this.textBox_categoria.ReadOnly = true;
            this.textBox_categoria.Size = new System.Drawing.Size(100, 20);
            this.textBox_categoria.TabIndex = 7;
            this.textBox_categoria.TextChanged += new System.EventHandler(this.textBox_categoria_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria Lector";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_apellido.Location = new System.Drawing.Point(85, 75);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.ReadOnly = true;
            this.textBox_apellido.Size = new System.Drawing.Size(200, 20);
            this.textBox_apellido.TabIndex = 5;
            this.textBox_apellido.TextChanged += new System.EventHandler(this.textBox_apellido_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_nombre.Location = new System.Drawing.Point(85, 49);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.ReadOnly = true;
            this.textBox_nombre.Size = new System.Drawing.Size(200, 20);
            this.textBox_nombre.TabIndex = 3;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nomber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre ";
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_id.Location = new System.Drawing.Point(85, 23);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 1;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Lector";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(840, 1);
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
            this.label24.Size = new System.Drawing.Size(893, 37);
            this.label24.TabIndex = 56;
            this.label24.Text = "Registro de Préstamo";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_fotografia
            // 
            this.pictureBox_fotografia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_fotografia.BackgroundImage")));
            this.pictureBox_fotografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_fotografia.Location = new System.Drawing.Point(27, 19);
            this.pictureBox_fotografia.Name = "pictureBox_fotografia";
            this.pictureBox_fotografia.Size = new System.Drawing.Size(149, 135);
            this.pictureBox_fotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_fotografia.TabIndex = 62;
            this.pictureBox_fotografia.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox_fotografia);
            this.groupBox2.Location = new System.Drawing.Point(682, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 165);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FOTOGRAFIA DEL LECTOR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_prestadoPor);
            this.groupBox3.Controls.Add(this.maskedTextBox_horaEntrega);
            this.groupBox3.Controls.Add(this.maskedTextBox_horaPrestamo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.comboBox_listaLibros);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dateTimePicker_fecha);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 299);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DE PRESTAMO";
            // 
            // comboBox_prestadoPor
            // 
            this.comboBox_prestadoPor.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox_prestadoPor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblBibliotecarioBindingSource, "nombre", true));
            this.comboBox_prestadoPor.DataSource = this.tblBibliotecarioBindingSource;
            this.comboBox_prestadoPor.DisplayMember = "nombre";
            this.comboBox_prestadoPor.FormattingEnabled = true;
            this.comboBox_prestadoPor.Location = new System.Drawing.Point(410, 48);
            this.comboBox_prestadoPor.Name = "comboBox_prestadoPor";
            this.comboBox_prestadoPor.Size = new System.Drawing.Size(121, 21);
            this.comboBox_prestadoPor.TabIndex = 22;
            this.comboBox_prestadoPor.ValueMember = "nombre";
            this.comboBox_prestadoPor.SelectedIndexChanged += new System.EventHandler(this.comboBox_prestadoPor_SelectedIndexChanged);
            // 
            // tblBibliotecarioBindingSource
            // 
            this.tblBibliotecarioBindingSource.DataMember = "tblBibliotecario";
            this.tblBibliotecarioBindingSource.DataSource = this.sGBibliotecarioDataSetBindingSource;
            // 
            // sGBibliotecarioDataSetBindingSource
            // 
            this.sGBibliotecarioDataSetBindingSource.DataSource = this.sGBibliotecarioDataSet;
            this.sGBibliotecarioDataSetBindingSource.Position = 0;
            // 
            // sGBibliotecarioDataSet
            // 
            this.sGBibliotecarioDataSet.DataSetName = "SGBibliotecarioDataSet";
            this.sGBibliotecarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBox_horaEntrega
            // 
            this.maskedTextBox_horaEntrega.BackColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox_horaEntrega.Location = new System.Drawing.Point(410, 74);
            this.maskedTextBox_horaEntrega.Mask = "00:00";
            this.maskedTextBox_horaEntrega.Name = "maskedTextBox_horaEntrega";
            this.maskedTextBox_horaEntrega.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_horaEntrega.TabIndex = 21;
            this.maskedTextBox_horaEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_horaPrestamo
            // 
            this.maskedTextBox_horaPrestamo.BackColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox_horaPrestamo.Location = new System.Drawing.Point(97, 72);
            this.maskedTextBox_horaPrestamo.Mask = "00:00";
            this.maskedTextBox_horaPrestamo.Name = "maskedTextBox_horaPrestamo";
            this.maskedTextBox_horaPrestamo.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_horaPrestamo.TabIndex = 20;
            this.maskedTextBox_horaPrestamo.ValidatingType = typeof(System.DateTime);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(334, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Hora Entrega";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Hora Préstamo";
            // 
            // comboBox_listaLibros
            // 
            this.comboBox_listaLibros.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox_listaLibros.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblLibroBindingSource, "titulo_original", true));
            this.comboBox_listaLibros.FormattingEnabled = true;
            this.comboBox_listaLibros.Location = new System.Drawing.Point(97, 98);
            this.comboBox_listaLibros.Name = "comboBox_listaLibros";
            this.comboBox_listaLibros.Size = new System.Drawing.Size(235, 21);
            this.comboBox_listaLibros.TabIndex = 16;
            this.comboBox_listaLibros.SelectedIndexChanged += new System.EventHandler(this.comboBox_listaLibros_SelectedIndexChanged_1);
            // 
            // tblLibroBindingSource
            // 
            this.tblLibroBindingSource.DataMember = "tblLibro";
            this.tblLibroBindingSource.DataSource = this.sGBibliotecarioDataSet;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(6, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(548, 130);
            this.listBox1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(317, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Quitar libro";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(97, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Agregar libro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Titulo de Libro";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Info;
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(96, 19);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 9;
            this.textBox11.Text = "Nuevo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Código Prestamo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Prestado por";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Info;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.Red;
            this.textBox9.Location = new System.Drawing.Point(410, 22);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 5;
            this.textBox9.Text = "Prestado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Estado";
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Enabled = false;
            this.dateTimePicker_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(96, 45);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker_fecha.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fecha Préstamo";
            // 
            // tblLibroTableAdapter
            // 
            this.tblLibroTableAdapter.ClearBeforeFill = true;
            // 
            // button_limpiar
            // 
            this.button_limpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_limpiar.ForeColor = System.Drawing.Color.White;
            this.button_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("button_limpiar.Image")));
            this.button_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_limpiar.Location = new System.Drawing.Point(45, 557);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(127, 41);
            this.button_limpiar.TabIndex = 66;
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
            this.button_cancelar.Location = new System.Drawing.Point(650, 557);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(127, 41);
            this.button_cancelar.TabIndex = 67;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_guardar.ForeColor = System.Drawing.Color.White;
            this.button_guardar.Image = ((System.Drawing.Image)(resources.GetObject("button_guardar.Image")));
            this.button_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guardar.Location = new System.Drawing.Point(351, 557);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(127, 41);
            this.button_guardar.TabIndex = 65;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = false;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox_imagenLibro);
            this.groupBox4.Location = new System.Drawing.Point(598, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 299);
            this.groupBox4.TabIndex = 68;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PORTADA LIBRO";
            // 
            // pictureBox_imagenLibro
            // 
            this.pictureBox_imagenLibro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_imagenLibro.BackgroundImage")));
            this.pictureBox_imagenLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_imagenLibro.Location = new System.Drawing.Point(22, 22);
            this.pictureBox_imagenLibro.Name = "pictureBox_imagenLibro";
            this.pictureBox_imagenLibro.Size = new System.Drawing.Size(238, 268);
            this.pictureBox_imagenLibro.TabIndex = 0;
            this.pictureBox_imagenLibro.TabStop = false;
            // 
            // tblBibliotecarioTableAdapter
            // 
            this.tblBibliotecarioTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 610);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrestamo";
            this.Load += new System.EventHandler(this.FormPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fotografia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBibliotecarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLibroBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagenLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_cedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_categoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.PictureBox pictureBox_fotografia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource sGBibliotecarioDataSetBindingSource;
        private SGBibliotecarioDataSet sGBibliotecarioDataSet;
        private System.Windows.Forms.BindingSource tblLibroBindingSource;
        private SGBibliotecarioDataSetTableAdapters.tblLibroTableAdapter tblLibroTableAdapter;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox_imagenLibro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox_listaLibros;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_horaEntrega;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_horaPrestamo;
        private System.Windows.Forms.ComboBox comboBox_prestadoPor;
        private System.Windows.Forms.BindingSource tblBibliotecarioBindingSource;
        private SGBibliotecarioDataSetTableAdapters.tblBibliotecarioTableAdapter tblBibliotecarioTableAdapter;
    }
}