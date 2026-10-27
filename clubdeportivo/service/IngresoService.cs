
using clubdeportivo.model;
using clubdeportivo.repository;
using System.Diagnostics;

namespace clubdeportivo.service
{
    internal class IngresoService
    {
        private IngresoRepository repository;
        private PersonaRepository personaRepository;

        public IngresoService()
        {
            repository = new IngresoRepository();
            personaRepository = new PersonaRepository();
        }
        public Ingreso crearNuevoIngreso(Persona persona, DateTime fechaHora)
        {
            Ingreso ingreso = new Ingreso(persona, fechaHora);
            return repository.crearNuevoIngreso(ingreso);
        }

        internal Ingreso actualizarIngresoPor(Ingreso ingreso)
        {
            return repository.actualizarIngresoPor(ingreso);
        }

        internal Ingreso obtenerUltimoIngresoPorPersonaId(long id)
        {
            Persona persona = personaRepository.obtenerPersonaPorId(id);
            Ingreso ingreso = repository.obtenerUltimoIngresoPorPersonaId(id);
            if (ingreso != null)
            {
                ingreso.Persona = persona;
                return ingreso;
            }
            else
            {
                return null;
            }
        }
    }
}
