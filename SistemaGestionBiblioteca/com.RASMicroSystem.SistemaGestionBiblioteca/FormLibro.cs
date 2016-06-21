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
    public partial class FormLibro : Form
    {
        Libro libro = new Libro();
        Autor autor = new Autor();
        RelacionAutorLibro relacionAutorLibro = new RelacionAutorLibro();
        Ejemplares ejemplares = new Ejemplares();
        EstadoLibro estadoLibro = new EstadoLibro();

        private FormEjemplares frmEjemplares = new FormEjemplares();

        public FormLibro()
        {
            InitializeComponent();
        }


        //valida campo vacios
        private bool campoVacios()
        {
            if (textBox_editor.Text == "")
                return true;
            else
                return false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
           

        }

        private void avilitarBotonNumEjemplar() 
        {
            string cntd = "1";
            string cntd2 = "0";
            if ((textBox_cantidad.Text != cntd) && (textBox_cantidad.Text != cntd2) && (textBox_cantidad.Text != ""))
            {
                checkedListBox_listaEjemplares.Enabled = true;
            }
        
        }

       
        
        //Asignando los valores de los campos a las propiedades.
        private void comboBox_autor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Autor
           
            
        }

        private void textBox_editor_TextChanged(object sender, EventArgs e)
        {
            libro.Editor = textBox_editor.Text.ToString();
        }

        private void textBox_genero_TextChanged(object sender, EventArgs e)
        {
            libro.Genero = textBox_genero.Text.ToString();
        }

        private void textBox_subgenero_TextChanged(object sender, EventArgs e)
        {
            libro.Subgenero = textBox_subgenero.Text.ToString();
        }

        private void textBox_idioma_TextChanged(object sender, EventArgs e)
        {
            libro.Idioma_Original = textBox_idioma.Text.ToString();
        }

        private void textBox_titulo_TextChanged(object sender, EventArgs e)
        {
            libro.Titulo_Original = textBox_titulo.Text.ToString();
            libro.Fecha_Original = dateTimePicker_fechaPublicacion.Text.ToString();
        }

        private void textBox_tema_TextChanged(object sender, EventArgs e)
        {
            libro.Tema = textBox_tema.Text.ToString();
        }

        private void textBox_isbn_TextChanged(object sender, EventArgs e)
        {
            libro.ISBN_original = textBox_isbn.Text.ToString();
        }

        private void textBox_oclc_TextChanged(object sender, EventArgs e)
        {
            libro.OCLC_original = textBox_oclc.Text.ToString();
        }

        private void textBox_categoria_TextChanged(object sender, EventArgs e)
        {
            libro.Categoria = textBox_categoria.Text.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            libro.Clasificacion = comboBox_clasificacion.Text.ToString();
        }

        private void textBox_sinopsis_TextChanged(object sender, EventArgs e)
        {
            libro.Sinopsis = textBox_sinopsis.Text.ToString();
        }

        

        private void textBox_premios_TextChanged(object sender, EventArgs e)
        {
            libro.Premios = textBox_premios.Text.ToString();
        }

        private void textBox_cantidad_TextChanged(object sender, EventArgs e)
        {
            /*int cantidad; 
            cantidad= Convert.ToInt32(textBox_cantidad.Text);
            libro.Cantidad = cantidad;*/
            avilitarBotonNumEjemplar();
        }

        private void textBox_ilustrador_TextChanged(object sender, EventArgs e)
        {
            libro.Ilustrador_Original = textBox_ilustrador.Text.ToString();
        }

        private void textBox_artistaDeCubierta_TextChanged(object sender, EventArgs e)
        {
            libro.ArtistaDeCubierta_Original = textBox_artistaDeCubierta.Text.ToString();
        }

        private void textBox_publicacion_TextChanged(object sender, EventArgs e)
        {
            libro.Publicacion_Original = textBox_publicacion.Text.ToString();
        }

        private void textBox_editorial_TextChanged(object sender, EventArgs e)
        {
            libro.Editorial_Original = textBox_editorial.Text.ToString();
        }

        private void textBox_ciudad_TextChanged(object sender, EventArgs e)
        {
            libro.Ciudad_Original = textBox_ciudad.Text.ToString();
        }

        private void textBox_pais_TextChanged(object sender, EventArgs e)
        {
            libro.Pais_Original = textBox_pais.Text.ToString();
        }

        private void dateTimePicker_fechaPublicacion_ValueChanged(object sender, EventArgs e)
        {
           libro.Fecha_Original = dateTimePicker_fechaPublicacion.Text.ToString();
        }

        private void textBox_formato_TextChanged(object sender, EventArgs e)
        {
            libro.Formato_Original = textBox_formato.Text.ToString();
        }

        private void textBox_numeroDePagina_TextChanged(object sender, EventArgs e)
        {
            /*int numeroDePagina = Convert.ToInt32(textBox_numeroDePagina.Text);
            libro.NumeroDePagina_Original = numeroDePagina;*/
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            /*comboBox_autor_Validated(this, e);
            textBox_editor_Validated(this, e);
            textBox_genero_Validated(this, e);
            textBox_subgenero_Validated(this,e);*/
            //libro.Estado = textBox_estado.Text.ToString();

            /*if (comboBox_autor.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Digite el editor para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_editor.Focus();
            }
            else*/ if (textBox_editor.Text == "")
            {
                MessageBox.Show("Digite el editor para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_editor.Focus();
            }
            else if (textBox_genero.Text == "")
            {
                MessageBox.Show("Digite el genero para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_genero.Focus();
            }
            else if (textBox_subgenero.Text == "")
            {
                MessageBox.Show("Digite el subgenero para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_subgenero.Focus();
            }
            else if (textBox_idioma.Text == "")
            {
                MessageBox.Show("Digite el idioma para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_idioma.Focus();
            }
            else if (textBox_titulo.Text == "")
            {
                MessageBox.Show("Digite el titulo para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_titulo.Focus();
            }
            else if (textBox_tema.Text == "")
            {
                MessageBox.Show("Digite el tema para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_tema.Focus();
            }
            else if (textBox_isbn.Text == "")
            {
                MessageBox.Show("Digite el ISBN para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_isbn.Focus();
            }
            else if (textBox_oclc.Text == "")
            {
                MessageBox.Show("Digite el OCLC para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_oclc.Focus();
            }
            else if (textBox_categoria.Text == "")
            {
                MessageBox.Show("Digite la categoria  para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_categoria.Focus();
            }
            else if (comboBox_clasificacion.Text == "")
            {
                MessageBox.Show("Digite la clasificacion para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox_clasificacion.Focus();
            }
            else if (textBox_sinopsis.Text == "")
            {
                MessageBox.Show("Digite la sinopsis para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_sinopsis.Focus();
            }
            else if (textBox_premios.Text == "")
            {
                MessageBox.Show("Digite el premio para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_premios.Focus();
            }
            else if (textBox_cantidad.Text == "")
            {
                MessageBox.Show("Digite la cantidad para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_cantidad.Focus();
            }
            else if (textBox_ilustrador.Text == "")
            {
                MessageBox.Show("Digite el ilustrador para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ilustrador.Focus();
            }
            else if (textBox_artistaDeCubierta.Text == "")
            {
                MessageBox.Show("Digite el artista de cubierta para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_artistaDeCubierta.Focus();
            }
            else if (textBox_publicacion.Text == "")
            {
                MessageBox.Show("Digite la publicacion para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_publicacion.Focus();
            }
            else if (textBox_editorial.Text == "")
            {
                MessageBox.Show("Digite el editorial para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_editorial.Focus();
            }
            else if (textBox_ciudad.Text == "")
            {
                MessageBox.Show("Digite la ciudad para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ciudad.Focus();
            }
            else if (textBox_pais.Text == "")
            {
                MessageBox.Show("Digite el pais para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_pais.Focus();
            }
            else if (textBox_formato.Text == "")
            {
                MessageBox.Show("Digite el formato para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_formato.Focus();
            }
            else if (textBox_numeroDePagina.Text == "")
            {
                MessageBox.Show("Digite el numero de pagina para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_numeroDePagina.Focus();
            }
            else if (textBox_palabrasClaves.Text == "")
            {
                MessageBox.Show("Digite las palabras claves para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_palabrasClaves.Focus();
            }
            else if (comboBox_estadoFisico.SelectedItem == null)
            {
                MessageBox.Show("seleccione el estado fisico para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_editor.Focus();
            }
            else if (pictureBox_imagenPortada.Image == null)
            {
                MessageBox.Show("seleccione la imagen para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                button_examinar.Focus();
            }
            else
            {


                libro.agregarLibro(pictureBox_imagenPortada); //guarda los datos recibiendo por parametro el pictureBox

                guardarListaAutores();

                guardarNumeroDeEjemplares();

                guardarEstadoLibro();

                button_limpiar_Click( sender, e); // llamando al metodo del boton limpiar


            }
           
        }

        private void textBox_palabrasClaves_TextChanged(object sender, EventArgs e)
        {
            libro.PalabasClaves = textBox_palabrasClaves.Text.ToString();
        }

        
        //Validando los campos
        private void comboBox_autor_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(comboBox_autor, "El autor No puede estar en blanco, debe selecionarlo de la lista o agregarlo");
        }

        private void textBox_editor_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_editor, "El editor No puede estar en blanco");  
        }

        private void textBox_genero_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_genero, "El genero No puede estar en blanco");
        }

        private void textBox_subgenero_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv){
                //errorProvider1.SetError(textBox_subgenero, "");
               // libro.Subgenero = textBox_subgenero.Text.ToString();
               // libro.Subgenero = textBox_subgenero.Text.ToString();
            }
        }

        private void textBox_idioma_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_idioma, "El idioma No puede estar en blanco");
            
        }

        private void textBox_titulo_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_titulo, "El titulo No puede estar en blanco");
        }

        private void textBox_tema_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                //errorProvider1.SetError(textBox_tema, "");
                libro.Tema = textBox_tema.Text = "";
                // libro.Tema = textBox_tema.Text.ToString();
        }

        private void textBox_isbn_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_isbn, "El ISBN No puede estar en blanco");
        }

        private void textBox_oclc_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                //errorProvider1.SetError(textBox_oclc, "");
                libro.OCLC_original = textBox_oclc.Text = "";
           // libro.OCLC_original = textBox_oclc.Text.ToString();
        }

        private void textBox_categoria_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                //errorProvider1.SetError(textBox_categoria, "");
                libro.Categoria = textBox_categoria.Text = "";
            //libro.Categoria = textBox_categoria.Text.ToString();
        }

        private void comboBox_clasificacion_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(comboBox_clasificacion, "La clasificacion No puede estar en blanco");
        }

        private void textBox_sinopsis_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                //errorProvider1.SetError(textBox_sinopsis, "");
                libro.Sinopsis = textBox_sinopsis.Text = "";
            //libro.Sinopsis = textBox_sinopsis.Text.ToString();
        }

        private void comboBox_estado_Validated(object sender, EventArgs e)
        {
           /* bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_estado, "El estado No puede estar en blanco");*/
        }

        private void textBox_premios_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
               // errorProvider1.SetError(textBox_premios, "");
                libro.Premios = textBox_premios.Text = "";
            //libro.Premios = textBox_premios.Text.ToString();
        }

        private void textBox_cantidad_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_cantidad, "La cantidad de libros No puede estar en blanco");
            else
            {
                int cantidad;
                cantidad = Convert.ToInt32(textBox_cantidad.Text);
                libro.Cantidad = cantidad;
            }
        }

        private void textBox_ilustrador_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                //errorProvider1.SetError(textBox_ilustrador, "");
                libro.Ilustrador_Original = textBox_ilustrador.Text = "";
           // libro.Ilustrador_Original = textBox_ilustrador.Text.ToString();
        }

        private void textBox_artistaDeCubierta_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                //errorProvider1.SetError(textBox_artistaDeCubierta, "");
                libro.ArtistaDeCubierta_Original = textBox_artistaDeCubierta.Text = "";
            //libro.ArtistaDeCubierta_Original = textBox_artistaDeCubierta.Text.ToString();
        }

        private void textBox_publicacion_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_publicacion, "La publicacion No puede estar en blanco");
        }

        private void textBox_editorial_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_editorial, "El editorial No puede estar en blanco");
        }

        private void textBox_ciudad_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_ciudad, "La ciudad No puede estar en blanco");

        }

        private void textBox_pais_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_pais, "El pais No puede estar en blanco");
        }

        private void textBox_formato_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)

                libro.Formato_Original = textBox_formato.Text = "";
            
        }

        private void textBox_numeroDePagina_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                this.errorProvider1.SetError(textBox_numeroDePagina, "El numero de pagina del libro No puede estar en blanco");
            else 
            {
                int numeroDePagina = Convert.ToInt32(textBox_numeroDePagina.Text);
                libro.NumeroDePagina_Original = numeroDePagina;
            }
                
        }

        private void textBox_palabrasClaves_Validated(object sender, EventArgs e)
        {
            bool cv = campoVacios();
            if (cv)
                libro.PalabasClaves = textBox_palabrasClaves.Text = "";
            
          
        }

        private void button_addAutor_Click(object sender, EventArgs e)
        {
            FormAutor frmAutor= new FormAutor();
            DialogResult res = frmAutor.ShowDialog();
            if (res == DialogResult.OK)
            {
               FormLibro_Load(sender,  e);
            }
            
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            comboBox_autor.Text = string.Empty;
            textBox_editor.Text = string.Empty;
            textBox_genero.Text = string.Empty;
            textBox_subgenero.Text = string.Empty;
            textBox_idioma.Text = string.Empty;
            textBox_titulo.Text = string.Empty;
            textBox_tema.Text = string.Empty;
            textBox_isbn.Text = string.Empty;
            textBox_oclc.Text = string.Empty;
            textBox_categoria.Text = string.Empty;
            comboBox_clasificacion.Text = string.Empty;
            textBox_sinopsis.Text = string.Empty;
           // textBox_estado.Text = string.Empty;
            textBox_premios.Text = string.Empty;
            textBox_cantidad.Text = string.Empty;
            textBox_ilustrador.Text = string.Empty;
            textBox_artistaDeCubierta.Text = string.Empty;
            textBox_publicacion.Text = string.Empty;
            textBox_editorial.Text = string.Empty;
            textBox_ciudad.Text = string.Empty;
            textBox_pais.Text = string.Empty;
            textBox_formato.Text = string.Empty;
            textBox_numeroDePagina.Text = string.Empty;
            textBox_palabrasClaves.Text = string.Empty;
            pictureBox_imagenPortada.Image = null;


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
                pictureBox_imagenPortada.Image = Image.FromFile(openFileDialog1.FileName);
            }
            openFileDialog1.Dispose();
        }

        private void FormLibro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sGBibliotecarioDataSet1.tblAutor' Puede moverla o quitarla según sea necesario.
            this.tblAutorTableAdapter1.Fill(this.sGBibliotecarioDataSet1.tblAutor);

            autor.cargarListaAutores(checkedListBox_listaAutores);
            //comboBox_autor.SelectedIndex = 0;

           
        }

       

        private void comboBox_estadoFisico_SelectedIndexChanged(object sender, EventArgs e)
        {
            libro.Estado_fisico = comboBox_estadoFisico.Text.ToString();
        }

        private void textBox_estado_TextChanged(object sender, EventArgs e)
        {
           // libro.Estado = textBox_estado.Text.ToString();
        }

        private void button_addNoEjemplar_Click(object sender, EventArgs e)
        {

            DialogResult res = frmEjemplares.ShowDialog();
            if (res == DialogResult.OK)
            {
                asignarTextBoxFormEjemplares();
            }
            
        }


        private void guardarNumeroDeEjemplares() 
        {
            
                libro.obtenerIDLibro();
                ejemplares.IdLibro = libro.Id;
                ejemplares.agregarEjemplar(checkedListBox_listaEjemplares);

            
        }

        private void guardarEstadoLibro() 
        {
            libro.obtenerIDLibro();
            estadoLibro.IdLibro = libro.Id;

            estadoLibro.NombreEstado = textBox_estado.Text.ToString();

            estadoLibro.agregarEstado();

        }


        private void guardarListaAutores()
        {
           

            libro.obtenerIDLibro(); //obtienee el id del ultimo registro o libro que se ingreso a la base de datos
            relacionAutorLibro.IdLibro = libro.Id; // asigna el valor del id del libro obtenido, a la propiedad IdLibro de la clase RelacionAutorLibro

            int[] obtenerIDs = new int[10];
           
            
            for (int i = 0; i <= checkedListBox_listaAutores.CheckedIndices.Count - 1; i++)
            {
                obtenerIDs = autor.obtenerIDAutor(checkedListBox_listaAutores); // obtiene el id del autor recibiendo por parametro el listbox
                relacionAutorLibro.IdAutor = obtenerIDs[i]; //asigna el valor id obtenido por obtenerIDAutor() a la propiedad IdAutor de la clase RelacionAutorLibro
                relacionAutorLibro.agregarAutorLibro(); // guarda los datos en la base de datos en la tabla tblAutoresLibros
            }
        }


        private void asignarTextBoxFormEjemplares()
        {
           /* ejemplares.NumEjemplar = frmEjemplares.valorTextBox1;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox2;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox3;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox4;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox5;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox6;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox7;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox8;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox9;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox10;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox11;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox12;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox13;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox14;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox15;
            ejemplares.NumEjemplar = frmEjemplares.valorTextBox16;*/
        }

        private void checkedListBox_listaEjemplares_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /* 

            for (int i = 0; i <= checkedListBox_listaEjemplares.SelectedIndices.Count - 1; i++)
            {

                ejemplares.NumEjemplar = checkedListBox_listaEjemplares.SelectedItems[i].ToString();
               

            }*/
        }
       

      

       
    }
}
