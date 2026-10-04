using clubdeportivo.model;
using clubdeportivo.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.service
{
    internal class CarnetService
    {
        private CarnetRepository repository;

        public CarnetService()
        {
            repository = new CarnetRepository();
        }

        public Carnet emitirCarnet(long id)
        {
            Carnet carnet = new Carnet(id);
            return repository.guardarCarnet(carnet);
        }

        public Carnet obtenerCarnetPorSocioId(long socioId)
        {
            return repository.obtenerCarnetPorSocioId(socioId);
        }

        public Carnet entregarCarnet(long socioId)
        {
            Carnet carnet = obtenerCarnetPorSocioId(socioId);
            carnet.Activo = true;
            carnet.FechaEntrega = new DateOnly();
            repository.actualizarCarnet(carnet);
            return carnet;
        }
    }
}
