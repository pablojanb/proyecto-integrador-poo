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
            var server = Configuration.GetConnectionString("server");
            var port = Configuration.GetConnectionString("port");
            var database = Configuration.GetConnectionString("database");
            var user = Configuration.GetConnectionString("user");
            var password =  Configuration.GetConnectionString("password");
            var connectionString = $"Server={server};Port={port};Database={database};User Id={user};Password={password};";
            return new MySqlConnection(connectionString);
        }

        public static string DBName
        {
            get
            {
                string connectionString = Configuration.GetConnectionString("database")
                    ?? throw new Exception("No se encontró ConnectionStrings:database.");

                return connectionString;
            }
        }
    }
}

