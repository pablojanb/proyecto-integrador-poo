
using clubdeportivo.dto;
using clubdeportivo.model;
using clubdeportivo.repository;

namespace clubdeportivo.service
{
    internal class SocioService
    {
        private SocioRepository repository;
        private PersonaService personaService;

        public SocioService()
        {
            repository = new SocioRepository();
            personaService = new PersonaService();
        }

        public Socio obtenerSocioPorNroSocio(long nroSocio)
        {
            return repository.obtenerSocioPorNroSocio(nroSocio);
        }

        public Socio crearSocio(Persona persona)
        {
            Persona personaCreada = personaService.crearPersona(persona);
            Socio socio = new Socio(personaCreada.Id, personaCreada.Nombre, personaCreada.Apellido, 
                personaCreada.Dni, personaCreada.Direccion, personaCreada.Telefono, personaCreada.Email, true);
            return repository.crearSocio(socio);
        }

        public List<SocioGrillaDTO> obtenerTodosConVencimiento()
        {
            return repository.obtenerTodosConVencimiento();
        }
    }
}
