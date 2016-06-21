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
    public partial class FormLibrosDevueltos : Form
    {
        LibroPrestado libroPrestado = new LibroPrestado();
        EstadoLibro estadoLibro = new EstadoLibro();
        LibroDevuelto libroDevuelto = new LibroDevuelto();

        string valorDataGrid_codigoLibro;

        public FormLibrosDevueltos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //valorDataGrid_codigoLibro = dataGridView1.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            //button2.Enabled = true;
        }

        private void FormLibrosDevueltos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sGBibliotecarioDataSet5_Vistas.View_LibroDevuelto' Puede moverla o quitarla según sea necesario.
            this.view_LibroDevueltoTableAdapter.Fill(this.sGBibliotecarioDataSet5_Vistas.View_LibroDevuelto);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            estadoLibro.IdLibro = Convert.ToInt32(valorDataGrid_codigoLibro); // convirtiendo el valor de idLibro obtenido del datagrigview en entero.
            estadoLibro.actualizarEstadoEnEstante(); // actualiza el estado del libro a En estante
            libroDevuelto.eliminarLibroDevuelto(valorDataGrid_codigoLibro);
            FormLibrosDevueltos_Load(sender, e);

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valorDataGrid_codigoLibro = dataGridView1.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            button2.Enabled = true;
        }

        
    }
}
