using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml.Linq;

namespace clubdeportivo.config
{
    internal static class DBConection
    {
        private static readonly IConfiguration Configuration =
            new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

        public static MySqlConnection CrearConexion()
        {
            var connectionString = Configuration.GetConnectionString("mysql");
            return new MySqlConnection(connectionString);
        }
    }
}

