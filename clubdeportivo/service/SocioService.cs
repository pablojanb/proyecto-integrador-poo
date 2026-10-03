using clubdeportivo.model;
using clubdeportivo.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.service
{
    internal class SocioService
    {
        private CarnetService carnetService;
        private SocioRepository repository;
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
    }
}
