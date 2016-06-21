namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    partial class FormLibrosDevueltos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibrosDevueltos));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewLibroDevueltoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet5VistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet5_Vistas = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet5_Vistas();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.view_LibroDevueltoTableAdapter = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet5_VistasTableAdapters.View_LibroDevueltoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoLectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreBibliotecarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaprestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLibroDevueltoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet5VistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet5_Vistas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(747, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
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
            this.label1.Size = new System.Drawing.Size(809, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Devoluciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloLibroDataGridViewTextBoxColumn,
            this.nombreLectorDataGridViewTextBoxColumn,
            this.apellidoLectorDataGridViewTextBoxColumn,
            this.nombreBibliotecarioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaprestamoDataGridViewTextBoxColumn,
            this.horaentregaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewLibroDevueltoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(827, 414);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // viewLibroDevueltoBindingSource
            // 
            this.viewLibroDevueltoBindingSource.DataMember = "View_LibroDevuelto";
            this.viewLibroDevueltoBindingSource.DataSource = this.sGBibliotecarioDataSet5VistasBindingSource;
            // 
            // sGBibliotecarioDataSet5VistasBindingSource
            // 
            this.sGBibliotecarioDataSet5VistasBindingSource.DataSource = this.sGBibliotecarioDataSet5_Vistas;
            this.sGBibliotecarioDataSet5VistasBindingSource.Position = 0;
            // 
            // sGBibliotecarioDataSet5_Vistas
            // 
            this.sGBibliotecarioDataSet5_Vistas.DataSetName = "SGBibliotecarioDataSet5_Vistas";
            this.sGBibliotecarioDataSet5_Vistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.Color.White;
            this.button_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("button_cancelar.Image")));
            this.button_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancelar.Location = new System.Drawing.Point(661, 457);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(127, 41);
            this.button_cancelar.TabIndex = 70;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Visible = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(12, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 41);
            this.button2.TabIndex = 69;
            this.button2.Text = "Devolver Libro A Estante";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // view_LibroDevueltoTableAdapter
            // 
            this.view_LibroDevueltoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaprestamoDataGridViewTextBoxColumn
            // 
            this.horaprestamoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horaprestamoDataGridViewTextBoxColumn.DataPropertyName = "horaprestamo";
            this.horaprestamoDataGridViewTextBoxColumn.HeaderText = "Hora Prestamo";
            this.horaprestamoDataGridViewTextBoxColumn.Name = "horaprestamoDataGridViewTextBoxColumn";
            this.horaprestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaentregaDataGridViewTextBoxColumn
            // 
            this.horaentregaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horaentregaDataGridViewTextBoxColumn.DataPropertyName = "horaentrega";
            this.horaentregaDataGridViewTextBoxColumn.HeaderText = "Hora Entrega";
            this.horaentregaDataGridViewTextBoxColumn.Name = "horaentregaDataGridViewTextBoxColumn";
            this.horaentregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormLibrosDevueltos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 509);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "FormLibrosDevueltos";
            this.Text = "FormLibrosDevueltos";
            this.Load += new System.EventHandler(this.FormLibrosDevueltos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLibroDevueltoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet5VistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet5_Vistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource sGBibliotecarioDataSet5VistasBindingSource;
        private SGBibliotecarioDataSet5_Vistas sGBibliotecarioDataSet5_Vistas;
        private System.Windows.Forms.BindingSource viewLibroDevueltoBindingSource;
        private SGBibliotecarioDataSet5_VistasTableAdapters.View_LibroDevueltoTableAdapter view_LibroDevueltoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoLectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreBibliotecarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaprestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaentregaDataGridViewTextBoxColumn;
    }
}