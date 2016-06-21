using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.IO;

namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    public class Autor
    {

        SqlCommand cmd = new SqlCommand();
        SqlDataReader sqldr;
        SGBibliotecarioDataSetTableAdapters.tblAutorTableAdapter tblAutorDA = new SGBibliotecarioDataSetTableAdapters.tblAutorTableAdapter();
        SGBibliotecarioDataSet.tblAutorDataTable tblAutorDS = new SGBibliotecarioDataSet.tblAutorDataTable();

        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Nacionalidad { set; get; }
        public string FotografiaAutor { set; get; }

        public void agregarAutor(PictureBox fotografia) //insert
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            fotografia.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

           
           
            cmd.Connection = tblAutorDA.Connection;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Guard_autor";

            cmd.Parameters.AddWithValue("@nombre", Nombre);
           // cmd.Parameters.AddWithValue("@apellido", Apellido);
            cmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
            cmd.Parameters.AddWithValue("@fotografia_autor", ms.GetBuffer());

            try
            {
                tblAutorDA.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                tblAutorDA.Connection.Close();
            } 
        }  


        public void eliminarAutor() { } // delete
        public void modificarAutor() { } // update
        public void colsultarAutor() { } // select

       
        //Esta funcion o metodo llena un ComboBox desde una base de datos
        public void cargarListaAutores(CheckedListBox check_autor)
        {
            try
            {
                tblAutorDA.Connection.Open();
                cmd = new SqlCommand("Select nombre from tblAutor", tblAutorDA.Connection);
                sqldr = cmd.ExecuteReader();

                while (sqldr.Read())
                {
                    check_autor.Items.Add(sqldr["nombre"]);
                }
                sqldr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargaron los autores en el CheckedListBox: " + ex.ToString());
            }
            finally 
            {
                tblAutorDA.Connection.Close();
            }
        }


        // este metodo obtiene el id del registro o autor seleccionado en el comboBox
        public int[] obtenerIDAutor(CheckedListBox checklistBox) 
        {
            const int cantidadAutores = 10;
            int[] ObtenerIDs = new int[cantidadAutores];

             try
             {
                for (int i = 0; i <= checklistBox.CheckedIndices.Count - 1; i++)
                {
                     if (checklistBox.GetItemChecked(i))
                     {
                            string nombreAutor = checklistBox.CheckedItems[i].ToString();
                            cmd = new SqlCommand("select id from tblAutor where nombre ='" + nombreAutor + " ';", tblAutorDA.Connection);


                           tblAutorDA.Connection.Open();
                            sqldr = cmd.ExecuteReader();

                            MessageBox.Show("los datos se obtubieron correctamente en la tabla autor");

                            if (sqldr.HasRows)
                            {
                                while (sqldr.Read())
                                {
                                    ObtenerIDs[i] = Convert.ToInt32(sqldr["id"]);
                                }
                            }
                        sqldr.Close();
                        tblAutorDA.Connection.Close();

                    }
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
                        tblAutorDA.Connection.Close();
                        cmd.Parameters.Clear();
                    }
                
            }

    }

}