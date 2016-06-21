using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    class RelacionAutorLibro
    {
        SGBibliotecarioDataSetTableAdapters.tblAutoresLibrosTableAdapter tblAutorLibroDA = new SGBibliotecarioDataSetTableAdapters.tblAutoresLibrosTableAdapter();
        SGBibliotecarioDataSet.tblAutoresLibrosDataTable tblAutorLibroDS = new SGBibliotecarioDataSet.tblAutoresLibrosDataTable();
        SqlCommand cmd = new SqlCommand();

       // public int Id { set; get; }
        public int IdLibro { set; get;}
        public int IdAutor { set; get; }

        public void agregarAutorLibro()
        {
            //for (int i = 0; i <= listBox.SelectedIndices.Count - 1; i++)
            //{
                //if (listBox.GetSelected(i))
                //{

                    cmd.Connection = tblAutorLibroDA.Connection;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.Guard_AutoresLibros"; // nombre del procedimiento almacenado

                    cmd.Parameters.AddWithValue("@idLibro", IdLibro);
                    cmd.Parameters.AddWithValue("@idAutor", IdAutor);

                    try
                    {
                        tblAutorLibroDA.Connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Los datos se guardaron correctamente! en la tabla de AutoresLibros");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tblAutorLibroDA.Connection.Close();
                        cmd.Parameters.Clear();
                    }
                //}
            //}
        }

        public void consultarAutorLibro() 
        {

        }

    }
}
