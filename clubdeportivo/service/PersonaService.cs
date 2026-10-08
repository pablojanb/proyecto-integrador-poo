using clubdeportivo.model;
using clubdeportivo.repository;

namespace clubdeportivo.service
{
    internal class PersonaService
    {

        private PersonaRepository repository;

        public PersonaService()
        {
            repository = new PersonaRepository();
        }
        public Persona obtenerPersonaPorDni(string dniSocio)
        {
            return repository.obtenerPersonaPorDni(dniSocio);
        }

        public Persona obtenerPersonaPorNroSocio(long nroSocio)
        {
            return repository.obtenerPersonaPorNroSocio(nroSocio);
        }

        public Persona obtenerPersonaPorNroLegajo(long nroLegajo)
        {
            return repository.obtenerPersonaPorNroLegajo(nroLegajo);
        }

        public Persona crearPersona(Persona persona)
        {
            return repository.crearPersona(persona);
        }
    }
}
