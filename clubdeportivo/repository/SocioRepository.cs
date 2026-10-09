using clubdeportivo.config;
using clubdeportivo.model;
using MySql.Data.MySqlClient;
using System.Data;

namespace clubdeportivo.repository
{
    internal class SocioRepository
    {
        public Socio obtenerSocioPorNroSocio(long nroSocio)
        {
            Socio socio = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "SELECT nombre, apellido, dni, direccion, telefono, email, " +
                    "num_afiliado, fecha_alta, fecha_baja, apto_fisico " +
                    "FROM personas p " +
                    "JOIN socios s ON p.id = s.id " +
                    "WHERE s.num_afiliado = @nroSocio";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@nroSocio", nroSocio);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    if (respuesta.Read())
                    {
                        var nombre = respuesta.GetString("nombre");
                        var apellido = respuesta.GetString("apellido");
                        var dni = respuesta.GetString("dni");
                        var direccion = respuesta.GetString("direccion");
                        var telefono = respuesta.GetString("telefono");
                        var email = respuesta.GetString("email");
                        var num_afiliado = respuesta.GetInt64("num_afiliado");
                        var apto_fiscio = respuesta.GetBoolean("apto_fisico");
                        socio.Nombre = nombre;
                        socio.Apellido = apellido;
                        socio.Dni = dni;
                        socio.Direccion = direccion;
                        socio.Telefono = telefono;
                        socio.Email = email;
                        socio.NumAfiliado = num_afiliado;
                        socio.AptoFisico = apto_fiscio;
                        return socio;
                    } else
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

        public Socio crearSocio(Socio socio)
        {
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();

                var query = "INSERT INTO socios (id, fecha_alta, apto_fisico) VALUES " +
                            "(@id, @fecha_alta, @apto_fisico);";

                MySqlCommand comando = new MySqlCommand(query, dbConnection);

                var fechaAlta = socio.FechaAlta.ToDateTime(TimeOnly.MinValue);

                comando.Parameters.AddWithValue("@id", socio.Id);
                comando.Parameters.Add("@fecha_alta", MySqlDbType.Date).Value = fechaAlta;
                comando.Parameters.AddWithValue("@apto_fisico", socio.AptoFisico);

                dbConnection.Open();

                comando.ExecuteNonQuery();


                socio.NumAfiliado = comando.LastInsertedId;

                return socio;
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

        public List<Socio> obtenerTodos()
        {
            List<Socio> socios = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "SELECT p.id, nombre, apellido, dni, telefono, " +
                    "num_afiliado, fecha_alta, fecha_baja, apto_fisico " +
                    "FROM personas p " +
                    "JOIN socios s ON p.id = s.id";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    while (respuesta.Read())
                    {
                        Socio socio = new Socio();
                        socio.Id = respuesta.GetInt64("id");
                        socio.Nombre = respuesta.GetString("nombre");
                        socio.Apellido = respuesta.GetString("apellido");
                        socio.Dni = respuesta.GetString("dni");
                        socio.Telefono = respuesta.GetString("telefono");
                        socio.NumAfiliado = respuesta.GetInt64("num_afiliado");
                        socio.AptoFisico = respuesta.GetBoolean("apto_fisico");
                        socio.FechaAlta = DateOnly.FromDateTime(respuesta.GetDateTime("fecha_alta"));
                        if (!respuesta.IsDBNull(respuesta.GetOrdinal("fecha_baja")))
                        {
                            socio.FechaBaja = DateOnly.FromDateTime(
                                respuesta.GetDateTime("fecha_baja")
                            );
                        }
                        socios.Add(socio);
                    }
                    return socios;
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
