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
    public partial class FormPrincipal : Form
    {
        ReportesEstado reporte = new ReportesEstado();
        private Point pos = Point.Empty;
        private bool move = false;

        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(fh);
            this.panel_Contenedor.Tag = fh;
            fh.Show();
        }

        private void toolStripMenuItem_consultarUsuario_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FormConsultaUsuario>().FirstOrDefault();
            FormConsultaUsuario frmConsultaUsuario = form ?? new FormConsultaUsuario();
            AddFormInPanel(frmConsultaUsuario);
        }

        private void consultarBibliotecarioToolStripMenuItem_consultarBibliotecario_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FormConsultaBibliotecario>().FirstOrDefault();
            FormConsultaBibliotecario frmConsultaBiblitecario = form ?? new FormConsultaBibliotecario();
            AddFormInPanel(frmConsultaBiblitecario);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FormConsultaLibro>().FirstOrDefault();
            FormConsultaLibro frmConsultaLibro = form ?? new FormConsultaLibro();
            AddFormInPanel(frmConsultaLibro);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FormLibrosDevueltos>().FirstOrDefault();
            FormLibrosDevueltos frmLibrosDevueltos = form ?? new FormLibrosDevueltos();
            AddFormInPanel(frmLibrosDevueltos);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FormConsultaPrestamo>().FirstOrDefault();
            FormConsultaPrestamo frmConsultaPrestamo = form ?? new FormConsultaPrestamo();
            AddFormInPanel(frmConsultaPrestamo);
        }

        private void label_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_minimizar_Click(object sender, EventArgs e)
        {
            
        }

        private void label_cerrar_MouseEnter(object sender, EventArgs e)
        {
            label_cerrar.ForeColor = Color.Coral;
        }

        private void label_cerrar_MouseLeave(object sender, EventArgs e)
        {
            label_cerrar.ForeColor = Color.Black;
        }

        private void label_minimizar_MouseEnter(object sender, EventArgs e)
        {
            label_minimizar.ForeColor = Color.Coral;
        }

        private void label_minimizar_MouseLeave(object sender, EventArgs e)
        {
            label_minimizar.ForeColor = Color.Black;
        }

        private void label_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //reporte.totalLibros(label_totalLibros);
            //reporte.totalLibrosPrestados(label_librosPrestados);
            //reporte.totalLibrosEnRecepcion(label_librosEnRecepcion);
            //reporte.totalUsuarios(label_usuarios);

            var form = Application.OpenForms.OfType<FormEstado>().FirstOrDefault();
            FormEstado frmEstado = form ?? new FormEstado();
            AddFormInPanel(frmEstado);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FormEstado>().FirstOrDefault();
            FormEstado frmEstado = form ?? new FormEstado();
            AddFormInPanel(frmEstado);

            frmEstado.FormEstado_Load(sender, e);
            

        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X), (this.Top + e.Y - pos.Y));
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X), (this.Top + e.Y - pos.Y));
        }

        

        

       

       
    }


}
