using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ModuloInscripcion.Servicios
{
    public class Clase
    {
        private String idClase;
        private DateTime fechaInicioInscripcion;
        private DateTime fechaFinInscripcion;
        private Curso curso;
        private ProductoAcademico productoAcademico;
        private Profesor profesor;
        private Horario horario;
        
        public String IdClase { get => idClase; set => idClase = value; }
        public DateTime FechaInicioInscripcion { get => fechaFinInscripcion; set => fechaFinInscripcion = value; }
        public DateTime FechaFinInscripcion { get => fechaFinInscripcion; set => fechaFinInscripcion = value; }
        public Curso Curso { get => curso; set => curso = value; }
        public ProductoAcademico ProductoAcademico { get => productoAcademico; set => productoAcademico = value; }
        public Profesor Profesor { get => profesor; set => profesor = value; }
        public Horario Horario { get => horario; set => horario = value; }
    }
}
