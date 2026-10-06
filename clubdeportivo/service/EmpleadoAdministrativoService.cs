using clubdeportivo.model;
using clubdeportivo.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.service
{
    internal class EmpleadoAdministrativoService
    {
        private EmpleadoAdministrativoRepository repository;

        public EmpleadoAdministrativoService()
        {
            repository = new EmpleadoAdministrativoRepository();
        }

        public EmpleadoAdministrativo obtenerEmpleadoPorUsername(string username)
        {
            return repository.obtenerEmpleadoPorUsername(username);
        }
    }
}
