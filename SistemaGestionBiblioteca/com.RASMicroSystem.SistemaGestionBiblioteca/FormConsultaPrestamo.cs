using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    public partial class FormConsultaPrestamo : Form
    {
        Prestamo prestamo = new Prestamo();
        LibroPrestado libroPrestado = new LibroPrestado();
        EstadoLibro estadoLibro = new EstadoLibro();
    

        SGBibliotecarioDataSet2TableAdapters.tblLibroPrestadoTableAdapter tblLibroPrestadoDA = new SGBibliotecarioDataSet2TableAdapters.tblLibroPrestadoTableAdapter();
        SGBibliotecarioDataSet2.tblLibroPrestadoDataTable tblLibroPrestadoDS = new SGBibliotecarioDataSet2.tblLibroPrestadoDataTable();

        string valorDataGrid_codigoPrestamo;
        string valorDataGrid_codigoLibro;

        public FormConsultaPrestamo()
        {
            InitializeComponent();
        }

        private void FormConsultaPrestamo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sGBibliotecarioDataSet3_Vistas.View_LibrosPrestados' Puede moverla o quitarla según sea necesario.
            this.view_LibrosPrestadosTableAdapter.Fill(this.sGBibliotecarioDataSet3_Vistas.View_LibrosPrestados); 
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            FormPrestamo frm = new FormPrestamo();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.button_buscar_Click(sender, e);
               
            }
            frm.Dispose();
            this.FormConsultaPrestamo_Load(sender, e);
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
       
            //prestamo.consultarPrestamo(textBox_codigoPrestamo.Text.ToString());

           /* textBox_fecha.Text = prestamo.FechaHoraPrestamo;
            maskedTextBox_horaPrestamo.Text = prestamo.HoraPrestamo;
            maskedTextBox_horaEntrega.Text = prestamo.Horaentrega;
            textBox_prestadoPor.Text = prestamo.Idbibliotecario.ToString();*/

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valorDataGrid_codigoPrestamo = dataGridView1[0, e.RowIndex].Value.ToString();
            prestamo.consultarPrestamo(valorDataGrid_codigoPrestamo);

            textBox_fecha.Text = prestamo.FechaHoraPrestamo;
            maskedTextBox_horaPrestamo.Text = prestamo.HoraPrestamo;
            maskedTextBox_horaEntrega.Text = prestamo.Horaentrega;
            textBox_prestadoPor.Text = prestamo.Idbibliotecario.ToString();

            valorDataGrid_codigoLibro = dataGridView1.Rows[e.RowIndex].Cells["codigoLibroDataGridViewTextBoxColumn"].Value.ToString();

            
           
        }

        private void textBox_codigoPrestamo_TextChanged(object sender, EventArgs e)
        {
            //tblLibroPrestadoDA.Fill(tblLibroPrestadoDS);
            // prestamo.Id = Convert.ToInt32(textBox_codigoPrestamo.Text.TrimEnd());
           // this.sGBibliotecarioDataSet3_Vistas.View_LibrosPrestados.DefaultView.RowFilter = "[Codigo Prestamo]" + Convert.ToInt32(textBox_codigoPrestamo.Text.TrimEnd());
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           libroPrestado.eliminarLibroPrestado(valorDataGrid_codigoLibro);//Eliminando el libro de la tabla LibroPrestado.

           estadoLibro.IdLibro = Convert.ToInt32(valorDataGrid_codigoLibro); // convirtiendo el valor del idLibro en entero.
           estadoLibro.actualizarEstadoDevuelto(); // actualinzando el estado del libro.

           this.FormConsultaPrestamo_Load(sender, e);
            
        }


    }
}
