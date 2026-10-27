
using clubdeportivo.config;
using clubdeportivo.model;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;
using System.Diagnostics;

namespace clubdeportivo.repository
{
    internal class IngresoRepository
    {
        internal Ingreso actualizarIngresoPor(Ingreso ingreso)
        {
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var idIngreso = ingreso.Id;
                var query = "UPDATE ingresos i " +
                            "SET id_persona = @id_persona, ingresoHorario = @ingresoHorario, egresoHorario = @egresoHorario " +
                            "WHERE i.id = @id; ";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);

                comando.Parameters.AddWithValue("@id", ingreso.Id);
                comando.Parameters.AddWithValue("@id_persona", ingreso.Persona.Id);
                comando.Parameters.AddWithValue("@ingresoHorario", ingreso.IngresoHorario);
                comando.Parameters.AddWithValue("@egresoHorario", ingreso.EgresoHorario);

                dbConnection.Open();

                comando.ExecuteNonQuery();

                return ingreso;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error {ex.Number}: {ex.Message}");
                throw;
            }
            finally
            {
                if (dbConnection != null && dbConnection.State == ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }

        internal Ingreso crearNuevoIngreso(Ingreso ingreso)
        {
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();

                var query = "INSERT INTO ingresos (id_persona, ingresoHorario) VALUES " +
                            "(@id_persona, @ingresoHorario);";

                MySqlCommand comando = new MySqlCommand(query, dbConnection);

        

                comando.Parameters.AddWithValue("@id_persona", ingreso.Persona.Id);
                comando.Parameters.AddWithValue("@ingresoHorario", ingreso.IngresoHorario);

                dbConnection.Open();

                comando.ExecuteNonQuery();

                return ingreso;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error {ex.Number}: {ex.Message}");
                throw;
            }
            finally
            {
                if (dbConnection != null && dbConnection.State == ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }

        internal Ingreso obtenerUltimoIngresoPorPersonaId(long id)
        {
            Ingreso ingreso = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "SELECT id, ingresoHorario, egresoHorario " +
                            "FROM ingresos i " +
                            "WHERE i.id_persona = @id " +
                            "ORDER BY i.id DESC " +
                            "LIMIT 1";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@id", id);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    if (respuesta.Read())
                    {
                        ingreso.IngresoHorario = respuesta.GetDateTime("ingresoHorario"); ;
                        if (!respuesta.IsDBNull(respuesta.GetOrdinal("egresoHorario")))
                        {
                            ingreso.EgresoHorario = respuesta.GetDateTime("egresoHorario");
                        }
                        ingreso.Id = respuesta.GetInt64("id"); ;
                        return ingreso;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error {ex.Number}: {ex.Message}");
                throw;
            }
            finally
            {
                if (dbConnection != null && dbConnection.State == ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
        }
    }
}
