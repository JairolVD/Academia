using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.ModuloInscripcion.Entidades;
using Persistencia.SqlServer.ModuloBase;

namespace Persistencia.SqlServer.ModuloInscripcion
{
    class ClaseSQLServer
    {
        private AccesoSQLServer gestorSQL;

        public ClaseSQLServer(AccesoSQLServer gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }
        public List<Clase> Buscar(String id)
        {
            List<Clase> clase = new List<Clase>(); ;
            String consultaSQL= "select ID_CLAS,FE_IN_INSC_CLA,FE_FI_INS_CLASE, CAPACIDAD_CLAS from Clase where ID_CLAS'"+id+"'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    clase = ObtenerClase(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe clase.");
                }
            }
            catch(Exception err)
            {
                throw err;
            }
            return clase;
        }

        private Clase ObtenerClase(SqlDataReader resultadoSQL)
        {
            Clase clase = new Clase();
            clase.IdClase = resultadoSQL.GetString(0);
            clase.FechaInicioInscripcion = resultadoSQL.GetDateTime(1);
            clase.FechaFinInscripcion = resultadoSQL.GetDateTime(2);
            clase.Capacidad = resultadoSQL.GetInt32(3);
            return clase;

        }
    }
}
