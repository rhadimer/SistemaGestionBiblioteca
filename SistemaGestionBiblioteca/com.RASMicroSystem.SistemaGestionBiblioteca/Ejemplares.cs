using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    class Ejemplares
    {
        SGBibliotecarioDataSetTableAdapters.tblEjemplaresTableAdapter tblEjemplaresDA = new SGBibliotecarioDataSetTableAdapters.tblEjemplaresTableAdapter();
        SGBibliotecarioDataSet.tblEjemplaresDataTable tblEjemplareDS = new SGBibliotecarioDataSet.tblEjemplaresDataTable();
        SqlCommand cmd = new SqlCommand();
        

        public int IdLibro { set; get; }
        public string NumEjemplar { set; get; }

        public void agregarEjemplar(CheckedListBox checkLista) 
        {
            for (int i = 0; i <= checkLista.CheckedIndices.Count - 1; i++)
            {
                if (checkLista.GetItemChecked(i))
                { 
                NumEjemplar = checkLista.CheckedItems[i].ToString();
                    
                cmd.Connection = tblEjemplaresDA.Connection;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Guard_Ejemplares";
              
                cmd.Parameters.AddWithValue("@idLibro", IdLibro);
                cmd.Parameters.AddWithValue("@numeroDeEjemplar", NumEjemplar);

                try
                {

                    tblEjemplaresDA.Connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos se guardaron correctamente! en la tabla de Ejempares");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tblEjemplaresDA.Connection.Close();
                    cmd.Parameters.Clear();
                }
            }
            }
        }

    }
}
