using clubdeportivo.config;
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
        private SocioRepository repository;

        public SocioService()
        {
            repository = new SocioRepository();
        }

        public Socio obtenerSocioPorNroSocio(long nroSocio)
        {
            return repository.obtenerSocioPorNroSocio(nroSocio);
        }

    }
}
