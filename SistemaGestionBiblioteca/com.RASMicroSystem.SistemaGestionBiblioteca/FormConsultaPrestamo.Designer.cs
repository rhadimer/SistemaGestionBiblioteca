namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    partial class FormConsultaPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaPrestamo));
            this.button_buscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_codigoPrestamo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_prestadoPor = new System.Windows.Forms.TextBox();
            this.textBox_fecha = new System.Windows.Forms.TextBox();
            this.maskedTextBox_horaEntrega = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_horaPrestamo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_estado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoLectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreBibliotecarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewLibrosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet3VistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet3_Vistas = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet3_Vistas();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.view_LibrosPrestadosTableAdapter = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet3_VistasTableAdapters.View_LibrosPrestadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLibrosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet3VistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet3_Vistas)).BeginInit();
            this.SuspendLayout();
            // 
            // button_buscar
            // 
            this.button_buscar.BackColor = System.Drawing.Color.Coral;
            this.button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscar.ForeColor = System.Drawing.Color.White;
            this.button_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_buscar.Location = new System.Drawing.Point(681, 31);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(98, 40);
            this.button_buscar.TabIndex = 8;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = false;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_codigoPrestamo
            // 
            this.textBox_codigoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_codigoPrestamo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_codigoPrestamo.Location = new System.Drawing.Point(421, 36);
            this.textBox_codigoPrestamo.Name = "textBox_codigoPrestamo";
            this.textBox_codigoPrestamo.Size = new System.Drawing.Size(254, 29);
            this.textBox_codigoPrestamo.TabIndex = 6;
            this.textBox_codigoPrestamo.Text = "Buscar Por Codigo Prestamo";
            this.textBox_codigoPrestamo.TextChanged += new System.EventHandler(this.textBox_codigoPrestamo_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(800, 87);
            this.label1.TabIndex = 5;
            this.label1.Text = "Préstamo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_prestadoPor);
            this.groupBox3.Controls.Add(this.textBox_fecha);
            this.groupBox3.Controls.Add(this.maskedTextBox_horaEntrega);
            this.groupBox3.Controls.Add(this.maskedTextBox_horaPrestamo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox_estado);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(7, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 93);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DE PRESTAMO";
            // 
            // textBox_prestadoPor
            // 
            this.textBox_prestadoPor.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_prestadoPor.Location = new System.Drawing.Point(613, 22);
            this.textBox_prestadoPor.Name = "textBox_prestadoPor";
            this.textBox_prestadoPor.ReadOnly = true;
            this.textBox_prestadoPor.Size = new System.Drawing.Size(100, 20);
            this.textBox_prestadoPor.TabIndex = 23;
            // 
            // textBox_fecha
            // 
            this.textBox_fecha.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_fecha.Location = new System.Drawing.Point(97, 21);
            this.textBox_fecha.Name = "textBox_fecha";
            this.textBox_fecha.ReadOnly = true;
            this.textBox_fecha.Size = new System.Drawing.Size(100, 20);
            this.textBox_fecha.TabIndex = 22;
            // 
            // maskedTextBox_horaEntrega
            // 
            this.maskedTextBox_horaEntrega.BackColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox_horaEntrega.Location = new System.Drawing.Point(349, 56);
            this.maskedTextBox_horaEntrega.Mask = "00:00";
            this.maskedTextBox_horaEntrega.Name = "maskedTextBox_horaEntrega";
            this.maskedTextBox_horaEntrega.ReadOnly = true;
            this.maskedTextBox_horaEntrega.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_horaEntrega.TabIndex = 21;
            this.maskedTextBox_horaEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_horaPrestamo
            // 
            this.maskedTextBox_horaPrestamo.BackColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox_horaPrestamo.Location = new System.Drawing.Point(97, 51);
            this.maskedTextBox_horaPrestamo.Mask = "00:00";
            this.maskedTextBox_horaPrestamo.Name = "maskedTextBox_horaPrestamo";
            this.maskedTextBox_horaPrestamo.ReadOnly = true;
            this.maskedTextBox_horaPrestamo.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_horaPrestamo.TabIndex = 20;
            this.maskedTextBox_horaPrestamo.ValidatingType = typeof(System.DateTime);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(273, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Hora Entrega";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(13, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Hora Préstamo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(540, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Prestado por";
            // 
            // textBox_estado
            // 
            this.textBox_estado.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_estado.ForeColor = System.Drawing.Color.Red;
            this.textBox_estado.Location = new System.Drawing.Point(349, 22);
            this.textBox_estado.Name = "textBox_estado";
            this.textBox_estado.ReadOnly = true;
            this.textBox_estado.Size = new System.Drawing.Size(100, 20);
            this.textBox_estado.TabIndex = 5;
            this.textBox_estado.Text = "Prestado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(303, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(7, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fecha Préstamo";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(641, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Devolver Libro";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.Color.White;
            this.button_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("button_cancelar.Image")));
            this.button_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancelar.Location = new System.Drawing.Point(271, 494);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(127, 41);
            this.button_cancelar.TabIndex = 68;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Visible = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_nuevo
            // 
            this.button_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.button_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo.ForeColor = System.Drawing.Color.White;
            this.button_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("button_nuevo.Image")));
            this.button_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nuevo.Location = new System.Drawing.Point(642, 494);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(127, 41);
            this.button_nuevo.TabIndex = 69;
            this.button_nuevo.Text = "Nuevo ";
            this.button_nuevo.UseVisualStyleBackColor = false;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(7, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 293);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LISTADO DE PRESTAMOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoPrestamoDataGridViewTextBoxColumn,
            this.codigoLibroDataGridViewTextBoxColumn,
            this.tituloLibroDataGridViewTextBoxColumn,
            this.nombreLectorDataGridViewTextBoxColumn,
            this.apellidoLectorDataGridViewTextBoxColumn,
            this.nombreBibliotecarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewLibrosPrestadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(769, 237);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codigoPrestamoDataGridViewTextBoxColumn
            // 
            this.codigoPrestamoDataGridViewTextBoxColumn.DataPropertyName = "Codigo Prestamo";
            this.codigoPrestamoDataGridViewTextBoxColumn.HeaderText = "Codigo Prestamo";
            this.codigoPrestamoDataGridViewTextBoxColumn.Name = "codigoPrestamoDataGridViewTextBoxColumn";
            this.codigoPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoLibroDataGridViewTextBoxColumn
            // 
            this.codigoLibroDataGridViewTextBoxColumn.DataPropertyName = "Codigo Libro";
            this.codigoLibroDataGridViewTextBoxColumn.HeaderText = "Codigo Libro";
            this.codigoLibroDataGridViewTextBoxColumn.Name = "codigoLibroDataGridViewTextBoxColumn";
            this.codigoLibroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloLibroDataGridViewTextBoxColumn
            // 
            this.tituloLibroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tituloLibroDataGridViewTextBoxColumn.DataPropertyName = "Titulo Libro";
            this.tituloLibroDataGridViewTextBoxColumn.HeaderText = "Titulo Libro";
            this.tituloLibroDataGridViewTextBoxColumn.Name = "tituloLibroDataGridViewTextBoxColumn";
            this.tituloLibroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreLectorDataGridViewTextBoxColumn
            // 
            this.nombreLectorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreLectorDataGridViewTextBoxColumn.DataPropertyName = "Nombre Lector";
            this.nombreLectorDataGridViewTextBoxColumn.HeaderText = "Nombre Lector";
            this.nombreLectorDataGridViewTextBoxColumn.Name = "nombreLectorDataGridViewTextBoxColumn";
            this.nombreLectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoLectorDataGridViewTextBoxColumn
            // 
            this.apellidoLectorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidoLectorDataGridViewTextBoxColumn.DataPropertyName = "Apellido Lector";
            this.apellidoLectorDataGridViewTextBoxColumn.HeaderText = "Apellido Lector";
            this.apellidoLectorDataGridViewTextBoxColumn.Name = "apellidoLectorDataGridViewTextBoxColumn";
            this.apellidoLectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreBibliotecarioDataGridViewTextBoxColumn
            // 
            this.nombreBibliotecarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreBibliotecarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre Bibliotecario";
            this.nombreBibliotecarioDataGridViewTextBoxColumn.HeaderText = "Nombre Bibliotecario";
            this.nombreBibliotecarioDataGridViewTextBoxColumn.Name = "nombreBibliotecarioDataGridViewTextBoxColumn";
            this.nombreBibliotecarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewLibrosPrestadosBindingSource
            // 
            this.viewLibrosPrestadosBindingSource.DataMember = "View_LibrosPrestados";
            this.viewLibrosPrestadosBindingSource.DataSource = this.sGBibliotecarioDataSet3VistasBindingSource;
            // 
            // sGBibliotecarioDataSet3VistasBindingSource
            // 
            this.sGBibliotecarioDataSet3VistasBindingSource.DataSource = this.sGBibliotecarioDataSet3_Vistas;
            this.sGBibliotecarioDataSet3VistasBindingSource.Position = 0;
            // 
            // sGBibliotecarioDataSet3_Vistas
            // 
            this.sGBibliotecarioDataSet3_Vistas.DataSetName = "SGBibliotecarioDataSet3_Vistas";
            this.sGBibliotecarioDataSet3_Vistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Total";
            // 
            // textBox_total
            // 
            this.textBox_total.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBox_total.Location = new System.Drawing.Point(51, 499);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.ShortcutsEnabled = false;
            this.textBox_total.Size = new System.Drawing.Size(93, 20);
            this.textBox_total.TabIndex = 71;
            // 
            // view_LibrosPrestadosTableAdapter
            // 
            this.view_LibrosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // FormConsultaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_codigoPrestamo);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultaPrestamo";
            this.Text = "FormConsultaPrestamo";
            this.Load += new System.EventHandler(this.FormConsultaPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLibrosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet3VistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet3_Vistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_codigoPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_horaEntrega;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_horaPrestamo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_estado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_prestadoPor;
        private System.Windows.Forms.TextBox textBox_fecha;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sGBibliotecarioDataSet3VistasBindingSource;
        private SGBibliotecarioDataSet3_Vistas sGBibliotecarioDataSet3_Vistas;
        private System.Windows.Forms.BindingSource viewLibrosPrestadosBindingSource;
        private SGBibliotecarioDataSet3_VistasTableAdapters.View_LibrosPrestadosTableAdapter view_LibrosPrestadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoLectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreBibliotecarioDataGridViewTextBoxColumn;

    }
}