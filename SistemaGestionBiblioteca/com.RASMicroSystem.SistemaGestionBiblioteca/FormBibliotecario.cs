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
    public partial class FormBibliotecario : Form
    {
        Bibliotecario bibliotecario = new Bibliotecario();
        

        public FormBibliotecario()
        {
            InitializeComponent();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            if (textBox_nombre.Text == "")
            {
                MessageBox.Show("Digite el Nombre para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_nombre.Focus();
            }
            else if (textBox_apellido.Text == "")
            {
                MessageBox.Show("Digite el Apellido para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_apellido.Focus();
            }
            else if (textBox_direccion.Text == "")
            {
                MessageBox.Show("Digite el Dirección para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_direccion.Focus();
            }
            else if (maskedTextBox_telefono.Text == "")
            {
                MessageBox.Show("Digite el Telefono para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox_telefono.Focus();
            }
            else if (comboBox_categoria.Text == "")
            {
                MessageBox.Show("Seleccione la Categoria para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox_categoria.Focus();
            }
            else if (pictureBox_fotografia.Image == null)
            {
                MessageBox.Show("Seleccione una Fotografia para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                button_examinar.Focus();

            }
            else
            {
                // funcion para agrgar datos de bibliotecario solo recibe como parametro la fotografia que se va almacenar en la base de datos
                bibliotecario.agregarBibliotecario(pictureBox_fotografia);


                textBox_nombre.Text = string.Empty;
                textBox_apellido.Text = string.Empty;
                textBox_direccion.Text = string.Empty;
                textBox_email.Text = string.Empty;
                maskedTextBox_telefono.Text = string.Empty;
                dateTimePicker_fecha.Text = string.Empty;
                maskedTextBox_cedula.Text = string.Empty;
                comboBox_categoria.Text = string.Empty;
                pictureBox_fotografia = null;
            }

        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_nombre.Text = string.Empty;
            textBox_apellido.Text = string.Empty;
            textBox_direccion.Text = string.Empty;
            textBox_email.Text = string.Empty;
            maskedTextBox_telefono.Text = string.Empty;
            dateTimePicker_fecha.Text = string.Empty;
            maskedTextBox_cedula.Text = string.Empty;
            comboBox_categoria.Text = string.Empty;
            pictureBox_fotografia.Image = null;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
           
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

        //Asignandole los valores de los textbox a las propiedades....
        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            bibliotecario.Nombre = textBox_nombre.Text.ToString();
            bibliotecario.FechaDeRegistro = dateTimePicker_fecha.Text.ToString(); //asigned este campo aqui porque no me evaluava el dateTimePicker_fecha solo lo evaluava cuando habia un cambio en la fecha
        }

        private void textBox_apellido_TextChanged(object sender, EventArgs e)
        {
            bibliotecario.Apellido = textBox_apellido.Text.ToString();
        }

        private void textBox_direccion_TextChanged(object sender, EventArgs e)
        {
            bibliotecario.Direccion = textBox_direccion.Text.ToString();
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            bibliotecario.Email = textBox_email.Text.ToString();
        }

        private void maskedTextBox_telefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            bibliotecario.Telefono = maskedTextBox_telefono.Text.ToString();
        }

        private void maskedTextBox_cedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            bibliotecario.Cedula = maskedTextBox_cedula.Text.ToString();
        }

        private void comboBox_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            bibliotecario.Categoria = comboBox_categoria.Text.ToString();
        }
    }
}
