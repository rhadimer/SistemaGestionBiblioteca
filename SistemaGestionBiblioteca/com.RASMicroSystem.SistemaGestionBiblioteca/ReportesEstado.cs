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
    class ReportesEstado
    {
        SGBibliotecarioDataSet6TableAdapters.tblLibroTableAdapter tblLibroDA = new SGBibliotecarioDataSet6TableAdapters.tblLibroTableAdapter();
        SGBibliotecarioDataSet6.tblLibroDataTable tblLibroDS = new SGBibliotecarioDataSet6.tblLibroDataTable();

        SGBibliotecarioDataSet5_VistasTableAdapters.View_LibrosPrestadosTableAdapter viewLibrosPrestadosDA = new SGBibliotecarioDataSet5_VistasTableAdapters.View_LibrosPrestadosTableAdapter();
        SGBibliotecarioDataSet5_Vistas.View_LibrosPrestadosDataTable viewLibrosPrestadosDS = new SGBibliotecarioDataSet5_Vistas.View_LibrosPrestadosDataTable();

        SGBibliotecarioDataSet5_VistasTableAdapters.View_LibroDevueltoTableAdapter viewLibroDevueltoDA = new SGBibliotecarioDataSet5_VistasTableAdapters.View_LibroDevueltoTableAdapter();
        SGBibliotecarioDataSet5_Vistas.View_LibroDevueltoDataTable viewLibroDevueltoDS = new SGBibliotecarioDataSet5_Vistas.View_LibroDevueltoDataTable();

        SGBibliotecarioDataSet6TableAdapters.tblUsuarioTableAdapter tblUsuarioDA = new SGBibliotecarioDataSet6TableAdapters.tblUsuarioTableAdapter();
        SGBibliotecarioDataSet6.tblUsuarioDataTable tblUsuarioDS = new SGBibliotecarioDataSet6.tblUsuarioDataTable();
        
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sqldr;

        public void totalLibros(Label label)
        {

            try
            {
                tblLibroDA.Connection.Open();
                cmd = new SqlCommand("SELECT COUNT(id) AS [TotalLibro] from tblLibro", tblLibroDA.Connection);
                sqldr = cmd.ExecuteReader();

                while (sqldr.Read())
                {
                    label.Text = sqldr["TotalLibro"].ToString();
                }
                sqldr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener el total de libros. " + ex.ToString());
            }
            finally
            {
                tblLibroDA.Connection.Close();
            }
        }

        public void totalLibrosPrestados(Label label)
        {

            try
            {
                viewLibrosPrestadosDA.Connection.Open();
                cmd = new SqlCommand("SELECT COUNT([Codigo Prestamo]) AS [TotalLibroPrestado] from View_LibrosPrestados", viewLibrosPrestadosDA.Connection);
                sqldr = cmd.ExecuteReader();

                while (sqldr.Read())
                {
                    label.Text = sqldr["TotalLibroPrestado"].ToString();
                }
                sqldr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener el total de libros prestados. " + ex.ToString());
            }
            finally
            {
                viewLibrosPrestadosDA.Connection.Close();
            }
        }

        public void totalLibrosEnRecepcion(Label label)
        {

            try
            {
                viewLibroDevueltoDA.Connection.Open();
                cmd = new SqlCommand("SELECT COUNT([id]) AS [TotalLibroDevuelto] from View_LibroDevuelto", viewLibroDevueltoDA.Connection);
                sqldr = cmd.ExecuteReader();

                while (sqldr.Read())
                {
                    label.Text = sqldr["TotalLibroDevuelto"].ToString();
                }
                sqldr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener el total de libros en recepción. " + ex.ToString());
            }
            finally
            {
                viewLibroDevueltoDA.Connection.Close();
            }
        }

        public void totalUsuarios(Label label)
        {

            try
            {
                tblUsuarioDA.Connection.Open();
                cmd = new SqlCommand("SELECT COUNT(id) AS [TotalUsuario] from tblUsuario", tblUsuarioDA.Connection);
                sqldr = cmd.ExecuteReader();

                while (sqldr.Read())
                {
                    label.Text = sqldr["TotalUsuario"].ToString();
                }
                sqldr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener el total de usuarios. " + ex.ToString());
            }
            finally
            {
                tblUsuarioDA.Connection.Close();
            }
        }










    }
}
