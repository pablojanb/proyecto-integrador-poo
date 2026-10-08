
namespace clubdeportivo.model
{
    internal class Carnet
    {
        private long id;
        private long personaId;
        private DateOnly fechaEmision;
        private DateOnly fechaEntrega;
        private Boolean activo;

        public Carnet(long personaId)
        {
            PersonaId = personaId;
            FechaEmision = new DateOnly();
        }

        public long Id { get => id; set => id = value; }
        public DateOnly FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public bool Activo { get => activo; set => activo = value; }
        public DateOnly FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public long PersonaId { get => personaId; set => personaId = value; }
    }
}
