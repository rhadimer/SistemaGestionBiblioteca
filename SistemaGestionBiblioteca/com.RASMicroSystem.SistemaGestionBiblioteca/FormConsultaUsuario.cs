using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    public partial class FormConsultaUsuario : Form
    {
        private SqlCommand cmd;
        private DataRow dr;

        Usuario usuario = new Usuario();

        public FormConsultaUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormConsultaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sGBibliotecarioDataSet.tblUsuario' Puede moverla o quitarla según sea necesario.
           // this.tblUsuarioTableAdapter.Fill(this.sGBibliotecarioDataSet.tblUsuario);

        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            //usuario.colsultarUsuario(this.dataGridView_usuario);
            
            Cursor.Current = Cursors.WaitCursor;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id, nombre, apellido, telefono, categoria FROM tblUsuario WHERE 1=1");
            if (this.textBox_nombre.Text.Trim().Length > 0)
                sql.Append(" AND nombre LIKE '%" + this.textBox_nombre.Text.TrimEnd());
            if (this.textBox_apellido.Text.Trim().Length > 0)
                sql.Append(" AND apellido LIKE '%" + this.textBox_apellido.Text.TrimEnd().TrimStart() + "%' ");
            if (this.textBox_id.Text.Trim().Length > 0)
                sql.Append("id = '" + this.textBox_id.Text.TrimEnd() + "'");

            ///Para remover la mascara..
           string valor = this.maskedTextBox_cedula.Text.Replace(this.maskedTextBox_cedula.PromptChar, ' ');
           valor = valor.Replace('-', ' ').Trim();

            if (valor.Length > 0)
                sql.Append(" AND cedula LIKE '%" + this.maskedTextBox_cedula.Text.Replace(maskedTextBox_cedula.PromptChar, ' ').Trim() + "%'");

            sql.Append(" ORDER BY nombre asc, apellido, telefono, categoria");

            cmd = new SqlCommand(sql.ToString(), this.tblUsuarioTableAdapter.Connection); //El comando que manejara el query.



            try
            {
                tblUsuarioTableAdapter.Connection.Open();
                tblUsuarioTableAdapter.Fill(this.sGBibliotecarioDataSet.tblUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                tblUsuarioTableAdapter.Connection.Close();
            }

            this.dataGridView_usuario.DataSource = sGBibliotecarioDataSet.tblUsuario; //Asignando la fuente de los datos...

            if (tblUsuarioTableAdapter != null)
                textBox_total.Text = sGBibliotecarioDataSet.tblUsuario.Rows.Count.ToString("#,###;;0");//El conteo de los registros del query.

            Cursor.Current = Cursors.Default;

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            usuario.Nombre = textBox_nombre.Text.TrimEnd();
            this.sGBibliotecarioDataSet.tblUsuario.DefaultView.RowFilter = "nombre LIKE '%" + textBox_nombre.Text.TrimEnd() + "%'";
        }

        private void textBox_apellido_TextChanged(object sender, EventArgs e)
        {
            usuario.Apellido = textBox_apellido.Text.TrimEnd();
            this.sGBibliotecarioDataSet.tblUsuario.DefaultView.RowFilter = "apellido LIKE '%" + textBox_apellido.Text.TrimEnd() + "%'";
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            //usuario.Id = Convert.ToInt32(textBox_id.Text);
            //this.sGBibliotecarioDataSet.tblUsuario.DefaultView.RowFilter =  textBox_id.Text ;

        }

        private void maskedTextBox_cedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           // usuario.Cedula = maskedTextBox_cedula.Text.TrimEnd();
            this.sGBibliotecarioDataSet.tblUsuario.DefaultView.RowFilter = "cedula LIKE '%" + maskedTextBox_cedula.Text.TrimEnd() + "%'";

 
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            this.textBox_nombre.Text = string.Empty;
            this.textBox_apellido.Text = string.Empty;
            this.textBox_id.Text = string.Empty;
            this.maskedTextBox_cedula.Text = string.Empty;
            this.textBox_total.Text = string.Empty;
            dataGridView_usuario.DataSource = null;
            pictureBox_fotografia = null;
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {   
            //boton nuevo
            FormUsuario frm = new FormUsuario();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.button_buscar_Click(sender, e);
            }
            frm.Dispose();
        }

        public void verImagen(PictureBox pbFoto)
        {
            try
            {
                // objeto que tiene los datos de la base de datos
                tblUsuarioTableAdapter.Fill(sGBibliotecarioDataSet.tblUsuario);

                byte[] datos = new byte[0];
                dr = sGBibliotecarioDataSet.tblUsuario.Rows[0]; //ds.Tables["IMG"].Rows[0];
                datos = (byte[])dr["fotografia"];

                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la Imagen: " + ex.ToString());
            }
        }

        private void dataGridView_usuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // verImagen(pictureBox_fotografia);
        }

        
    }
}
