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
    public partial class FormConsultaBibliotecario : Form
    {
        
        private SqlCommand cmd;
        

        public FormConsultaBibliotecario()
        {
            InitializeComponent();
        }


        private void FormConsultaBibliotecario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sGBibliotecarioDataSet.tblBibliotecario' Puede moverla o quitarla según sea necesario.
            //this.tblBibliotecarioTableAdapter.Fill(this.sGBibliotecarioDataSet.tblBibliotecario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //para pasarle el string de comando sql
           // tblBibliotecarioTableAdapter = new SqlDataAdapter(cmd);
            
            //para cerrar la conexion
           // this.tblBibliotecarioTableAdapter.Connection.Close();

            

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id, nombre, apellido, telefono, categoria FROM tblBibliotecario WHERE 1=1");
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

            cmd = new SqlCommand(sql.ToString(), this.tblBibliotecarioTableAdapter.Connection); //El comando que manejara el query.
            
           

            try 
            {
                tblBibliotecarioTableAdapter.Connection.Open();
                tblBibliotecarioTableAdapter.Fill(this.sGBibliotecarioDataSet.tblBibliotecario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally 
            {
                tblBibliotecarioTableAdapter.Connection.Close();
            }

            this.dataGridView_Bibliotecario.DataSource = sGBibliotecarioDataSet.tblBibliotecario; //Asignando la fuente de los datos...

            if (tblBibliotecarioTableAdapter != null)
                textBox_total.Text = sGBibliotecarioDataSet.tblBibliotecario.Rows.Count.ToString("#,###;;0");//El conteo de los registros del query.

            Cursor.Current = Cursors.Default;


        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
            this.Dispose();
            
        }

        // PARA FILTRAL LOS DATOS 
        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            this.sGBibliotecarioDataSet.tblBibliotecario.DefaultView.RowFilter = "nombre LIKE '%" + textBox_nombre.Text.TrimEnd() + "%'";
        }

        private void textBox_apellido_TextChanged(object sender, EventArgs e)
        {
            this.sGBibliotecarioDataSet.tblBibliotecario.DefaultView.RowFilter = "apellido LIKE '%" + textBox_apellido.Text.TrimEnd() + "%'";
        }

        private void maskedTextBox_cedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.sGBibliotecarioDataSet.tblBibliotecario.DefaultView.RowFilter = "cedula LIKE '" + maskedTextBox_cedula.Text.TrimEnd() + "%'";
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            /*int idEntero = Convert.ToInt32(textBox_id.Text);
            this.sGBibliotecarioDataSet.tblBibliotecario.DefaultView.RowFilter = "cedula LIKE '" + idEntero.ToString().TrimEnd() + "%'";*/
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            FormBibliotecario frm = new FormBibliotecario();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.button1_Click(sender, e);
            }
            frm.Dispose();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            this.textBox_nombre.Text = string.Empty;
            this.textBox_apellido.Text = string.Empty;
            this.textBox_id.Text = string.Empty;
            this.maskedTextBox_cedula.Text = string.Empty;
            this.textBox_total.Text = string.Empty;
            dataGridView_Bibliotecario.DataSource = null;
        }

    }
}
