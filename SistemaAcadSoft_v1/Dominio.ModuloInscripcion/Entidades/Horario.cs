using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ModuloInscripcion.Servicios
{
    public class Horario
    {
        private int idHorario;
        private String dia;
        private String hora;

        public int IdHorario { get => idHorario; set => idHorario = value; }
        public String Dia { get => dia; set => dia = value; }
        public String Hora { get => hora; set => hora = value; }
    }
}
