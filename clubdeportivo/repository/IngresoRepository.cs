
using clubdeportivo.config;
using clubdeportivo.model;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace clubdeportivo.repository
{
    internal class IngresoRepository
    {
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
            throw new NotImplementedException();
        }
    }
}
