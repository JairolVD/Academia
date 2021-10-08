using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ModuloInscripcion.Servicios
{
    public class Alumno
    {
        private int idAlumno;
        private String nombre;
        private String apellido;
        private int dni;
        private int celular;
        private String correo;

        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Celular { get => celular; set => celular = value; }
        public String Correo { get => correo; set => correo = value; }

    }
}
