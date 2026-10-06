using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.config
{
    internal class DBConection
    {

        private static DBConection? con = null;
        private static readonly IConfiguration Configuration;

        private DBConection()
        {

        }
        static DBConection()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string ConnectionString =>
            Configuration.GetConnectionString("MySql")
            ?? throw new Exception("No se encontró la conexión MySql.");

     
        public MySqlConnection CrearConcexion()
        {
     
            MySqlConnection? conection = new MySqlConnection();
         
            try
            {
                conection.ConnectionString = ConnectionString; ;
            }
            catch (Exception ex)
            {
                conection.Dispose();
                throw;
            }
            return conection;
        }
   
        public static DBConection getInstancia()
        {
            if (con == null)
            {
                con = new DBConection();
            }
            return con;
        }
    }
}
/*
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

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
            string connectionString =
                Configuration.GetConnectionString("MySql")
                ?? throw new Exception("No se encontró la conexión MySql.");

            return new MySqlConnection(connectionString);
        }
    }
}

*/