namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    partial class FormConsultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_cedula = new System.Windows.Forms.MaskedTextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_fotografia = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_usuario = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografiaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tblUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGBibliotecarioDataSet = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSet();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.tblUsuarioTableAdapter = new com.RASMicroSystem.SistemaGestionBiblioteca.SGBibliotecarioDataSetTableAdapters.tblUsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fotografia)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(800, 87);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox_nombre.Location = new System.Drawing.Point(428, 36);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(247, 29);
            this.textBox_nombre.TabIndex = 2;
            this.textBox_nombre.Text = "Buscar Por Nombre";
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_buscar
            // 
            this.button_buscar.BackColor = System.Drawing.Color.Coral;
            this.button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscar.ForeColor = System.Drawing.Color.White;
            this.button_buscar.Image = ((System.Drawing.Image)(resources.GetObject("button_buscar.Image")));
            this.button_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_buscar.Location = new System.Drawing.Point(681, 31);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(98, 40);
            this.button_buscar.TabIndex = 4;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = false;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox_cedula);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_apellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 99);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRITERIO DE BUSQUEDA";
            // 
            // maskedTextBox_cedula
            // 
            this.maskedTextBox_cedula.BackColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox_cedula.Location = new System.Drawing.Point(61, 65);
            this.maskedTextBox_cedula.Mask = "000-0000000-0";
            this.maskedTextBox_cedula.Name = "maskedTextBox_cedula";
            this.maskedTextBox_cedula.Size = new System.Drawing.Size(84, 20);
            this.maskedTextBox_cedula.TabIndex = 8;
            this.maskedTextBox_cedula.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_cedula_MaskInputRejected);
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_id.Location = new System.Drawing.Point(384, 22);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 4;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Usuario";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_apellido.Location = new System.Drawing.Point(61, 22);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(219, 20);
            this.textBox_apellido.TabIndex = 2;
            this.textBox_apellido.TextChanged += new System.EventHandler(this.textBox_apellido_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // pictureBox_fotografia
            // 
            this.pictureBox_fotografia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_fotografia.BackgroundImage")));
            this.pictureBox_fotografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_fotografia.Location = new System.Drawing.Point(649, 101);
            this.pictureBox_fotografia.Name = "pictureBox_fotografia";
            this.pictureBox_fotografia.Size = new System.Drawing.Size(118, 99);
            this.pictureBox_fotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_fotografia.TabIndex = 6;
            this.pictureBox_fotografia.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_usuario);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 262);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTADO DE REGISTROS";
            // 
            // dataGridView_usuario
            // 
            this.dataGridView_usuario.AllowUserToAddRows = false;
            this.dataGridView_usuario.AllowUserToDeleteRows = false;
            this.dataGridView_usuario.AutoGenerateColumns = false;
            this.dataGridView_usuario.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fechaDeRegistroDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.fotografiaDataGridViewImageColumn});
            this.dataGridView_usuario.DataSource = this.tblUsuarioBindingSource;
            this.dataGridView_usuario.Location = new System.Drawing.Point(7, 20);
            this.dataGridView_usuario.Name = "dataGridView_usuario";
            this.dataGridView_usuario.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView_usuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_usuario.Size = new System.Drawing.Size(763, 236);
            this.dataGridView_usuario.TabIndex = 0;
            this.dataGridView_usuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_usuario_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDeRegistroDataGridViewTextBoxColumn
            // 
            this.fechaDeRegistroDataGridViewTextBoxColumn.DataPropertyName = "fechaDeRegistro";
            this.fechaDeRegistroDataGridViewTextBoxColumn.HeaderText = "Fecha de Registro";
            this.fechaDeRegistroDataGridViewTextBoxColumn.Name = "fechaDeRegistroDataGridViewTextBoxColumn";
            this.fechaDeRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotografiaDataGridViewImageColumn
            // 
            this.fotografiaDataGridViewImageColumn.DataPropertyName = "fotografia";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.fotografiaDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fotografiaDataGridViewImageColumn.HeaderText = "Fotografia";
            this.fotografiaDataGridViewImageColumn.Name = "fotografiaDataGridViewImageColumn";
            this.fotografiaDataGridViewImageColumn.ReadOnly = true;
            // 
            // tblUsuarioBindingSource
            // 
            this.tblUsuarioBindingSource.DataMember = "tblUsuario";
            this.tblUsuarioBindingSource.DataSource = this.sGBibliotecarioDataSetBindingSource;
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
            // textBox_total
            // 
            this.textBox_total.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total.ForeColor = System.Drawing.Color.Red;
            this.textBox_total.Location = new System.Drawing.Point(49, 483);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.Size = new System.Drawing.Size(93, 20);
            this.textBox_total.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            // 
            // button_limpiar
            // 
            this.button_limpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpiar.ForeColor = System.Drawing.Color.White;
            this.button_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("button_limpiar.Image")));
            this.button_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_limpiar.Location = new System.Drawing.Point(652, 494);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(127, 41);
            this.button_limpiar.TabIndex = 35;
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
            this.button_cancelar.Location = new System.Drawing.Point(165, 494);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(127, 41);
            this.button_cancelar.TabIndex = 36;
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
            this.button_nuevo.Location = new System.Drawing.Point(486, 494);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(127, 41);
            this.button_nuevo.TabIndex = 37;
            this.button_nuevo.Text = "Nuevo";
            this.button_nuevo.UseVisualStyleBackColor = false;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // tblUsuarioTableAdapter
            // 
            this.tblUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // FormConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox_fotografia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaUsuario";
            this.Load += new System.EventHandler(this.FormConsultaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fotografia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGBibliotecarioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_fotografia;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cedula;
        private System.Windows.Forms.DataGridView dataGridView_usuario;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.BindingSource sGBibliotecarioDataSetBindingSource;
        private SGBibliotecarioDataSet sGBibliotecarioDataSet;
        private System.Windows.Forms.BindingSource tblUsuarioBindingSource;
        private SGBibliotecarioDataSetTableAdapters.tblUsuarioTableAdapter tblUsuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotografiaDataGridViewImageColumn;
    }
}