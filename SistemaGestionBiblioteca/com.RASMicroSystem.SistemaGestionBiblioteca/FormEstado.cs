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
    public partial class FormEstado : Form
    {
        ReportesEstado reporte = new ReportesEstado();
        
        public FormEstado()
        {
            InitializeComponent();
        }



        public void FormEstado_Load(object sender, EventArgs e)
        {
            reporte.totalLibros(label_totalLibros);
            reporte.totalLibrosPrestados(label_librosPrestados);
            reporte.totalLibrosEnRecepcion(label_librosEnRecepcion);
            reporte.totalUsuarios(label_usuarios);
        }

        private void label_nuevoLibro_MouseEnter(object sender, EventArgs e)
        {
            label_nuevoLibro.ForeColor = Color.Coral;
        }

        private void label_nuevoLibro_MouseLeave(object sender, EventArgs e)
        {
            label_nuevoLibro.ForeColor = Color.SteelBlue;
        }

        private void label_nuevoLibro_Click(object sender, EventArgs e)
        {
            FormLibro frm = new FormLibro();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormLibro frm = new FormLibro();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void label_nuevoUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario frm = new FormUsuario();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void label_nuevoUsuario_MouseEnter(object sender, EventArgs e)
        {
            label_nuevoUsuario.ForeColor = Color.Coral;
        }

        private void label_nuevoUsuario_MouseLeave(object sender, EventArgs e)
        {
            label_nuevoUsuario.ForeColor = Color.SteelBlue;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormUsuario frm = new FormUsuario();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void label_nuevoBibliotecario_Click(object sender, EventArgs e)
        {
            FormBibliotecario frm = new FormBibliotecario();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void label_nuevoBibliotecario_MouseEnter(object sender, EventArgs e)
        {
            label_nuevoBibliotecario.ForeColor = Color.Coral;
        }

        private void label_nuevoBibliotecario_MouseLeave(object sender, EventArgs e)
        {
            label_nuevoBibliotecario.ForeColor = Color.SteelBlue;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormBibliotecario frm = new FormBibliotecario();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void label_nuevoPrestamo_MouseEnter(object sender, EventArgs e)
        {
            label_nuevoPrestamo.ForeColor = Color.Coral;
        }

        private void label_nuevoPrestamo_MouseLeave(object sender, EventArgs e)
        {
            label_nuevoPrestamo.ForeColor = Color.SteelBlue;
        }

        private void label_nuevoPrestamo_Click(object sender, EventArgs e)
        {
            FormPrestamo frm = new FormPrestamo();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void pictureBox_nuevoPrestamo_Click(object sender, EventArgs e)
        {
            FormPrestamo frm = new FormPrestamo();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void label_devolverLibro_MouseEnter(object sender, EventArgs e)
        {
            label_devolverLibro.ForeColor = Color.Coral;
        }

        private void label_devolverLibro_MouseLeave(object sender, EventArgs e)
        {
            label_devolverLibro.ForeColor = Color.SteelBlue;
        }

        private void label_devolverLibro_Click(object sender, EventArgs e)
        {
            FormLibrosDevueltos frm = new FormLibrosDevueltos();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void pictureBox_devolverLibro_Click(object sender, EventArgs e)
        {
            FormLibrosDevueltos frm = new FormLibrosDevueltos();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            FormEstado_Load(sender, e);
        }

        private void label_historialPrestamo_Click(object sender, EventArgs e)
        {
            FormHistorialPrestamo frm = new FormHistorialPrestamo();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

        }

        private void pictureBox_historialPrestamo_Click(object sender, EventArgs e)
        {
            FormHistorialPrestamo frm = new FormHistorialPrestamo();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void label_historialPrestamo_MouseEnter(object sender, EventArgs e)
        {
            label_historialPrestamo.ForeColor = Color.Coral;
        }

        private void label_historialPrestamo_MouseLeave(object sender, EventArgs e)
        {
            label_historialPrestamo.ForeColor = Color.SteelBlue;
        }







    }
}
