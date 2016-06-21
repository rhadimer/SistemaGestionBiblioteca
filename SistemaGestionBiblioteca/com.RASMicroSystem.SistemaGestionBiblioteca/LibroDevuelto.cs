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
    class LibroDevuelto
    {
        
        SqlCommand cmd = new SqlCommand();
        SGBibliotecarioDataSet6TableAdapters.tblLibroDevueltoTableAdapter tblLibroDevueltoDA = new SGBibliotecarioDataSet6TableAdapters.tblLibroDevueltoTableAdapter();
        SGBibliotecarioDataSet6.tblLibroDevueltoDataTable tblLibroDevueltoDS = new SGBibliotecarioDataSet6.tblLibroDevueltoDataTable();

        public void eliminarLibroDevuelto(string idLibro)
        {
            cmd.Connection = tblLibroDevueltoDA.Connection;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Eliminar_LibroDevuelto";

            cmd.Parameters.AddWithValue("@idLibro", idLibro);



            try
            {

                tblLibroDevueltoDA.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los libros se devolvieron correctamente!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tblLibroDevueltoDA.Connection.Close();
                cmd.Parameters.Clear();
            }
        }
    }
}
