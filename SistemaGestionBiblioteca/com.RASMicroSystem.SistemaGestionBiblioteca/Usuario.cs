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



namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    class Usuario
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Direccion { set; get; }
        public string Email { set; get; }
        public string Telefono { set; get; }
        public string FechaDeRegistro { set; get; }
        public string Cedula { set; get; }
        public string Categoria { set; get; }
        public byte[] Fotografia { set; get; }
        public string Total { set; get; }//esta propiedad es solo para devolver la cantidad de registro del dataGridView en el metodo consultarUsuario
        public PictureBox picfoto { set; get; }
       

      public void agregarUsuario(PictureBox fotografia)
      {

          System.IO.MemoryStream ms = new System.IO.MemoryStream();
          //guardando la fotografia
          fotografia.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
          
         // bool ret = false;
        
          SqlConnection miConexion = new SqlConnection(Conexion.conexion);

          SqlCommand cmd = new SqlCommand();
          cmd.Connection = miConexion;
          cmd.CommandType = System.Data.CommandType.StoredProcedure;// para almacenar desde un procedimiento almacenado
          cmd.CommandText = "dbo.Guard_Usuario";// Nombre del procedimiento almacenado
       

          cmd.Parameters.AddWithValue("@nombre", Nombre);
          cmd.Parameters.AddWithValue("@apellido", Apellido);
          cmd.Parameters.AddWithValue("@direccion", Direccion);
          cmd.Parameters.AddWithValue("@email", Email);
          cmd.Parameters.AddWithValue("@telefono", Telefono);
          cmd.Parameters.AddWithValue("@fechaDeRegistro",FechaDeRegistro);
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

      public void eliminarUsuario() { }
      public void modificarUsuario() { }

      public void colsultarUsuario(int textBox_id) 
      {
          
          SGBibliotecarioDataSetTableAdapters.tblUsuarioTableAdapter tblUsuarioDA = new SGBibliotecarioDataSetTableAdapters.tblUsuarioTableAdapter();
          SGBibliotecarioDataSet.tblUsuarioDataTable tblUsuarioDS = new SGBibliotecarioDataSet.tblUsuarioDataTable();
          
          SqlCommand cmd =new SqlCommand();
          
          Cursor.Current = Cursors.WaitCursor;

          cmd.Connection = tblUsuarioDA.Connection;
          cmd.CommandType = System.Data.CommandType.Text;
          cmd.CommandText = "SELECT nombre, apellido, telefono, categoria, cedula, direccion, email from tblUsuario WHERE id='" + textBox_id+"';";
          SqlDataReader r;

          byte[] MyData = new byte[0];

          try
          {
              tblUsuarioDA.Connection.Open();
              r = cmd.ExecuteReader();
              if (r.HasRows)
              {
                  while (r.Read())
                  {
                      //MyData = (byte[])r["fotografia"];
                     // MemoryStream stream = new MemoryStream(MyData);
                     // picfoto.Image = Image.FromStream(stream);
                      Nombre = r["nombre"].ToString();
                      Apellido = r["apellido"].ToString();
                      Telefono = r["telefono"].ToString();
                      Categoria = r["categoria"].ToString();
                      Cedula = r["cedula"].ToString();
                      Direccion = r["direccion"].ToString();
                      Email = r["email"].ToString();

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
        
    }
}
