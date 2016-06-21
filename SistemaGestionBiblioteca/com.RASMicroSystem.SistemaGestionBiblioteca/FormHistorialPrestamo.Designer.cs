namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    partial class FormHistorialPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialPrestamo));
            this.button_buscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_codigoPrestamo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewHitorialLibroDevueltoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet8 = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet8();
            this.viewHitorialLibroDevueltoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet7 = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet7();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.view_HitorialLibroDevueltoTableAdapter = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet7TableAdapters.View_HitorialLibroDevueltoTableAdapter();
            this.view_HitorialLibroDevueltoTableAdapter1 = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet8TableAdapters.View_HitorialLibroDevueltoTableAdapter();
            this.codigoLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoLectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreBibliotecarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoBibliotecarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHitorialLibroDevueltoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHitorialLibroDevueltoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // button_buscar
            // 
            this.button_buscar.BackColor = System.Drawing.Color.Coral;
            this.button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscar.ForeColor = System.Drawing.Color.White;
            this.button_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_buscar.Location = new System.Drawing.Point(681, 23);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(98, 40);
            this.button_buscar.TabIndex = 12;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_codigoPrestamo
            // 
            this.textBox_codigoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_codigoPrestamo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_codigoPrestamo.Location = new System.Drawing.Point(421, 28);
            this.textBox_codigoPrestamo.Name = "textBox_codigoPrestamo";
            this.textBox_codigoPrestamo.Size = new System.Drawing.Size(254, 29);
            this.textBox_codigoPrestamo.TabIndex = 10;
            this.textBox_codigoPrestamo.Text = "Buscar Por Codigo Prestamo";
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
            this.label1.Size = new System.Drawing.Size(806, 87);
            this.label1.TabIndex = 9;
            this.label1.Text = "Historial de Préstamos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoLibroDataGridViewTextBoxColumn,
            this.tituloLibroDataGridViewTextBoxColumn,
            this.nombreLectorDataGridViewTextBoxColumn,
            this.apellidoLectorDataGridViewTextBoxColumn,
            this.nombreBibliotecarioDataGridViewTextBoxColumn,
            this.apellidoBibliotecarioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaPrestamoDataGridViewTextBoxColumn,
            this.horaEntregaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewHitorialLibroDevueltoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(806, 354);
            this.dataGridView1.TabIndex = 13;
            // 
            // viewHitorialLibroDevueltoBindingSource1
            // 
            this.viewHitorialLibroDevueltoBindingSource1.DataMember = "View_HitorialLibroDevuelto";
            this.viewHitorialLibroDevueltoBindingSource1.DataSource = this.sGBibliotecarioDataSet8BindingSource;
            // 
            // sGBibliotecarioDataSet8BindingSource
            // 
            this.sGBibliotecarioDataSet8BindingSource.DataSource = this.sGBibliotecarioDataSet8;
            this.sGBibliotecarioDataSet8BindingSource.Position = 0;
            // 
            // sGBibliotecarioDataSet8
            // 
            this.sGBibliotecarioDataSet8.DataSetName = "SGBibliotecarioDataSet8";
            this.sGBibliotecarioDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewHitorialLibroDevueltoBindingSource
            // 
            this.viewHitorialLibroDevueltoBindingSource.DataMember = "View_HitorialLibroDevuelto";
            this.viewHitorialLibroDevueltoBindingSource.DataSource = this.sGBibliotecarioDataSet7BindingSource;
            // 
            // sGBibliotecarioDataSet7BindingSource
            // 
            this.sGBibliotecarioDataSet7BindingSource.DataSource = this.sGBibliotecarioDataSet7;
            this.sGBibliotecarioDataSet7BindingSource.Position = 0;
            // 
            // sGBibliotecarioDataSet7
            // 
            this.sGBibliotecarioDataSet7.DataSetName = "SGBibliotecarioDataSet7";
            this.sGBibliotecarioDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.Color.White;
            this.button_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("button_cancelar.Image")));
            this.button_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancelar.Location = new System.Drawing.Point(652, 462);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(127, 41);
            this.button_cancelar.TabIndex = 69;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click_1);
            // 
            // view_HitorialLibroDevueltoTableAdapter
            // 
            this.view_HitorialLibroDevueltoTableAdapter.ClearBeforeFill = true;
            // 
            // view_HitorialLibroDevueltoTableAdapter1
            // 
            this.view_HitorialLibroDevueltoTableAdapter1.ClearBeforeFill = true;
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
            this.tituloLibroDataGridViewTextBoxColumn.DataPropertyName = "Titulo Libro";
            this.tituloLibroDataGridViewTextBoxColumn.HeaderText = "Titulo Libro";
            this.tituloLibroDataGridViewTextBoxColumn.Name = "tituloLibroDataGridViewTextBoxColumn";
            this.tituloLibroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreLectorDataGridViewTextBoxColumn
            // 
            this.nombreLectorDataGridViewTextBoxColumn.DataPropertyName = "Nombre Lector";
            this.nombreLectorDataGridViewTextBoxColumn.HeaderText = "Nombre Lector";
            this.nombreLectorDataGridViewTextBoxColumn.Name = "nombreLectorDataGridViewTextBoxColumn";
            this.nombreLectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoLectorDataGridViewTextBoxColumn
            // 
            this.apellidoLectorDataGridViewTextBoxColumn.DataPropertyName = "Apellido Lector";
            this.apellidoLectorDataGridViewTextBoxColumn.HeaderText = "Apellido Lector";
            this.apellidoLectorDataGridViewTextBoxColumn.Name = "apellidoLectorDataGridViewTextBoxColumn";
            this.apellidoLectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreBibliotecarioDataGridViewTextBoxColumn
            // 
            this.nombreBibliotecarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre Bibliotecario";
            this.nombreBibliotecarioDataGridViewTextBoxColumn.HeaderText = "Nombre Bibliotecario";
            this.nombreBibliotecarioDataGridViewTextBoxColumn.Name = "nombreBibliotecarioDataGridViewTextBoxColumn";
            this.nombreBibliotecarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoBibliotecarioDataGridViewTextBoxColumn
            // 
            this.apellidoBibliotecarioDataGridViewTextBoxColumn.DataPropertyName = "Apellido Bibliotecario";
            this.apellidoBibliotecarioDataGridViewTextBoxColumn.HeaderText = "Apellido Bibliotecario";
            this.apellidoBibliotecarioDataGridViewTextBoxColumn.Name = "apellidoBibliotecarioDataGridViewTextBoxColumn";
            this.apellidoBibliotecarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaPrestamoDataGridViewTextBoxColumn
            // 
            this.horaPrestamoDataGridViewTextBoxColumn.DataPropertyName = "Hora Prestamo";
            this.horaPrestamoDataGridViewTextBoxColumn.HeaderText = "Hora Prestamo";
            this.horaPrestamoDataGridViewTextBoxColumn.Name = "horaPrestamoDataGridViewTextBoxColumn";
            this.horaPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaEntregaDataGridViewTextBoxColumn
            // 
            this.horaEntregaDataGridViewTextBoxColumn.DataPropertyName = "Hora Entrega";
            this.horaEntregaDataGridViewTextBoxColumn.HeaderText = "Hora Entrega";
            this.horaEntregaDataGridViewTextBoxColumn.Name = "horaEntregaDataGridViewTextBoxColumn";
            this.horaEntregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormHistorialPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 515);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_codigoPrestamo);
            this.Controls.Add(this.label1);
            this.Name = "FormHistorialPrestamo";
            this.Text = "FormHistorialPrestamo";
            this.Load += new System.EventHandler(this.FormHistorialPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHitorialLibroDevueltoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHitorialLibroDevueltoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_codigoPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.BindingSource sGBibliotecarioDataSet7BindingSource;
        private SGBibliotecarioDataSet7 sGBibliotecarioDataSet7;
        private System.Windows.Forms.BindingSource viewHitorialLibroDevueltoBindingSource;
        private SGBibliotecarioDataSet7TableAdapters.View_HitorialLibroDevueltoTableAdapter view_HitorialLibroDevueltoTableAdapter;
        private System.Windows.Forms.BindingSource sGBibliotecarioDataSet8BindingSource;
        private SGBibliotecarioDataSet8 sGBibliotecarioDataSet8;
        private System.Windows.Forms.BindingSource viewHitorialLibroDevueltoBindingSource1;
        private SGBibliotecarioDataSet8TableAdapters.View_HitorialLibroDevueltoTableAdapter view_HitorialLibroDevueltoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoLectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreBibliotecarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoBibliotecarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEntregaDataGridViewTextBoxColumn;
    }
}