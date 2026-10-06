using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.config
{
    internal class DBConection
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static DBConection? con = null;
        private DBConection()
        {
            this.baseDatos = "proyectopooifts";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "root";
        }
     
        public MySqlConnection CrearConcexion()
        {
     
            MySqlConnection? conection = new MySqlConnection();
         
            try
            {
                conection.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                conection = null;
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

