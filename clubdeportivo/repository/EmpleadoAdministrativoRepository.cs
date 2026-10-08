using clubdeportivo.config;
using clubdeportivo.model;
using MySql.Data.MySqlClient;
using System.Data;

namespace clubdeportivo.repository
{
    internal class EmpleadoAdministrativoRepository
    {
        public EmpleadoAdministrativo obtenerEmpleadoPorUsername(string username)
        {
            EmpleadoAdministrativo empleado = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "SELECT num_legajo, username, password " +
                    "FROM empleados_administrativos " +
                    "WHERE username = @username";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@username", username);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    if (respuesta.Read())
                    {
                        var numLegajo = respuesta.GetInt64("num_legajo");
                        var usernameEmpleado = respuesta.GetString("username");
                        var password = respuesta.GetString("password");
                        empleado.NumLegajo = numLegajo;
                        empleado.Username = usernameEmpleado;
                        empleado.Password = password;
                        return empleado;
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
                throw ex;
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
