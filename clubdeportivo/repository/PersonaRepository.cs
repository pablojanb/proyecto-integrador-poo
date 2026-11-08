using clubdeportivo.config;
using clubdeportivo.model;
using MySql.Data.MySqlClient;
using System.Data;

namespace clubdeportivo.repository
{
    internal class PersonaRepository
    {
        public Persona obtenerPersonaPorDni(string dniSocio)
        {
            Persona persona = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "SELECT id, nombre, apellido, dni, direccion, telefono, email, apto_fisico " +
                    "FROM personas p " +
                    "WHERE p.dni = @dni";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@dni", dniSocio);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    if (respuesta.Read())
                    {
                        persona.Id = respuesta.GetInt64("id");
                        persona.Nombre = respuesta.GetString("nombre");
                        persona.Apellido = respuesta.GetString("apellido");
                        persona.Dni = respuesta.GetString("dni");
                        persona.Direccion = respuesta.GetString("direccion");
                        persona.Telefono = respuesta.GetString("telefono");
                        persona.Email = respuesta.GetString("email");
                        persona.AptoFisico = respuesta.GetBoolean("apto_fisico");
                        return persona;
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

        public Persona obtenerPersonaPorNroSocio(long nroSocio)
        {
            Persona persona = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "SELECT p.id, nombre, apellido, dni, direccion, telefono, email, apto_fisico " +
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
                        persona.Id = respuesta.GetInt64("id");
                        persona.Nombre = respuesta.GetString("nombre");
                        persona.Apellido = respuesta.GetString("apellido");
                        persona.Dni = respuesta.GetString("dni");
                        persona.Direccion = respuesta.GetString("direccion");
                        persona.Telefono = respuesta.GetString("telefono");
                        persona.Email = respuesta.GetString("email");
                        persona.AptoFisico = respuesta.GetBoolean("apto_fisico");
                        return persona;
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
        public Persona obtenerPersonaPorNroLegajo(long nroLegajo)
        {
            Persona persona = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "SELECT p.id, nombre, apellido, dni, direccion, telefono, email, apto_fisico " +
                    "FROM personas p " +
                    "JOIN empleados_administrativos ea ON p.id = ea.id " +
                    "WHERE ea.num_legajo = @num_legajo";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@num_legajo", nroLegajo);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    if (respuesta.Read())
                    {
                        persona.Id = respuesta.GetInt64("id");
                        persona.Nombre = respuesta.GetString("nombre");
                        persona.Apellido = respuesta.GetString("apellido");
                        persona.Dni = respuesta.GetString("dni");
                        persona.Direccion = respuesta.GetString("direccion");
                        persona.Telefono = respuesta.GetString("telefono");
                        persona.Email = respuesta.GetString("email");
                        persona.AptoFisico = respuesta.GetBoolean("apto_fisico");
                        return persona;
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

        public Persona crearPersona(Persona persona)
        {
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "INSERT INTO personas (nombre, apellido, dni, direccion, telefono, email, apto_fisico) VALUES " +
                    "(@nombre, @apellido, @dni, @direccion, @telefono, @email, @apto_fisico); " +

                    "SELECT * " +
                    "FROM personas " +
                    "WHERE id = LAST_INSERT_ID();";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@nombre", persona.Nombre);
                comando.Parameters.AddWithValue("@apellido", persona.Apellido);
                comando.Parameters.AddWithValue("@dni", persona.Dni);
                comando.Parameters.AddWithValue("@direccion", persona.Direccion);
                comando.Parameters.AddWithValue("@telefono", persona.Telefono);
                comando.Parameters.AddWithValue("@email", persona.Email);
                comando.Parameters.AddWithValue("@apto_fisico", persona.AptoFisico);
                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    if (respuesta.Read())
                    {
                        Persona personaGuardada = new Persona
                        {
                            Id = respuesta.GetInt64("id"),
                            Nombre = respuesta.GetString("nombre"),
                            Apellido = respuesta.GetString("apellido"),
                            Dni = respuesta.GetString("dni"),
                            Direccion = respuesta.GetString("direccion"),
                            Telefono = respuesta.GetString("telefono"),
                            Email = respuesta.GetString("email"),
                            AptoFisico = respuesta.GetBoolean("apto_fisico")
                        };

                        return personaGuardada;
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

        internal Persona obtenerPersonaPorId(long idPersona)
        {
            Persona persona = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "SELECT p.id, nombre, apellido, dni, direccion, telefono, email, apto_fisico " +
                    "FROM personas p " +
                    "WHERE p.id = @id";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@id", idPersona);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    if (respuesta.Read())
                    {
                        persona.Id = respuesta.GetInt64("id");
                        persona.Nombre = respuesta.GetString("nombre");
                        persona.Apellido = respuesta.GetString("apellido");
                        persona.Dni = respuesta.GetString("dni");
                        persona.Direccion = respuesta.GetString("direccion");
                        persona.Telefono = respuesta.GetString("telefono");
                        persona.Email = respuesta.GetString("email");
                        persona.AptoFisico = respuesta.GetBoolean("apto_fisico");
                        return persona;
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