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
    public partial class FormAutor : Form
    {

        Autor autor = new Autor();
        FormLibro frmLibro = new FormLibro();
        
        public FormAutor()
        {
            InitializeComponent();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            if (pictureBox_fotografia.Image == null)
            {
                MessageBox.Show("Seleccione una Fotografia para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                button_examinar.Focus();

            }
            else
            {
                autor.agregarAutor(pictureBox_fotografia);
                this.Close();
            }

        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            autor.Nombre = textBox_nombre.Text.ToString();
        }

        private void textBox_apellido_TextChanged(object sender, EventArgs e)
        {
            autor.Apellido = textBox_apellido.Text.ToString();
        }

        private void textBox_nacionalidad_TextChanged(object sender, EventArgs e)
        {
            autor.Nacionalidad = textBox_nacionalidad.Text.ToString();
        }

        private void button_examinar_Click(object sender, EventArgs e)
        {
            //Cargar imagen
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox_fotografia.Image = Image.FromFile(openFileDialog1.FileName);
            }
            openFileDialog1.Dispose();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            this.textBox_nombre.Text = string.Empty;
            this.textBox_apellido.Text = string.Empty;
            this.textBox_nacionalidad.Text = string.Empty;
            pictureBox_fotografia.Image = null;
        }
    }
}
