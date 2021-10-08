using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ModuloInscripcion.Servicios
{
    public class Inscripcion
    {
        private int idInscripcion;
        private DateTime fecha;
        private Alumno alumno;
        private Clase clase;

        public int IdInscripcion { get => idInscripcion; set => idInscripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Alumno Alumno { get => alumno; set => alumno = value; }
        public Clase Clase { get => clase; set => clase = value; }

    }
}
