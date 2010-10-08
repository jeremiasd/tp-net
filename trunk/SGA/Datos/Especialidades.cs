using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Academia.Datos
{
    public class Especialidades
    {
        SqlConnection conn = Academia.Datos.General.getConexion();

        #region Metodos

        public Academia.Entidades.Colecciones.Especialidades getAll()
        {
            //Creo la lista en la que le voy a ir agregando los usuarios
            Academia.Entidades.Colecciones.Especialidades listaEspecialidades = new Academia.Entidades.Colecciones.Especialidades();
            try
            {
                //Creo el comando para ejecutar la sentencia SQL, le asocio la Conexión también
                SqlCommand cmdGetEspecialidades = new SqlCommand();
                cmdGetEspecialidades.Connection = conn;
                cmdGetEspecialidades.CommandType = CommandType.StoredProcedure;
                cmdGetEspecialidades.CommandText = "EspecialidadesGetAll";

                //Abro la conexión
                this.conn.Open();

                //Ejecuto la consulta, me devuelve un objeto SqlDataReader
                SqlDataReader rdrEspecialidades = cmdGetEspecialidades.ExecuteReader();

                //Recorro el SqlDataReader, transformo el registro a objeto y 
                //agrego ese objeto a la lista de usuarios
                while (rdrEspecialidades.Read())
                {
                    Academia.Entidades.Especialidad oEspecialidad = new Academia.Entidades.Especialidad();
                    oEspecialidad.Id_especialidad = Convert.ToInt32(rdrEspecialidades["id_especialidad"]);
                    oEspecialidad.Desc_especialidad = Convert.ToString(rdrEspecialidades["desc_especialidad"]);

                    listaEspecialidades.Add(oEspecialidad);
                    oEspecialidad = null;
                }

                //Cierro la conexión
                this.conn.Close();

                //Devuelvo la Lista de Usuarios
                return listaEspecialidades;
            }
            finally
            {
                listaEspecialidades = null;
            }
        }

        public Academia.Entidades.Colecciones.Especialidades getOne(int id_especialidad)
        {
            Academia.Entidades.Colecciones.Especialidades oEspecialidades = new Academia.Entidades.Colecciones.Especialidades();
            try
            {
                SqlCommand cmdGetEspecialidad = new SqlCommand();
                cmdGetEspecialidad.Connection = conn;
                cmdGetEspecialidad.CommandType = CommandType.StoredProcedure;
                cmdGetEspecialidad.CommandText = "EspecialidadesGetOne";
                this.conn.Open();
                cmdGetEspecialidad.Parameters.AddWithValue("@id_especialidad", id_especialidad);
                SqlDataReader rdrEspecialidades = cmdGetEspecialidad.ExecuteReader();


                while (rdrEspecialidades.Read())
                {
                    Academia.Entidades.Especialidad oEspecialidad = new Academia.Entidades.Especialidad();
                    oEspecialidad.Id_especialidad = Convert.ToInt32(rdrEspecialidades["id_especialidad"]);
                    oEspecialidad.Desc_especialidad = Convert.ToString(rdrEspecialidades["desc_especialidad"]);

                    oEspecialidades.Add(oEspecialidad);
                    oEspecialidad = null;
                }
                this.conn.Close();
                return oEspecialidades;
            }
            finally
            {
                oEspecialidades = null;
            }
        }

        public int add(Entidades.Especialidad esp)
        {
            Academia.Entidades.Especialidad oEspecialidad = new Academia.Entidades.Especialidad();
            this.conn.Open();
            SqlCommand cmdGetEspecialidades = new SqlCommand();
            cmdGetEspecialidades.Connection = conn;
            cmdGetEspecialidades.CommandType = CommandType.StoredProcedure;
            cmdGetEspecialidades.CommandText = "EspecialidadesAdd";

            //cmdGetEspecialidades.Parameters.AddWithValue("@id_especialidad", esp.Id_especialidad);
            cmdGetEspecialidades.Parameters.AddWithValue("@desc_especialidad", esp.Desc_especialidad);

            esp.Id_especialidad = Convert.ToInt32(cmdGetEspecialidades.ExecuteScalar());
            this.conn.Close();
            return esp.Id_especialidad;
        }

        public void Delete(int id_especialidad)
        {
            try
            {
                this.conn.Open();
                SqlCommand cmdGetEspecialidades = new SqlCommand();
                cmdGetEspecialidades.Connection = conn;
                cmdGetEspecialidades.CommandType = CommandType.StoredProcedure;
                cmdGetEspecialidades.CommandText = "EspecialidadesDelete";
                cmdGetEspecialidades.Parameters.AddWithValue("@id_especialidad", id_especialidad);
                cmdGetEspecialidades.ExecuteNonQuery();
                this.conn.Close();
            }
            catch (SqlException)
            {

            }
        }

        #endregion
    }
}
