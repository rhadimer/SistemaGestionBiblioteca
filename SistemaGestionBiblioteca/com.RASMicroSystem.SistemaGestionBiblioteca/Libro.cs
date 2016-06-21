using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;



namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    public class Libro
    {

        SGBibliotecarioDataSetTableAdapters.tblLibroTableAdapter tblLibroDA = new SGBibliotecarioDataSetTableAdapters.tblLibroTableAdapter();
        SGBibliotecarioDataSet.tblLibroDataTable tblLibroDS = new SGBibliotecarioDataSet.tblLibroDataTable();

        SGBibliotecarioDataSet4_VistasTableAdapters.View_LibrosSinPrestarTableAdapter viewLibrosSinPrestarDA = new SGBibliotecarioDataSet4_VistasTableAdapters.View_LibrosSinPrestarTableAdapter();
        SGBibliotecarioDataSet4_Vistas.View_LibrosSinPrestarDataTable viewLibrosSinPrestarDS = new SGBibliotecarioDataSet4_Vistas.View_LibrosSinPrestarDataTable();

        SqlCommand cmd =new SqlCommand();
        SqlDataReader sqldr;

        LibroPrestado libroPrestado = new LibroPrestado();
       
        
        

        // ***** Fichas Para Libros Traducido Al Español   ************
        public int    Id { set; get; }
        public string ImagenLibro { set; get; }
        public string Editor { set; get; }
        public string Genero { set; get; }
        public string Subgenero { set; get; }
        public string Idioma_Original { set; get; }
        public string Titulo_Original { set; get; }
        public string Tema { set; get; }
        public string Sinopsis { set; get; }
        public string Ilustrador_Original { set; get; }
        public string ArtistaDeCubierta_Original { set; get; }
        public string Publicacion_Original { set; get; }
        public string Editorial_Original { set; get; }
        public string Ciudad_Original { set; get; }
        public string Pais_Original { set; get; }
        public string Fecha_Original { set; get; }
        public string Formato_Original { set; get; }
        public int    NumeroDePagina_Original { set; get; }
        public string ISBN_original { set; get; }
        public string OCLC_original { set; get; }
        public string PalabasClaves { set; get; }
        public string Categoria { set; get; }
        public string Clasificacion { set; get; }
       // public string Estado { set; get; } //Los libros tendrán tres estados diferentes: prestado, devuelto y en estante.
        public string Premios { set; get; }
        public int Cantidad { set; get; }
        public string Estado_fisico { set; get; }
        //public List<int> ObtenerIDs = new List<int>();
        //public int[] ObtenerIDs = new int[3];

        //***** Metodos ************

        public void agregarLibro(PictureBox imagenLibro)// insert
        {
            
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //guardando la imagenLibro
            imagenLibro.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);

           
            cmd.Connection = tblLibroDA.Connection;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Guard_libro"; // nombre del procedimiento almacenado

            cmd.Parameters.AddWithValue("@imagenLibro", ms.GetBuffer());
            cmd.Parameters.AddWithValue("@editor", Editor);
            cmd.Parameters.AddWithValue("@genero",Genero);
            cmd.Parameters.AddWithValue("@subgenero",Subgenero);
            cmd.Parameters.AddWithValue("@idioma_original",Idioma_Original);
            cmd.Parameters.AddWithValue("@titulo_original ", Titulo_Original);
            cmd.Parameters.AddWithValue("@tema",Tema);
            cmd.Parameters.AddWithValue("@sinopsis ", Sinopsis);
            cmd.Parameters.AddWithValue("@ilustrador_original ", Ilustrador_Original);
            cmd.Parameters.AddWithValue("@artistaDeCurbierta_original ", ArtistaDeCubierta_Original);
            cmd.Parameters.AddWithValue("@publicacion_original ", Publicacion_Original);
            cmd.Parameters.AddWithValue("@editorial_original ", Editorial_Original);
            cmd.Parameters.AddWithValue("@ciudad_original ", Ciudad_Original);
            cmd.Parameters.AddWithValue("@pais_original ", Pais_Original);
            cmd.Parameters.AddWithValue("@fecha_original ", Fecha_Original);
            cmd.Parameters.AddWithValue("@formato_original ", Formato_Original);
            cmd.Parameters.AddWithValue("@numeroDePagina_origina ", NumeroDePagina_Original);
            cmd.Parameters.AddWithValue("@isbn_original ", ISBN_original);
            cmd.Parameters.AddWithValue("@oclc_original ", OCLC_original);
            cmd.Parameters.AddWithValue("@palabrasClaves ", PalabasClaves);
            cmd.Parameters.AddWithValue("@categoria ", Categoria);
            cmd.Parameters.AddWithValue("@clasificacion ", Clasificacion);
            cmd.Parameters.AddWithValue("@premios", Premios);
            cmd.Parameters.AddWithValue("@cantidad ", Cantidad);
           // cmd.Parameters.AddWithValue("@estado ", Estado);
            cmd.Parameters.AddWithValue("@estado_fisico", Estado_fisico);

            try 
            {
                tblLibroDA.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente!");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                tblLibroDA.Connection.Close();
            }


        }

        // este metodo obtienee el id del ultimo registro o libro que se ingreso a la base de datos
        public void obtenerIDLibro() 
        {
            
            cmd = new SqlCommand("select MAX(id) as Contador from tblLibro ",tblLibroDA.Connection);

            try
            {

                tblLibroDA.Connection.Open();
                sqldr = cmd.ExecuteReader();

                MessageBox.Show("los datos se obtubieron correctamente en la tabla libro");

                 if(sqldr.HasRows)
                 {
                     while (sqldr.Read())
                     {
                         Id = Convert.ToInt32( sqldr["Contador"]);
                         
                     }
                 }
                 sqldr.Close();
            
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                tblLibroDA.Connection.Close();
            }


        }

      
        public int[] obtenerIDLibroListBox(ListBox listBox)
        {
           // List<int> obtenerIDs2 = new List<int>();
            const int cantidadLibros = 3;
            int[] ObtenerIDs = new int[cantidadLibros];
                try
                {                
                    for (int i = 0; i <= cantidadLibros; i++)
                    {
                        string titulo = listBox.Items[i].ToString();
                        cmd = new SqlCommand("select id from tblLibro where titulo_original ='" + titulo + " ';", tblLibroDA.Connection);


                        tblLibroDA.Connection.Open();
                        sqldr = cmd.ExecuteReader();

                        MessageBox.Show("los datos se obtubieron correctamente en la tabla Libro");
                      

                        if (sqldr.HasRows)
                        {
                            while (sqldr.Read())
                            {
                                ObtenerIDs[i] = Convert.ToInt32(sqldr["id"]);
                                MessageBox.Show("el valor de ObtenerIDs en la posicion "+i+" es: "+ObtenerIDs[i]);
                            }

                        }
                            sqldr.Close();
                            tblLibroDA.Connection.Close();                           
                     }

                    return ObtenerIDs;

                 }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return ObtenerIDs;
                }

                finally
                {
                    tblLibroDA.Connection.Close();
                    cmd.Parameters.Clear(); 
                }                
        }



        public void cargarListaLibros(ComboBox combobox)
        {
            
            try
            {
                viewLibrosSinPrestarDA.Connection.Open();
                cmd = new SqlCommand("SELECT dbo.tblLibro.titulo_original FROM dbo.tblLibro INNER JOIN dbo.tblEstado ON dbo.tblLibro.id = dbo.tblEstado.idLibro WHERE (dbo.tblEstado.nombreEstado = 'En estante')", viewLibrosSinPrestarDA.Connection);
                sqldr = cmd.ExecuteReader();
               
                while (sqldr.Read())
                {
                    combobox.Items.Add(sqldr["titulo_original"]);
                }
                sqldr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargaron los autores en el ComboBox: " + ex.ToString());
            }
            finally
            {
                viewLibrosSinPrestarDA.Connection.Close();
            }
        }

        

        public void eliminarLibro() { } // delete
        public void modificarLibro() { } // update
        public void colsultarLibro() { } // select
        

    }
}
