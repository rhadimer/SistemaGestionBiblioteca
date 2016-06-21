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
using System.IO;
using System.Data.Sql;


namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    public partial class FormPrestamo : Form
    {
        Usuario usuario = new Usuario();
        Bibliotecario bibliotecario = new Bibliotecario();
        Prestamo prestamo = new Prestamo();
        Libro libro = new Libro();
        LibroPrestado libroPrestado = new LibroPrestado();
        EstadoLibro estadoLibro = new EstadoLibro();

       private SqlConnection cn;
       private SqlCommand cmd = new SqlCommand();
       private DataSet ds = new DataSet();
       private SqlDataAdapter da = new SqlDataAdapter();
       private DataRow drr ;
      // private SqlDataReader dr = new SqlDataReader();

          

        public FormPrestamo()
        {
            InitializeComponent();
           
        }

        private void FormPrestamo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sGBibliotecarioDataSet.tblBibliotecario' Puede moverla o quitarla según sea necesario.
            this.tblBibliotecarioTableAdapter.Fill(this.sGBibliotecarioDataSet.tblBibliotecario);
            // TODO: esta línea de código carga datos en la tabla 'sGBibliotecarioDataSet.tblLibro' Puede moverla o quitarla según sea necesario.
           // this.tblLibroTableAdapter.Fill(this.sGBibliotecarioDataSet.tblLibro);

            libro.cargarListaLibros(comboBox_listaLibros);

        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != null)
            {
               
                int id = Convert.ToInt32(textBox_id.Text);
                usuario.colsultarUsuario(id);
                consultarImagenUsuario(id);


                textBox_nombre.Text = usuario.Nombre;
                textBox_apellido.Text = usuario.Apellido;
                textBox_telefono.Text = usuario.Telefono;
                textBox_categoria.Text = usuario.Categoria;
                textBox_cedula.Text = usuario.Cedula;
                textBox_direccion.Text = usuario.Direccion;
                textBox_email.Text = usuario.Email;
                //pictureBox_fotografia = usuario.picfoto;
            }
            else
                MessageBox.Show("No se puede hacer una busqueda si el campo 'Codigo Lector' está en blanco");
            textBox_id.Focus();

        }

        private void textBox_nomber_TextChanged(object sender, EventArgs e)
        {
            //textBox_nombre.Text = usuario.Nombre;
        }

        private void textBox_apellido_TextChanged(object sender, EventArgs e)
        {
            //textBox_apellido.Text = usuario.Apellido;
        }

        private void textBox_telefono_TextChanged(object sender, EventArgs e)
        {
            //textBox_telefono.Text = usuario.Telefono;
        }

        private void textBox_categoria_TextChanged(object sender, EventArgs e)
        {
            //textBox_categoria.Text = usuario.Categoria;
        }

        private void textBox_cedula_TextChanged(object sender, EventArgs e)
        {
            //textBox_cedula.Text = usuario.Cedula;
        }

        private void textBox_direccion_TextChanged(object sender, EventArgs e)
        {
            //textBox_direccion.Text = usuario.Direccion;
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            //textBox_email.Text = usuario.Email;
        }


        private void consultarImagenUsuario(int textBox_id)
        {

            SGBibliotecarioDataSetTableAdapters.tblUsuarioTableAdapter tblUsuarioDA = new SGBibliotecarioDataSetTableAdapters.tblUsuarioTableAdapter();
            SGBibliotecarioDataSet.tblUsuarioDataTable tblUsuarioDS = new SGBibliotecarioDataSet.tblUsuarioDataTable();

            SqlCommand cmd = new SqlCommand();

            Cursor.Current = Cursors.WaitCursor;

            cmd.Connection = tblUsuarioDA.Connection;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT fotografia from tblUsuario WHERE id='" + textBox_id + "';";
            SqlDataReader r;

            try
            {
                tblUsuarioDA.Connection.Open();
                r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                   
                    while (r.Read())
                    {
                        
                        byte[] MyData = new byte[0];
                        
                        MyData = (byte[])r["fotografia"];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(MyData);
                       
                         MemoryStream stream = new MemoryStream(MyData);
                         pictureBox_fotografia.Image = System.Drawing.Bitmap.FromStream(ms);

                    }
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                tblUsuarioDA.Connection.Close();
            }

            Cursor.Current = Cursors.Default;

        }

        public string abrirConexion()
        {
            try
            {
                cn = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=SGBibliotecario;Integrated Security=True");
                cn.Open();
                return "Conectado";
            }
            catch (Exception ex)
            {
                return "No conectado: " + ex.ToString();
            }
        }

        private void consultarImagenLibro(ComboBox titulo)
        {
            
            try 
            {
               // cn.Open();
                abrirConexion();
                da = new SqlDataAdapter("select imagenLibro from tblLibro where titulo_original ='"+titulo.SelectedItem.ToString()+"'",cn);
                ds = new DataSet();
                da.Fill(ds,"tblLibro");
                byte[] datos = new byte[0];
                drr = ds.Tables["tblLibro"].Rows[0];
                datos = (byte[])drr["imagenLibro"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pictureBox_imagenLibro.Image = System.Drawing.Bitmap.FromStream(ms);

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo consultar la ImagenLibro: " + ex.ToString());
            }
            Cursor.Current = Cursors.Default;

        }

        private void comboBox_listaLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //...
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_titulo_TextChanged(object sender, EventArgs e)
        {
            //autoCompletar(textBox_titulo);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           // agregando los item del comboBox al listBox
                if (listBox1.Items.Count < 3)
                {
                    /*DataRowView drv = (DataRowView)comboBox_listaLibros.SelectedItem;
                    DataRow row = drv.Row;
                    object value = row["titulo_original"];
                    listBox1.Items.Add(value.ToString());*/
                    listBox1.Items.Add(comboBox_listaLibros.SelectedItem.ToString());
                }
                else
                    MessageBox.Show("No puedes prestar mas de tres libros...");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( listBox1.SelectedIndex != -1 )
                listBox1.Items.RemoveAt( listBox1.SelectedIndex );
        }



        private void comboBox_prestadoPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bibliotecario.obtenerIDBibliotecario(comboBox_prestadoPor);
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Digite el codigo del lector para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_id.Focus();
            }
            else if (maskedTextBox_horaPrestamo.Text =="")
            {
                MessageBox.Show("Digite la hora del prestamo para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox_horaPrestamo.Focus();
            }
            else if (maskedTextBox_horaEntrega.Text =="")
            {
                MessageBox.Show("Digite la hora de entrega para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox_horaEntrega.Focus();
            }
            else if (listBox1.Items.Count == 0)
            {
                MessageBox.Show(" Debes Agregar libros para continuar", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox_listaLibros.Focus();
            }
            else
            {
                int idUsuario = Convert.ToInt32(textBox_id.Text);
                prestamo.Idusuario = idUsuario;

                //asignando el item seleccionado del combobox a un object para obtener el id del item seleccionado
                DataRowView drv = (DataRowView)comboBox_prestadoPor.SelectedItem;
                DataRow row = drv.Row;
                object value = row["id"];

                //bibliotecario.obtenerIDBibliotecario(comboBox_prestadoPor);
                prestamo.Idbibliotecario = Convert.ToInt32(value.ToString());

                prestamo.FechaHoraPrestamo = dateTimePicker_fecha.Text.ToString();
                prestamo.HoraPrestamo = maskedTextBox_horaPrestamo.Text.ToString();
                prestamo.Horaentrega = maskedTextBox_horaEntrega.Text.ToString();

                prestamo.agregarPrestamoLibro();

                prestamo.obtenerIDPrestamo();
                libroPrestado.IdPrestamoLibro = prestamo.Id;

                int[] obtenerIDs = new int[3];

                obtenerIDs = libro.obtenerIDLibroListBox(listBox1);

                libro.obtenerIDLibroListBox(listBox1);


                for (int i = 0; i <= listBox1.Items.Count - 1; i++)
                {
                    libroPrestado.IdLibro = obtenerIDs[i];
                    libroPrestado.agregarLibroPrestado();

                    estadoLibro.IdLibro = obtenerIDs[i];
                    estadoLibro.actualizarEstadoPrestado();


                }
            }
        }

        private void comboBox_listaLibros_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           // consultarImagenLibro(comboBox_listaLibros);
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            if(textBox_id.Text != null)
            {
                 button_buscar.Enabled = true;
            }
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_id.Text = string.Empty;
            textBox_nombre.Text = string.Empty;
            textBox_apellido.Text = string.Empty;
            textBox_telefono.Text = string.Empty;
            textBox_categoria.Text = string.Empty;
            textBox_cedula.Text = string.Empty;
            textBox_direccion.Text = string.Empty;
            textBox_email.Text = string.Empty;
            pictureBox_fotografia.Image = null;
            maskedTextBox_horaPrestamo.Text = string.Empty;
            maskedTextBox_horaEntrega.Text = string.Empty;
        }

    }
}
