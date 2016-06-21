using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    class SolicitudLibros
    {
        public string id { set; get; }
        public string idUsuario { set; get; }
        public string tituloLibroSolicitud { set; get; }
        public string autorLibroSolicitud { set; get; }
        public string fechaSolicitud { set; get; }

        public void agregarSolicitudLibro() { }
        public void eliminarSolicitudLibro() { }
        public void modificarSolicitudLibro() { }
        public void consultarSolicitudLibro() { }

    }
}
