using MySql.Data.MySqlClient;

namespace clubdeportivo.config
{
    internal class InicializarDatos
    {
        public static void InicializarDB()
        {
            string ruta = Path.Combine(
                AppContext.BaseDirectory,
                "Scripts",
                "inicializacion.sql"
            );

            string script = File.ReadAllText(ruta);

            using MySqlConnection conexion = DBConection.CrearConexion();
            using MySqlCommand comando = new MySqlCommand(script, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
        }
    }
}
