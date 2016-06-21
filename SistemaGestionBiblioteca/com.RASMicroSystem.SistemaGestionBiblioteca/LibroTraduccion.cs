using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    class LibroTraduccion
    {
        public string id { set; get; }
        public string idLibro { set; get; }
        public string idiomaTraduccion { set; get; }
        public string anioTraduccion { set; get; }
        public string tituloTraduccion { set; get; }
        public string traductorTraduccion { set; get; }
        public string ilustradorTraduccion { set; get; }
        public string artistaTraduccion { set; get; }
        public string editorialTraduccion { set; get; }
        public string ciudadTraduccion { set; get; }
        public string paisTraduccion { set; get; }
        public string isbnTraduccion { set; get; }
        public string oclcTraduccion { set; get; }
        public string formatoTraduccion { set; get; }
        public string numeroDePaginaTraducion { set; get; }


        public void agregarLibroTraduccion() { }
        public void eliminarLibroTraduccion() { }
        public void modificarLibroTraduccion() { }
        public void colsultarLibroTraduccion() { }
    }
}
