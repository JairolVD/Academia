using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ModuloInscripcion.Servicios
{
    public class Evaluacion
    {
        private int idEvaluacion;
        private float nota;
        private Alumno alumno;
        private ProductoAcademico productoAcademico;

        public int IdEvaluacion { get => idEvaluacion; set => idEvaluacion = value; }
        public float Nota { get => nota; set => nota = value; }
        public Alumno Alumno { get => alumno; set => alumno = value; }
        public ProductoAcademico ProductoAcademico { get => productoAcademico; set => productoAcademico=value; }
    }
}
