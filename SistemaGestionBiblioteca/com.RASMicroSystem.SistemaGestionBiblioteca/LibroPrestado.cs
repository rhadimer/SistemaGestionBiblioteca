using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    class LibroPrestado
    {
        SGBibliotecarioDataSet2TableAdapters.tblLibroPrestadoTableAdapter tblLibroPrestadoDA = new SGBibliotecarioDataSet2TableAdapters.tblLibroPrestadoTableAdapter();
        SGBibliotecarioDataSet2.tblLibroPrestadoDataTable tblLibroPrestadoDS = new SGBibliotecarioDataSet2.tblLibroPrestadoDataTable();
        SqlCommand cmd = new SqlCommand();

        public int IdPrestamoLibro { set; get; }
        public int IdLibro { set; get; }

        
        
        
        public void agregarLibroPrestado() //insert
        {
            

                cmd.Connection = tblLibroPrestadoDA.Connection;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Guard_LibroPrestado";

                cmd.Parameters.AddWithValue("@idPrestamoLibro", IdPrestamoLibro);
                cmd.Parameters.AddWithValue("@idLibro", IdLibro);

                try
                {

                    tblLibroPrestadoDA.Connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos se guardaron correctamente! en la tabla de LibroPrestado");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tblLibroPrestadoDA.Connection.Close();
                    cmd.Parameters.Clear();
                }
 
        }

        public void eliminarLibroPrestado(string idLibro) 
        {
            cmd.Connection = tblLibroPrestadoDA.Connection;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Eliminar_LibroPrestado";

            cmd.Parameters.AddWithValue("@idLibro", idLibro);
            
        

            try
            {

                tblLibroPrestadoDA.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los libros se devolvieron correctamente!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tblLibroPrestadoDA.Connection.Close();
                cmd.Parameters.Clear();
            }
        }
    }
}
