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
    class EstadoLibro
    {
        SGBibliotecarioDataSetTableAdapters.tblEstadoTableAdapter tblEstadoDA = new SGBibliotecarioDataSetTableAdapters.tblEstadoTableAdapter();
        SGBibliotecarioDataSet.tblEstadoDataTable tblEstadoDS = new SGBibliotecarioDataSet.tblEstadoDataTable();
        SqlCommand cmd = new SqlCommand();
        
        public int  IdLibro{set; get;}
        public string NombreEstado { set; get; }

        public void agregarEstado() 
        {
            cmd.Connection = tblEstadoDA.Connection;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Guard_Estado";

            cmd.Parameters.AddWithValue("@idLibro", IdLibro);
            cmd.Parameters.AddWithValue("@nombreEstado", NombreEstado);

            try
            {

                tblEstadoDA.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente! en la tabla de tblEstado");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tblEstadoDA.Connection.Close();
                cmd.Parameters.Clear();
            }
        }

        public void actualizarEstadoDevuelto() 
        {
            cmd.Connection = tblEstadoDA.Connection;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Actualiza_Estado_Devuelto";

            cmd.Parameters.AddWithValue("@idLibro", IdLibro);
           // cmd.Parameters.AddWithValue("@nombreEstado", NombreEstado);

            try
            {

                tblEstadoDA.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos se actualizaron correctamente! en la tabla de tblEstado");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tblEstadoDA.Connection.Close();
                cmd.Parameters.Clear();
            }
        }

        public void actualizarEstadoPrestado()
        {
            cmd.Connection = tblEstadoDA.Connection;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Actualiza_Estado_Prestado";

            cmd.Parameters.AddWithValue("@idLibro", IdLibro);
            // cmd.Parameters.AddWithValue("@nombreEstado", NombreEstado);

            try
            {

                tblEstadoDA.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos se actualizaron correctamente! en la tabla de tblEstado");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tblEstadoDA.Connection.Close();
                cmd.Parameters.Clear();
            }
        }

        public void actualizarEstadoEnEstante()
        {
            cmd.Connection = tblEstadoDA.Connection;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Actualiza_Estado_EnEstante";

            cmd.Parameters.AddWithValue("@idLibro", IdLibro);
            // cmd.Parameters.AddWithValue("@nombreEstado", NombreEstado);

            try
            {

                tblEstadoDA.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos se actualizaron correctamente! en la tabla de tblEstado");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tblEstadoDA.Connection.Close();
                cmd.Parameters.Clear();
            }
        }
    }
}
