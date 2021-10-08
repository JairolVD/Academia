using System;
using System.Data.SqlClient;
using Dominio.ModuloInscripcion.Entidades;
using Persistencia.SqlServer.ModuloBase;


namespace Persistencia.SqlServer.ModuloInscripcion
{
    public class AlumnoSQLServer
    {
        private AccesoSQLServer gestorSQL;

        public AlumnoSQLServer(AccesoSQLServer gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }

        public Alumno BuscarPorId(int id)
        {
            Alumno alumno;
            String consultaSQL="select NOMBRE_AL,APELLIDO_AL,DNI_AL, CORREO_AL,CELULAR_AL from ALUMNO where ID_AL='"+id+"'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    alumno = ObtenerAlumno(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe Alumno.");
                }
            }
            catch(Exception err)
            {
                throw err;
            }
            return alumno;

        }

        private Alumno ObtenerAlumno(SqlDataReader resultadoSQL)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = resultadoSQL.GetString(0);
            alumno.Apellido = resultadoSQL.GetString(1);
            alumno.Dni = resultadoSQL.GetInt32(2);
            alumno.Correo = resultadoSQL.GetString(3);
            alumno.Celular = resultadoSQL.GetString(4);
            return alumno;
        }
    }
}
