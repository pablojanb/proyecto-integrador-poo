using clubdeportivo.model;
using clubdeportivo.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.service
{
    internal class IngresoService
    {
        private IngresoRepository repository;
        public Ingreso registrarIngreso(Persona persona, DateTime ingresoHorario)
        {
            Ingreso ingreso = new Ingreso(persona, ingresoHorario);
            return repository.guardarIngreso(ingreso);
        }

        public Ingreso registrarEgreso(Persona persona, DateTime egresoHorario)
        {
            Ingreso ingreso = repository.obtenerUltimoIngresoPorPersonaId(persona.Id);
            ingreso.EgresoHorario = egresoHorario;
            return repository.actualziarIngreso(ingreso);
        }
    }
}
