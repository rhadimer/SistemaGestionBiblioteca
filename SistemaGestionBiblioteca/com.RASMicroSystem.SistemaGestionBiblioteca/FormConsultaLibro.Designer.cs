namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    partial class FormConsultaLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaLibro));
            this.tblBibliotecarioTableAdapter = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSetTableAdapters.tblBibliotecarioTableAdapter();
            this.button_buscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_categoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_autor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_oclc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_tema = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_editorial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_genero = new System.Windows.Forms.TextBox();
            this.sGBibliotecarioDataSet = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet();
            this.tblBibliotecarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_libros = new System.Windows.Forms.DataGridView();
            this.tituloLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewEstadoLibroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet4VistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet4_Vistas = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet4_Vistas();
            this.tblLibroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.tblLibroTableAdapter = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSetTableAdapters.tblLibroTableAdapter();
            this.view_EstadoLibroTableAdapter = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet4_VistasTableAdapters.View_EstadoLibroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBibliotecarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEstadoLibroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet4VistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet4_Vistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLibroBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblBibliotecarioTableAdapter
            // 
            this.tblBibliotecarioTableAdapter.ClearBeforeFill = true;
            // 
            // button_buscar
            // 
            this.button_buscar.BackColor = System.Drawing.Color.Coral;
            this.button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscar.ForeColor = System.Drawing.Color.White;
            this.button_buscar.Image = ((System.Drawing.Image)(resources.GetObject("button_buscar.Image")));
            this.button_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_buscar.Location = new System.Drawing.Point(681, 30);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(98, 40);
            this.button_buscar.TabIndex = 53;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = false;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_titulo
            // 
            this.textBox_titulo.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_titulo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_titulo.Location = new System.Drawing.Point(357, 36);
            this.textBox_titulo.Name = "textBox_titulo";
            this.textBox_titulo.Size = new System.Drawing.Size(318, 29);
            this.textBox_titulo.TabIndex = 51;
            this.textBox_titulo.Text = "Buscar Por Titulo";
            this.textBox_titulo.TextChanged += new System.EventHandler(this.textBox_titulo_TextChanged);
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
            this.label1.TabIndex = 50;
            this.label1.Text = "Libros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_categoria
            // 
            this.textBox_categoria.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_categoria.Location = new System.Drawing.Point(253, 22);
            this.textBox_categoria.Name = "textBox_categoria";
            this.textBox_categoria.Size = new System.Drawing.Size(100, 20);
            this.textBox_categoria.TabIndex = 4;
            this.textBox_categoria.TextChanged += new System.EventHandler(this.textBox_categoria_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria";
            // 
            // textBox_autor
            // 
            this.textBox_autor.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_autor.Location = new System.Drawing.Point(61, 22);
            this.textBox_autor.Name = "textBox_autor";
            this.textBox_autor.Size = new System.Drawing.Size(103, 20);
            this.textBox_autor.TabIndex = 2;
            this.textBox_autor.TextChanged += new System.EventHandler(this.textBox_autor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_oclc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_isbn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_tema);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_editorial);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_genero);
            this.groupBox1.Controls.Add(this.textBox_categoria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_autor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 99);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRITERIO DE BUSQUEDA";
            // 
            // textBox_oclc
            // 
            this.textBox_oclc.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_oclc.Location = new System.Drawing.Point(437, 66);
            this.textBox_oclc.Name = "textBox_oclc";
            this.textBox_oclc.Size = new System.Drawing.Size(103, 20);
            this.textBox_oclc.TabIndex = 16;
            this.textBox_oclc.TextChanged += new System.EventHandler(this.textBox_oclc_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "OCLC";
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_isbn.Location = new System.Drawing.Point(253, 66);
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(100, 20);
            this.textBox_isbn.TabIndex = 14;
            this.textBox_isbn.TextChanged += new System.EventHandler(this.textBox_isbn_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ISBN";
            // 
            // textBox_tema
            // 
            this.textBox_tema.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_tema.Location = new System.Drawing.Point(61, 66);
            this.textBox_tema.Name = "textBox_tema";
            this.textBox_tema.Size = new System.Drawing.Size(103, 20);
            this.textBox_tema.TabIndex = 12;
            this.textBox_tema.TextChanged += new System.EventHandler(this.textBox_tema_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tema";
            // 
            // textBox_editorial
            // 
            this.textBox_editorial.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_editorial.Location = new System.Drawing.Point(625, 22);
            this.textBox_editorial.Name = "textBox_editorial";
            this.textBox_editorial.Size = new System.Drawing.Size(103, 20);
            this.textBox_editorial.TabIndex = 10;
            this.textBox_editorial.TextChanged += new System.EventHandler(this.textBox_editorial_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Editorial";
            // 
            // textBox_genero
            // 
            this.textBox_genero.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_genero.Location = new System.Drawing.Point(437, 22);
            this.textBox_genero.Name = "textBox_genero";
            this.textBox_genero.Size = new System.Drawing.Size(103, 20);
            this.textBox_genero.TabIndex = 8;
            this.textBox_genero.TextChanged += new System.EventHandler(this.textBox_genero_TextChanged);
            // 
            // sGBibliotecarioDataSet
            // 
            this.sGBibliotecarioDataSet.DataSetName = "SGBibliotecarioDataSet";
            this.sGBibliotecarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridView_libros
            // 
            this.dataGridView_libros.AllowUserToAddRows = false;
            this.dataGridView_libros.AllowUserToDeleteRows = false;
            this.dataGridView_libros.AutoGenerateColumns = false;
            this.dataGridView_libros.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_libros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tituloLibroDataGridViewTextBoxColumn,
            this.ubicaciónDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView_libros.DataSource = this.viewEstadoLibroBindingSource;
            this.dataGridView_libros.Location = new System.Drawing.Point(7, 20);
            this.dataGridView_libros.Name = "dataGridView_libros";
            this.dataGridView_libros.ReadOnly = true;
            this.dataGridView_libros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_libros.Size = new System.Drawing.Size(763, 236);
            this.dataGridView_libros.TabIndex = 0;
            // 
            // tituloLibroDataGridViewTextBoxColumn
            // 
            this.tituloLibroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tituloLibroDataGridViewTextBoxColumn.DataPropertyName = "Titulo Libro";
            this.tituloLibroDataGridViewTextBoxColumn.HeaderText = "Titulo Libro";
            this.tituloLibroDataGridViewTextBoxColumn.Name = "tituloLibroDataGridViewTextBoxColumn";
            this.tituloLibroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicaciónDataGridViewTextBoxColumn
            // 
            this.ubicaciónDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ubicaciónDataGridViewTextBoxColumn.DataPropertyName = "Ubicación";
            this.ubicaciónDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.ubicaciónDataGridViewTextBoxColumn.Name = "ubicaciónDataGridViewTextBoxColumn";
            this.ubicaciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewEstadoLibroBindingSource
            // 
            this.viewEstadoLibroBindingSource.DataMember = "View_EstadoLibro";
            this.viewEstadoLibroBindingSource.DataSource = this.sGBibliotecarioDataSet4VistasBindingSource;
            // 
            // sGBibliotecarioDataSet4VistasBindingSource
            // 
            this.sGBibliotecarioDataSet4VistasBindingSource.DataSource = this.sGBibliotecarioDataSet4_Vistas;
            this.sGBibliotecarioDataSet4VistasBindingSource.Position = 0;
            // 
            // sGBibliotecarioDataSet4_Vistas
            // 
            this.sGBibliotecarioDataSet4_Vistas.DataSetName = "SGBibliotecarioDataSet4_Vistas";
            this.sGBibliotecarioDataSet4_Vistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLibroBindingSource
            // 
            this.tblLibroBindingSource.DataMember = "tblLibro";
            this.tblLibroBindingSource.DataSource = this.sGBibliotecarioDataSetBindingSource;
            // 
            // button_limpiar
            // 
            this.button_limpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpiar.ForeColor = System.Drawing.Color.White;
            this.button_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("button_limpiar.Image")));
            this.button_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_limpiar.Location = new System.Drawing.Point(655, 494);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(127, 41);
            this.button_limpiar.TabIndex = 58;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = false;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.Color.White;
            this.button_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("button_cancelar.Image")));
            this.button_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancelar.Location = new System.Drawing.Point(159, 494);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(127, 41);
            this.button_cancelar.TabIndex = 59;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Visible = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // textBox_total
            // 
            this.textBox_total.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBox_total.Location = new System.Drawing.Point(49, 483);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.ShortcutsEnabled = false;
            this.textBox_total.Size = new System.Drawing.Size(93, 20);
            this.textBox_total.TabIndex = 57;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_libros);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 262);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTADO DE REGISTROS";
            // 
            // button_nuevo
            // 
            this.button_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.button_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo.ForeColor = System.Drawing.Color.White;
            this.button_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("button_nuevo.Image")));
            this.button_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nuevo.Location = new System.Drawing.Point(489, 494);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(127, 41);
            this.button_nuevo.TabIndex = 60;
            this.button_nuevo.Text = "Nuevo";
            this.button_nuevo.UseVisualStyleBackColor = false;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // tblLibroTableAdapter
            // 
            this.tblLibroTableAdapter.ClearBeforeFill = true;
            // 
            // view_EstadoLibroTableAdapter
            // 
            this.view_EstadoLibroTableAdapter.ClearBeforeFill = true;
            // 
            // FormConsultaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_nuevo);
            this.Name = "FormConsultaLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaLibro";
            this.Load += new System.EventHandler(this.FormConsultaLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBibliotecarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEstadoLibroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet4VistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet4_Vistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLibroBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SGBibliotecarioDataSetTableAdapters.tblBibliotecarioTableAdapter tblBibliotecarioTableAdapter;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_categoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_autor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private SGBibliotecarioDataSet sGBibliotecarioDataSet;
        private System.Windows.Forms.BindingSource tblBibliotecarioBindingSource;
        private System.Windows.Forms.BindingSource sGBibliotecarioDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_libros;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.TextBox textBox_oclc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_isbn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_tema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_editorial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_genero;
        private System.Windows.Forms.BindingSource tblLibroBindingSource;
        private SGBibliotecarioDataSetTableAdapters.tblLibroTableAdapter tblLibroTableAdapter;
        private System.Windows.Forms.BindingSource sGBibliotecarioDataSet4VistasBindingSource;
        private SGBibliotecarioDataSet4_Vistas sGBibliotecarioDataSet4_Vistas;
        private System.Windows.Forms.BindingSource viewEstadoLibroBindingSource;
        private SGBibliotecarioDataSet4_VistasTableAdapters.View_EstadoLibroTableAdapter view_EstadoLibroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}