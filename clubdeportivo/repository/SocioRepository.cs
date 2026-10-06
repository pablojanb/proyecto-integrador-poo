using clubdeportivo.config;
using clubdeportivo.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace clubdeportivo.repository
{
    internal class SocioRepository
    {
        public Socio obtenerSocioPorNroSocio(long nroSocio)
        {
            Socio socio = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "SELECT nombre, apellido, dni, direccion, telefono, email, " +
                    "num_afiliado, fecha_alta, fecha_baja, apto_fisico " +
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
                        var nombre = respuesta.GetString("nombre");
                        var apellido = respuesta.GetString("apellido");
                        var dni = respuesta.GetString("dni");
                        var direccion = respuesta.GetString("direccion");
                        var telefono = respuesta.GetString("telefono");
                        var email = respuesta.GetString("email");
                        var num_afiliado = respuesta.GetInt64("num_afiliado");
                        var apto_fiscio = respuesta.GetBoolean("apto_fisico");
                        socio.Nombre = nombre;
                        socio.Apellido = apellido;
                        socio.Dni = dni;
                        socio.Direccion = direccion;
                        socio.Telefono = telefono;
                        socio.Email = email;
                        socio.NumAfiliado = num_afiliado;
                        socio.AptoFisico = apto_fiscio;
                        return socio;
                    } else
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
