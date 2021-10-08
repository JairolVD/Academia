using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ModuloInscripcion.Servicios
{
    public class Profesor
    {
        private int idProfesor;
        private String nombre;
        private String apellido;
        private int dni;
        private String especialidad;
        private int celular;
        private String correo;

        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public String Especialidad { get => especialidad; set => especialidad = value; }
        public int Celular { get => celular; set => celular = value; }
        public String Correo { get => correo; set => correo = value; }
    }
}
