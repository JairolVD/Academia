using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ModuloInscripcion.Servicios
{
    public class ProductoAcademico
    {
        private int idProductoAcademico;
        private String nombre;
        private String descripcion;
        private float peso;
        private DateTime fecha;
        
        public int IdProductoAcademico { get => idProductoAcademico; set => idProductoAcademico = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Descripcion { get => descripcion; set => descripcion = value; }
        public float Peso { get => peso;set=> peso = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
