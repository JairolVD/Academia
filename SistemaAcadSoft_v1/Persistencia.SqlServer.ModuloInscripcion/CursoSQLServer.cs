using System;
using System.Data.SqlClient;
using Dominio.ModuloInscripcion.Entidades;
using Persistencia.SqlServer.ModuloBase;

namespace Persistencia.SqlServer.ModuloInscripcion
{
    class CursoSQLServer
    {
        private AccesoSQLServer gestorSQL;

        public CursoSQLServer(AccesoSQLServer accesoSQL)
        {
            this.gestorSQL = gestorSQL;
        }
        public BuscarPorId(String id)
        {
            Curso curso;
            String consultaSQL = "select * from Clase where ID_CURSO'" + id + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    curso = ObtenerCuro(resultadoSQL);
                }
                else
                {
                    throw new Exception("No exite curso.");
                }
            }
            catch(Exception err)
            {
                throw err;
            }
            return curso;
        }
        private Curso ObtenerCurso(SqlDataReader resultadoSQL)
        {
            Curso curso = new Curso();
            curso.IdCurso = resultadoSQL.GetString(0);
            curso.Nombre = resultadoSQL.GetString(1);
        }
    }
}
