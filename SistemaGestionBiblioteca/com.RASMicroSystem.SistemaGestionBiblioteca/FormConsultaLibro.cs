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
    public partial class FormConsultaLibro : Form
    {
        private SqlCommand cmd;
        
        public FormConsultaLibro()
        {
            InitializeComponent();
        }

        private void FormConsultaLibro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sGBibliotecarioDataSet4_Vistas.View_EstadoLibro' Puede moverla o quitarla según sea necesario.
           // this.view_EstadoLibroTableAdapter.Fill(this.sGBibliotecarioDataSet4_Vistas.View_EstadoLibro);
           

        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            FormLibro frmLibro = new FormLibro();
            frmLibro.Show();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT titulo_original, clasificacion FROM tblLibro WHERE 1=1");
            if (this.textBox_titulo.Text.Trim().Length > 0)
                sql.Append(" AND titulo_original LIKE '%" + this.textBox_titulo.Text.TrimEnd());
            if (this.textBox_autor.Text.Trim().Length > 0)
                sql.Append(" AND autor LIKE '%" + this.textBox_autor.Text.TrimEnd().TrimStart() + "%' ");
            if (this.textBox_tema.Text.Trim().Length > 0)
                sql.Append("tema = '" + this.textBox_tema.Text.TrimEnd() + "'");
            if (this.textBox_categoria.Text.Trim().Length > 0)
                sql.Append(" AND categoria LIKE '%" + this.textBox_categoria.Text.TrimEnd().TrimStart() + "%' ");
            if (this.textBox_isbn.Text.Trim().Length > 0)
                sql.Append(" AND isbn_original LIKE '%" + this.textBox_isbn.Text.TrimEnd().TrimStart() + "%' ");
            if (this.textBox_genero.Text.Trim().Length > 0)
                sql.Append(" AND genero LIKE '%" + this.textBox_genero.Text.TrimEnd().TrimStart() + "%' ");
            if (this.textBox_oclc.Text.Trim().Length > 0)
                sql.Append(" AND oclc_oringinal LIKE '%" + this.textBox_oclc.Text.TrimEnd().TrimStart() + "%' ");
            if (this.textBox_editorial.Text.Trim().Length > 0)
                sql.Append(" AND editorial_original LIKE '%" + this.textBox_editorial.Text.TrimEnd().TrimStart() + "%' ");

            sql.Append("ORDER BY titulo_original");

            cmd = new SqlCommand(sql.ToString(), this.view_EstadoLibroTableAdapter.Connection);

            try 
            {
                view_EstadoLibroTableAdapter.Connection.Open();
                view_EstadoLibroTableAdapter.Fill(this.sGBibliotecarioDataSet4_Vistas.View_EstadoLibro);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally 
            {
                view_EstadoLibroTableAdapter.Connection.Close();
            }

            dataGridView_libros.DataSource = sGBibliotecarioDataSet4_Vistas.View_EstadoLibro;

            if (view_EstadoLibroTableAdapter != null)
                textBox_total.Text = sGBibliotecarioDataSet4_Vistas.View_EstadoLibro.Rows.Count.ToString("#,###;;0");

            Cursor.Current = Cursors.Default;


        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_titulo.Text = string.Empty;
            textBox_autor.Text = string.Empty;
            textBox_categoria.Text = string.Empty;
            textBox_editorial.Text = string.Empty;
            textBox_isbn.Text = string.Empty;
            textBox_oclc.Text = string.Empty;
            textBox_tema.Text = string.Empty;
            textBox_genero.Text = string.Empty;
            textBox_total.Text = string.Empty;
            dataGridView_libros.DataSource = null;

        }

        private void textBox_titulo_TextChanged(object sender, EventArgs e)
        {
            this.sGBibliotecarioDataSet4_Vistas.View_EstadoLibro.DefaultView.RowFilter = "[Titulo Libro] LIKE '%" + textBox_titulo.Text.TrimEnd() + "%'";
        }

        private void textBox_autor_TextChanged(object sender, EventArgs e)
        {
            //this.sGBibliotecarioDataSet.tblLibro.DefaultView.RowFilter = "autor LIKE '%" + textBox_autor.Text.TrimEnd() + "%'";
        }

        private void textBox_tema_TextChanged(object sender, EventArgs e)
        {
            this.sGBibliotecarioDataSet4_Vistas.View_EstadoLibro.DefaultView.RowFilter = "tema LIKE '%" + textBox_tema.Text.TrimEnd() + "%'";
        }

        private void textBox_categoria_TextChanged(object sender, EventArgs e)
        {
            this.sGBibliotecarioDataSet4_Vistas.View_EstadoLibro.DefaultView.RowFilter = "[Categoria] LIKE '%" + textBox_categoria.Text.TrimEnd() + "%'";
        }

        private void textBox_isbn_TextChanged(object sender, EventArgs e)
        {
            this.sGBibliotecarioDataSet4_Vistas.View_EstadoLibro.DefaultView.RowFilter = "[ISBN] LIKE '%" + textBox_isbn.Text.TrimEnd() + "%'";
        }

        private void textBox_genero_TextChanged(object sender, EventArgs e)
        {
            this.sGBibliotecarioDataSet4_Vistas.View_EstadoLibro.DefaultView.RowFilter = "[Genero] LIKE '%" + textBox_genero.Text.TrimEnd() + "%'";
        }

        private void textBox_oclc_TextChanged(object sender, EventArgs e)
        {
            this.sGBibliotecarioDataSet4_Vistas.View_EstadoLibro.DefaultView.RowFilter = "[OCLC] LIKE '%" + textBox_oclc.Text.TrimEnd() + "%'";
        }

        private void textBox_editorial_TextChanged(object sender, EventArgs e)
        {
            this.sGBibliotecarioDataSet4_Vistas.View_EstadoLibro.DefaultView.RowFilter = "[Editorial] LIKE '%" + textBox_editorial.Text.TrimEnd() + "%'";
        }
    }
}
