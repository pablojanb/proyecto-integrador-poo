
using clubdeportivo.config;
using clubdeportivo.model;
using MySql.Data.MySqlClient;
using System.Data;

namespace clubdeportivo.repository
{
    internal class CarnetRepository
    {
        public Boolean crearCarnet(Carnet carnet)
        {
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();

                var query = "INSERT INTO carnets (id_persona, fecha_emision, activo) VALUES " +
                            "(@id_persona, @fecha_emision, @activo);";

                MySqlCommand comando = new MySqlCommand(query, dbConnection);

                var fechaAlta = carnet.FechaEmision.ToDateTime(TimeOnly.MinValue);

                comando.Parameters.AddWithValue("@id_persona", carnet.PersonaId);
                comando.Parameters.Add("@fecha_emision", MySqlDbType.Date).Value = fechaAlta;
                comando.Parameters.AddWithValue("@activo", carnet.Activo);

                dbConnection.Open();

                comando.ExecuteNonQuery();

                return true;
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

        public Boolean entregarCarnet(long idSocio)
        {
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();

                var query = "UPDATE carnets c SET " +
                            "c.fecha_entrega = CURDATE(), " +
                            "c.activo = TRUE " +
                            "WHERE c.id_persona = @id_persona;";

                MySqlCommand comando = new MySqlCommand(query, dbConnection);

  

                comando.Parameters.AddWithValue("@id_persona", idSocio);


                dbConnection.Open();

                comando.ExecuteNonQuery();

                return true;
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

        public Carnet obtenerCarnetPorSocioId(long socioId)
        {
            Carnet carnet = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "SELECT c.id, id_persona, fecha_emision, fecha_entrega, activo " +
                    "FROM carnets c " +
                    "JOIN socios s ON s.id = c.id_persona " +
                    "WHERE s.id = @socioId";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@socioId", socioId);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    if (respuesta.Read())
                    {
                        carnet.Id = respuesta.GetInt64("id");
                        carnet.PersonaId = respuesta.GetInt64("id_persona");
                        carnet.FechaEmision = DateOnly.FromDateTime(
                             respuesta.GetDateTime("fecha_emision")
                         );
                        carnet.FechaEntrega = DateOnly.FromDateTime(
                            respuesta.GetDateTime("fecha_entrega")
                        );
                        carnet.Activo = respuesta.GetBoolean("activo");
                        return carnet;
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
