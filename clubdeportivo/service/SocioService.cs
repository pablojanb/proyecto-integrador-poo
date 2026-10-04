using clubdeportivo.model;
using clubdeportivo.repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace clubdeportivo.service
{
    internal class SocioService
    {
        private CarnetService carnetService;
        private SocioRepository repository;

        public SocioService()
        {
            carnetService = new CarnetService();
            repository = new SocioRepository();
        }
        public Socio crearNuevoSocio(string nombre, string apellido, string dni, string direccion, string telefono,
            string email, Boolean aptoFisico)
        {
            Socio nuevoSocio = new Socio(nombre, apellido, dni, direccion, telefono, email, aptoFisico);
            Socio socioGuardado = repository.guardarSocio(nuevoSocio);
            carnetService.emitirCarnet(socioGuardado.Id);
            return socioGuardado;
        }

        public List<Socio> obtenerSociosPorFechaVencimiento(DateOnly fechaVencimiento)
        {
            return repository.obtenerSociosPorFechaVencimiento(fechaVencimiento);
        }

        public List<Socio> retirarCarnet(DateOnly fechaVencimiento)
        {
            return repository.obtenerSociosPorFechaVencimiento(fechaVencimiento);
        }

        public Boolean validarLogin(string username, string password)
        {
            MySqlConnection dbConnection = null;

            try
            {
                dbConnection = DBConection.getInstancia().CrearConcexion();

                MySqlCommand comando = new MySqlCommand("login", dbConnection);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_username", MySqlDbType.VarChar, 50).Value = username;
                comando.Parameters.Add("p_password", MySqlDbType.VarChar, 200).Value = password;

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    return respuesta.Read();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error {ex.Number}: {ex.Message}");
                return false;
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
