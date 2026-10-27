
using clubdeportivo.model;
using clubdeportivo.repository;

namespace clubdeportivo.service
{
    internal class IngresoService
    {
        private IngresoRepository repository;

        public IngresoService()
        {
            repository = new IngresoRepository();
        }
        public Ingreso crearNuevoIngreso(Persona persona, DateTime fechaHora)
        {
            Ingreso ingreso = new Ingreso(persona, fechaHora);
            return repository.crearNuevoIngreso(ingreso);
        }

        internal Ingreso obtenerUltimoIngresoPorPersonaId(long id)
        {
            return repository.obtenerUltimoIngresoPorPersonaId(id);
        }
    }
}
