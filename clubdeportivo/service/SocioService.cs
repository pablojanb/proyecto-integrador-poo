using clubdeportivo.dto;
using clubdeportivo.model;
using clubdeportivo.repository;
using System.Diagnostics;

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

        public Socio obtenerSocioPorDni(string dni)
        {
            return repository.obtenerSocioPorDni(dni);
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

        public List<SocioGrillaDTO> obtenerTodosConVencimientoDiaActual()
        {
            return repository.obtenerTodosConVencimientoDiaActual();
        }

        public Boolean tieneUltimaMembresiaVencida(string dni)
        {
            return repository.tieneUltimaMembresiaVencida(dni);
        }

        public Boolean pagarMembresia(Socio socio, string medioPago, decimal monto)
        {
            var montoAdeudado = this.calcularDeudaSocio(socio.Id);
            if (montoAdeudado >= monto)
            {
                return repository.pagarMembresia(socio.Id, monto);
            }
            return false;
        }
        private decimal calcularDeudaSocio(long socioId)
        {
            return repository.calcularDeudaSocio(socioId);
        }
    }
}
