using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Data;

namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    class Bibliotecario
    {
        SGBibliotecarioDataSetTableAdapters.tblBibliotecarioTableAdapter tblbDA = new SGBibliotecarioDataSetTableAdapters.tblBibliotecarioTableAdapter();
        SGBibliotecarioDataSet.tblBibliotecarioDataTable tblbDS = new SGBibliotecarioDataSet.tblBibliotecarioDataTable();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sqldr;
        
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Direccion { set; get; }
        public string Email { set; get; }
        public string Telefono { set; get; }
        public string FechaDeRegistro { set; get; }
        public string Cedula { set; get; }
        public string Categoria { set; get; }

        public string Total { set; get; }

        public void agregarBibliotecario(PictureBox fotografia) 
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //guardando la fotografia
            fotografia.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            // bool ret = false;

            SqlConnection miConexion = new SqlConnection(Conexion.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = miConexion;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;// para almacenar desde un procedimiento almacenado
            cmd.CommandText = "dbo.Guard_Bibliotecario";// Nombre del procedimiento almacenado


            cmd.Parameters.AddWithValue("@nombre", Nombre);
            cmd.Parameters.AddWithValue("@apellido", Apellido);
            cmd.Parameters.AddWithValue("@direccion", Direccion);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@telefono", Telefono);
            cmd.Parameters.AddWithValue("@fechaDeRegistro", FechaDeRegistro);
            cmd.Parameters.AddWithValue("@cedula", Cedula);
            cmd.Parameters.AddWithValue("@categoria ", Categoria);
            cmd.Parameters.AddWithValue("@fotografia", ms.GetBuffer());

            try
            {
                miConexion.Open();
                cmd.ExecuteNonQuery();

                // ret = true;
                MessageBox.Show("Los datos se guardaron correctamente!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                miConexion.Close();
            }
            //return ret;
        }

        public void eliminarBibliotecario() { }
        public void modificarBibliotecario() { }


        public void colsultarBibliotecario(DataGridView dataGridView_usuario) 
        {
            SGBibliotecarioDataSetTableAdapters.tblUsuarioTableAdapter tblUsuarioDA = new SGBibliotecarioDataSetTableAdapters.tblUsuarioTableAdapter();
            SGBibliotecarioDataSet.tblUsuarioDataTable tblUsuarioDS = new SGBibliotecarioDataSet.tblUsuarioDataTable();

            SqlCommand cmd;

            Cursor.Current = Cursors.WaitCursor;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT id, nombre, apellido, telefono, categoria FROM tblBibliotecario WHERE 1=1");
            if (Nombre.Length > 0)
                sql.Append(" AND nombre LIKE '%" + Nombre + "%' ");
            if (Apellido.Length > 0)
                sql.Append(" AND apellido LIKE '%" + Apellido + "%' ");
            if (Id > 0)
                sql.Append("id = '" + Id + "'");

            ///Para remover la mascara..
            // string valor = this.maskedTextBox_cedula.Text.Replace(this.maskedTextBox_cedula.PromptChar, ' ');
            // valor = valor.Replace('-', ' ').Trim();

            if (Cedula.Length > 0)
                sql.Append(" AND cedula LIKE '%" + Cedula + "%'");

            sql.Append(" ORDER BY nombre asc, apellido, telefono, categoria");

            cmd = new SqlCommand(sql.ToString(), tblUsuarioDA.Connection); //El comando que manejara el query.



            try
            {
                tblUsuarioDA.Connection.Open();
                tblUsuarioDA.Fill(tblUsuarioDS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                tblUsuarioDA.Connection.Close();
            }

            dataGridView_usuario.DataSource = tblUsuarioDS; //Asignando la fuente de los datos...

            if (tblUsuarioDA != null)
                Total = tblUsuarioDS.Rows.Count.ToString("#,###;;0");//El conteo de los registros del query.

            Cursor.Current = Cursors.Default;
        }


        public void obtenerIDBibliotecario(ComboBox combotBox)
        {
                string nombre = combotBox.SelectedItem.ToString();
                cmd = new SqlCommand("select id from tblBibliotecario where nombre ='" + nombre + " ';", tblbDA.Connection);


                try
                {

                    tblbDA.Connection.Open();
                    sqldr = cmd.ExecuteReader();

                    MessageBox.Show("los datos se obtubieron correctamente en la tabla Bibliotecario " + nombre);

                    if (sqldr.HasRows)
                    {
                        while (sqldr.Read())
                        {
                            Id = Convert.ToInt32(sqldr["id"]);
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
                    tblbDA.Connection.Close();
                   // cmd.Parameters.Clear();
                }

            

        }


    }
}
