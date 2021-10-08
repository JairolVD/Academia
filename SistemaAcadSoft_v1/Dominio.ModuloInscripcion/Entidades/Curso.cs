using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ModuloInscripcion.Servicios
{
    public class Curso
    {
        private String idCurso;
        private String nombre;

        public String IdCurso { get => idCurso; set => idCurso = value; }
        public String Nombre { get => nombre; set => nombre=value; }

    }
}
