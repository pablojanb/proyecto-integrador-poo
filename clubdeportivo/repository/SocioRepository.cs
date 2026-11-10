using clubdeportivo.config;
using clubdeportivo.dto;
using clubdeportivo.model;
using MySql.Data.MySqlClient;
using System.Data;

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
                var query = "SELECT s.id, nombre, apellido, dni, direccion, telefono, email, " +
                    "num_afiliado, fecha_alta, fecha_baja " +
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
                        socio.Id = respuesta.GetInt64("id");
                        socio.Nombre = respuesta.GetString("nombre");
                        socio.Apellido = respuesta.GetString("apellido");
                        socio.Dni = respuesta.GetString("dni");
                        socio.Direccion = respuesta.GetString("direccion");
                        socio.Telefono = respuesta.GetString("telefono");
                        socio.Email = respuesta.GetString("email");
                        socio.NumAfiliado = respuesta.GetInt64("num_afiliado");
                        socio.FechaAlta = DateOnly.FromDateTime(
                            respuesta.GetDateTime("fecha_alta")
                        );
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

        public Socio obtenerSocioPorDni(string dni)
        {
            Socio socio = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "SELECT s.id, nombre, apellido, dni, direccion, telefono, email, " +
                    "num_afiliado, fecha_alta, fecha_baja " +
                    "FROM personas p " +
                    "JOIN socios s ON p.id = s.id " +
                    "WHERE p.dni = @dni";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@dni", dni);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    if (respuesta.Read())
                    {
                        socio.Id = respuesta.GetInt64("id");
                        socio.Nombre = respuesta.GetString("nombre");
                        socio.Apellido = respuesta.GetString("apellido");
                        socio.Dni = respuesta.GetString("dni");
                        socio.Direccion = respuesta.GetString("direccion");
                        socio.Telefono = respuesta.GetString("telefono");
                        socio.Email = respuesta.GetString("email");
                        socio.NumAfiliado = respuesta.GetInt64("num_afiliado");
                        socio.FechaAlta = DateOnly.FromDateTime(
                            respuesta.GetDateTime("fecha_alta")
                        );
                        return socio;
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

        public Socio crearSocio(Socio socio)
        {
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();

                var query = "INSERT INTO socios (id, fecha_alta) VALUES " +
                            "(@id, @fecha_alta);";

                MySqlCommand comando = new MySqlCommand(query, dbConnection);

                var fechaAlta = socio.FechaAlta.ToDateTime(TimeOnly.MinValue);

                comando.Parameters.AddWithValue("@id", socio.Id);
                comando.Parameters.Add("@fecha_alta", MySqlDbType.Date).Value = fechaAlta;

                dbConnection.Open();

                comando.ExecuteNonQuery();


                socio.NumAfiliado = comando.LastInsertedId;

                return socio;
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

        public List<SocioGrillaDTO> obtenerTodosConVencimiento()
        {
            List<SocioGrillaDTO> socios = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "WITH ultima_membresia AS ( " +
                            "SELECT " +
                                "m.*, " +
                                "ROW_NUMBER() OVER( " +
                                    "PARTITION BY m.id_socio " +
                                    "ORDER BY m.periodo DESC, m.id DESC " +
                                ") AS rn " +
                            "FROM membresias m " +
                        "), " +
                        "total_pagos AS ( " +
                            "SELECT " +
                                "p.id_membresia, " +
                                "SUM(p.monto) AS total_pagado " +
                            "FROM pagos p " +
                            "GROUP BY p.id_membresia " +
                        ") " +
                        "SELECT " +
                            "s.id AS id, " +
                            "s.num_afiliado AS numAfiliado, " +

                            "CONCAT_WS(' ', per.nombre, per.apellido) AS nombreCompleto, " +
                            "per.dni AS dni, " +
                            "per.telefono AS telefono, " +

                            "s.fecha_alta AS fechaAlta, " +
                            "s.fecha_baja AS fechaBaja, " +
                            "per.apto_fisico AS aptoFisico, " +

                            "um.monto AS montoTotal, " +
                            "COALESCE(um.descuento, 0) AS descuento, " +
                            "COALESCE(tp.total_pagado, 0) AS totalPagado, " +

                            "(um.monto - COALESCE(um.descuento, 0) - COALESCE(tp.total_pagado, 0)) " +
                                "AS diferenciaTotalYPagos, " +

                            "um.fecha_vencimiento AS fechaVencimiento " +

                        "FROM socios s " +

                        "INNER JOIN personas per " +
                            "ON per.id = s.id " +

                        "INNER JOIN ultima_membresia um " +
                            "ON um.id_socio = s.id " +
                            "AND um.rn = 1 " +

                        "LEFT JOIN total_pagos tp " +
                            "ON tp.id_membresia = um.id " +

                        "WHERE um.fecha_vencimiento <= CURDATE() " +
                        "AND um.deuda_cancelada = FALSE " +

                        "ORDER BY s.num_afiliado;";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    while (respuesta.Read())
                    {
                        SocioGrillaDTO socio = new SocioGrillaDTO();

                        socio.Id = respuesta.GetInt64("Id");
                        socio.NumAfiliado = respuesta.GetInt64("NumAfiliado");

                        socio.NombreCompleto = respuesta.GetString("NombreCompleto");
                        socio.Dni = respuesta.GetString("Dni");
                        socio.Telefono = respuesta.GetString("Telefono");

                        socio.AptoFisico = respuesta.GetBoolean("AptoFisico");

                        socio.FechaAlta = DateOnly.FromDateTime(
                            respuesta.GetDateTime("FechaAlta")
                        );

                        if (!respuesta.IsDBNull(respuesta.GetOrdinal("FechaBaja")))
                        {
                            socio.FechaBaja = DateOnly.FromDateTime(
                                respuesta.GetDateTime("FechaBaja")
                            );
                        }

                        socio.MontoTotal = respuesta.GetDecimal("MontoTotal");
                        socio.DiferenciaTotalYPagos = respuesta.GetDecimal("DiferenciaTotalYPagos");

                        if (!respuesta.IsDBNull(respuesta.GetOrdinal("FechaVencimiento")))
                        {
                            socio.FechaVencimiento = DateOnly.FromDateTime(
                                respuesta.GetDateTime("FechaVencimiento")
                            );
                        }

                        socios.Add(socio);
                    }
                    return socios;
                }
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

        public List<SocioGrillaDTO> obtenerTodosConVencimientoDiaActual()
        {
            List<SocioGrillaDTO> socios = new();
            MySqlConnection dbConnection = null;
            try
            {
                dbConnection = DBConection.CrearConexion();
                var query = "WITH ultima_membresia AS ( " +
                            "SELECT " +
                                "m.*, " +
                                "ROW_NUMBER() OVER( " +
                                    "PARTITION BY m.id_socio " +
                                    "ORDER BY m.periodo DESC, m.id DESC " +
                                ") AS rn " +
                            "FROM membresias m " +
                        "), " +
                        "total_pagos AS ( " +
                            "SELECT " +
                                "p.id_membresia, " +
                                "SUM(p.monto) AS total_pagado " +
                            "FROM pagos p " +
                            "GROUP BY p.id_membresia " +
                        ") " +
                        "SELECT " +
                            "s.id AS id, " +
                            "s.num_afiliado AS numAfiliado, " +

                            "CONCAT_WS(' ', per.nombre, per.apellido) AS nombreCompleto, " +
                            "per.dni AS dni, " +
                            "per.telefono AS telefono, " +

                            "s.fecha_alta AS fechaAlta, " +
                            "s.fecha_baja AS fechaBaja, " +
                            "per.apto_fisico AS aptoFisico, " +

                            "um.monto AS montoTotal, " +
                            "COALESCE(tp.total_pagado, 0) AS totalPagado, " +
                            "COALESCE(um.descuento, 0) AS descuento, " +

                            "(um.monto - COALESCE(um.descuento, 0) - COALESCE(tp.total_pagado, 0)) " +
                                "AS diferenciaTotalYPagos, " +

                            "um.fecha_vencimiento AS fechaVencimiento " +

                        "FROM socios s " +

                        "INNER JOIN personas per " +
                            "ON per.id = s.id " +

                        "INNER JOIN ultima_membresia um " +
                            "ON um.id_socio = s.id " +
                            "AND um.rn = 1 " +

                        "LEFT JOIN total_pagos tp " +
                            "ON tp.id_membresia = um.id " +

                        "WHERE um.fecha_vencimiento = CURDATE() " +
                        "AND um.deuda_cancelada = FALSE " +

                        "ORDER BY s.num_afiliado;";
                MySqlCommand comando = new MySqlCommand(query, dbConnection);

                dbConnection.Open();

                using (MySqlDataReader respuesta = comando.ExecuteReader())
                {
                    while (respuesta.Read())
                    {
                        SocioGrillaDTO socio = new SocioGrillaDTO();

                        socio.Id = respuesta.GetInt64("Id");
                        socio.NumAfiliado = respuesta.GetInt64("NumAfiliado");

                        socio.NombreCompleto = respuesta.GetString("NombreCompleto");
                        socio.Dni = respuesta.GetString("Dni");
                        socio.Telefono = respuesta.GetString("Telefono");

                        socio.AptoFisico = respuesta.GetBoolean("AptoFisico");

                        socio.FechaAlta = DateOnly.FromDateTime(
                            respuesta.GetDateTime("FechaAlta")
                        );

                        if (!respuesta.IsDBNull(respuesta.GetOrdinal("FechaBaja")))
                        {
                            socio.FechaBaja = DateOnly.FromDateTime(
                                respuesta.GetDateTime("FechaBaja")
                            );
                        }

                        socio.MontoTotal = respuesta.GetDecimal("MontoTotal");
                        socio.DiferenciaTotalYPagos = respuesta.GetDecimal("DiferenciaTotalYPagos");

                        if (!respuesta.IsDBNull(respuesta.GetOrdinal("FechaVencimiento")))
                        {
                            socio.FechaVencimiento = DateOnly.FromDateTime(
                                respuesta.GetDateTime("FechaVencimiento")
                            );
                        }

                        socios.Add(socio);
                    }

                    return socios;
                }
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

        public bool tieneUltimaMembresiaVencida(string dni)
        {
            MySqlConnection dbConnection = null;

            try
            {
                dbConnection = DBConection.CrearConexion();

                string query =
                    "WITH ultima_membresia AS ( " +
                        "SELECT " +
                            "m.fecha_vencimiento, " +
                            "m.deuda_cancelada, " +
                            "ROW_NUMBER() OVER ( " +
                                "PARTITION BY m.id_socio " +
                                "ORDER BY m.periodo DESC, m.id DESC " +
                            ") AS rn " +
                        "FROM membresias m " +
                        "INNER JOIN socios s ON s.id = m.id_socio " +
                        "INNER JOIN personas p ON p.id = s.id " +
                        "WHERE p.dni = @dni " +
                    ") " +
                    "SELECT EXISTS ( " +
                        "SELECT 1 " +
                        "FROM ultima_membresia um " +
                        "WHERE um.rn = 1 " +
                        "AND um.fecha_vencimiento <= CURDATE() " +
                        "AND um.deuda_cancelada = FALSE " +
                    ");";

                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@dni", dni);

                dbConnection.Open();

                return Convert.ToBoolean(comando.ExecuteScalar());
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

        public Boolean pagarMembresia(long idSocio, decimal monto, decimal descuento, long medioPagoId)
        {
            MySqlConnection dbConnection = null;

            try
            {
                dbConnection = DBConection.CrearConexion();
                dbConnection.Open();

                using (MySqlTransaction transaccion = dbConnection.BeginTransaction())
                {
                    string queryMembresia =
                        "SELECT id " +
                        "FROM membresias " +
                        "WHERE id_socio = @idSocio " +
                        "ORDER BY periodo DESC, id DESC " +
                        "LIMIT 1;";

                    long idMembresia;

                    using (MySqlCommand comando = new MySqlCommand(queryMembresia, dbConnection, transaccion))
                    {
                        comando.Parameters.AddWithValue("@idSocio", idSocio);

                        object resultado = comando.ExecuteScalar();

                        if (resultado == null)
                        {
                            transaccion.Rollback();
                            return false;
                        }

                        idMembresia = Convert.ToInt64(resultado);
                    }

                    string queryDescuento =
                        "UPDATE membresias " +
                        "SET descuento = COALESCE(descuento, 0) + @descuento " +
                        "WHERE id = @idMembresia;";

                    using (MySqlCommand comando = new MySqlCommand(queryDescuento, dbConnection, transaccion))
                    {
                        comando.Parameters.AddWithValue("@descuento", descuento);
                        comando.Parameters.AddWithValue("@idMembresia", idMembresia);
                        comando.ExecuteNonQuery();
                    }

                    string queryPago =
                        "INSERT INTO pagos (id_membresia, monto, fecha_hora, id_medio_pago) " +
                        "VALUES (@idMembresia, @monto, NOW(), @id_medio_pago);";

                    using (MySqlCommand comando = new MySqlCommand(queryPago, dbConnection, transaccion))
                    {
                        comando.Parameters.AddWithValue("@idMembresia", idMembresia);
                        comando.Parameters.AddWithValue("@monto", monto);
                        comando.Parameters.AddWithValue("@id_medio_pago", medioPagoId);
                        comando.ExecuteNonQuery();
                    }

                    string queryDeuda =
                        "UPDATE membresias m " +
                        "SET m.deuda_cancelada = ( " +
                            "SELECT COALESCE(SUM(p.monto), 0) " +
                            "FROM pagos p " +
                            "WHERE p.id_membresia = m.id " +
                        ") >= (m.monto - COALESCE(m.descuento, 0)) " +
                        "WHERE m.id = @idMembresia;";

                    using (MySqlCommand comando = new MySqlCommand(queryDeuda, dbConnection, transaccion))
                    {
                        comando.Parameters.AddWithValue("@idMembresia", idMembresia);
                        comando.ExecuteNonQuery();
                    }

                    transaccion.Commit();

                    return true;
                }
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

        public decimal calcularDeudaSocio(long idSocio)
        {
            MySqlConnection dbConnection = null;

            try
            {
                dbConnection = DBConection.CrearConexion();

                string query =
                    "WITH ultima_membresia AS ( " +
                        "SELECT " +
                            "m.*, " +
                            "ROW_NUMBER() OVER ( " +
                                "PARTITION BY m.id_socio " +
                                "ORDER BY m.periodo DESC, m.id DESC " +
                            ") AS rn " +
                        "FROM membresias m " +
                        "WHERE m.id_socio = @idSocio " +
                    "), " +
                    "total_pagos AS ( " +
                        "SELECT " +
                            "p.id_membresia, " +
                            "SUM(p.monto) AS total_pagado " +
                        "FROM pagos p " +
                        "INNER JOIN ultima_membresia um " +
                            "ON um.id = p.id_membresia " +
                            "WHERE um.rn = 1 " +
                        "GROUP BY p.id_membresia " +
                    ") " +
                    "SELECT " +
                        "COALESCE( " +
                            "um.monto - COALESCE(tp.total_pagado, 0), " +
                            "0 " +
                        ") AS deuda " +
                    "FROM ultima_membresia um " +
                    "LEFT JOIN total_pagos tp " +
                        "ON tp.id_membresia = um.id " +
                    "WHERE um.rn = 1;";

                MySqlCommand comando = new MySqlCommand(query, dbConnection);
                comando.Parameters.AddWithValue("@idSocio", idSocio);

                dbConnection.Open();

                object resultado = comando.ExecuteScalar();

                return resultado == null || resultado == DBNull.Value
                    ? 0
                    : Convert.ToDecimal(resultado);
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
    }
}
