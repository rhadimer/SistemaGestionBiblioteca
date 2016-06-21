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
    public partial class FormHistorialPrestamo : Form
    {
        public FormHistorialPrestamo()
        {
            InitializeComponent();
        }

       

        private void button_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHistorialPrestamo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sGBibliotecarioDataSet8.View_HitorialLibroDevuelto' Puede moverla o quitarla según sea necesario.
            this.view_HitorialLibroDevueltoTableAdapter1.Fill(this.sGBibliotecarioDataSet8.View_HitorialLibroDevuelto);
            

        }
    }
}
