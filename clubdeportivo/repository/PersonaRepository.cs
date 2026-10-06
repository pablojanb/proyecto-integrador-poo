using clubdeportivo.config;
using clubdeportivo.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

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
                dbConnection = DBConection.getInstancia().CrearConcexion();
                var query = "SELECT id, nombre, apellido, dni, direccion, telefono, email " +
                    "FROM personas p " +
                    "WHERE p.dni = @dni";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@dni", dniSocio);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    if (respuesta.Read())
                    {
                        var id = respuesta.GetInt64("id");
                        var nombre = respuesta.GetString("nombre");
                        var apellido = respuesta.GetString("apellido");
                        var dni = respuesta.GetString("dni");
                        var direccion = respuesta.GetString("direccion");
                        var telefono = respuesta.GetString("telefono");
                        var email = respuesta.GetString("email");
                        persona.Id = id;
                        persona.Nombre = nombre;
                        persona.Apellido = apellido;
                        persona.Dni = dni;
                        persona.Direccion = direccion;
                        persona.Telefono = telefono;
                        persona.Email = email;
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

        public Persona obtenerPersonaPorNroSocio(long nroSocio)
        {
            Persona persona = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.getInstancia().CrearConcexion();
                var query = "SELECT p.id, nombre, apellido, dni, direccion, telefono, email " +
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
                        var id = respuesta.GetInt64("id");
                        var nombre = respuesta.GetString("nombre");
                        var apellido = respuesta.GetString("apellido");
                        var dni = respuesta.GetString("dni");
                        var direccion = respuesta.GetString("direccion");
                        var telefono = respuesta.GetString("telefono");
                        var email = respuesta.GetString("email");
                        persona.Id = id;
                        persona.Nombre = nombre;
                        persona.Apellido = apellido;
                        persona.Dni = dni;
                        persona.Direccion = direccion;
                        persona.Telefono = telefono;
                        persona.Email = email;
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
        public Persona obtenerPersonaPorNroLegajo(long nroLegajo)
        {
            Persona persona = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.getInstancia().CrearConcexion();
                var query = "SELECT p.id, nombre, apellido, dni, direccion, telefono, email " +
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
                        var id = respuesta.GetInt64("id");
                        var nombre = respuesta.GetString("nombre");
                        var apellido = respuesta.GetString("apellido");
                        var dni = respuesta.GetString("dni");
                        var direccion = respuesta.GetString("direccion");
                        var telefono = respuesta.GetString("telefono");
                        var email = respuesta.GetString("email");
                        persona.Id = id;
                        persona.Nombre = nombre;
                        persona.Apellido = apellido;
                        persona.Dni = dni;
                        persona.Direccion = direccion;
                        persona.Telefono = telefono;
                        persona.Email = email;
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