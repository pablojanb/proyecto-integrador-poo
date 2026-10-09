
namespace clubdeportivo.model
{
    internal class Socio : Persona
    {
        private long id;
        private long numAfiliado;
        private DateOnly fechaAlta;
        private DateOnly? fechaBaja;
        private Boolean aptoFisico;

        public Socio() {}
        public Socio(long id, string nombre, string apellido, string dni, string direccion, string telefono,
            string email, Boolean aptoFisico) : base(nombre, apellido, dni, direccion, telefono, email)
        {
            Id = id;
            AptoFisico = aptoFisico;
            FechaAlta = DateOnly.FromDateTime(DateTime.Now);
        }

        public long Id { get => id; set => id = value; }
        public long NumAfiliado { get => numAfiliado; set => numAfiliado = value; }
        public DateOnly FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateOnly? FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }
    }
}
