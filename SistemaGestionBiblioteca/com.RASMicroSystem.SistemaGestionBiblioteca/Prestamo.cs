using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;


namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    class Prestamo : Libro
    {
        SGBibliotecarioDataSetTableAdapters.tblPrestamoLibroTableAdapter tblPrestamoLibroDA = new SGBibliotecarioDataSetTableAdapters.tblPrestamoLibroTableAdapter();
        SGBibliotecarioDataSet.tblPrestamoLibroDataTable tblPrestamoLibroDS = new SGBibliotecarioDataSet.tblPrestamoLibroDataTable();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sqldr;
        
        public int Id { set; get; }
        public int Idusuario { set; get; }
        public int Idbibliotecario { set; get; }
        public string FechaHoraPrestamo { set; get; }
        public string HoraPrestamo { set; get; }
        public string Horaentrega { set; get; }

        public void agregarPrestamoLibro() //insert
        {
            cmd.Connection = tblPrestamoLibroDA.Connection;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Guard_Prestamo";

            cmd.Parameters.AddWithValue("@idusuario", Idusuario);
            cmd.Parameters.AddWithValue("@idbibliotecario", Idbibliotecario);
            cmd.Parameters.AddWithValue("@fecha",FechaHoraPrestamo);
            cmd.Parameters.AddWithValue("@horaprestamo", HoraPrestamo);
            cmd.Parameters.AddWithValue("@horaentrega", Horaentrega);

            try
            {

                tblPrestamoLibroDA.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente! en la tabla de PrestamoLibro");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tblPrestamoLibroDA.Connection.Close();
                cmd.Parameters.Clear();
            }
        }

        public void obtenerIDPrestamo()
        {

            cmd = new SqlCommand("select MAX(id) as Contador from tblPrestamoLibro ", tblPrestamoLibroDA.Connection);

            try
            {

                tblPrestamoLibroDA.Connection.Open();
                sqldr = cmd.ExecuteReader();

                MessageBox.Show("los datos se obtubieron correctamente en la tabla libro");

                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        Id = Convert.ToInt32(sqldr["Contador"]);

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
                tblPrestamoLibroDA.Connection.Close();
            }

          
        }

        public void consultarPrestamo(string textBox_id)
        {

            SGBibliotecarioDataSetTableAdapters.tblPrestamoLibroTableAdapter tblPrestamoDA = new SGBibliotecarioDataSetTableAdapters.tblPrestamoLibroTableAdapter();
            SGBibliotecarioDataSet.tblPrestamoLibroDataTable tblPrestamoDS = new SGBibliotecarioDataSet.tblPrestamoLibroDataTable();

            SqlCommand cmd = new SqlCommand();

            Cursor.Current = Cursors.WaitCursor;

            cmd.Connection = tblPrestamoDA.Connection;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT idbibliotecario, fecha, horaprestamo, horaentrega from tblPrestamoLibro WHERE id='" + textBox_id + "';";
            SqlDataReader r;

            try
            {
                tblPrestamoDA.Connection.Open();
                r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        
                        Idbibliotecario = Convert.ToInt32(r["idbibliotecario"].ToString());
                        FechaHoraPrestamo = r["fecha"].ToString();
                        HoraPrestamo = r["horaprestamo"].ToString();
                        Horaentrega = r["horaentrega"].ToString();
                      
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
                tblPrestamoDA.Connection.Close();
            }

            Cursor.Current = Cursors.Default;
        }


        public void eliminarPrestamoLibro() { } //delete
        public void modificarPrestamoLibro() { } //update
        


    }
}
