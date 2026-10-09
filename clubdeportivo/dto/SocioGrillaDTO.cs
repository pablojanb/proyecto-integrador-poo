
using System.ComponentModel;

namespace clubdeportivo.dto
{
    internal class SocioGrillaDTO
    {
        long id;
        long numAfiliado;
        string nombreCompleto;
        string dni;

        DateOnly fechaAlta;

        DateOnly? fechaBaja;
        string telefono;

        Boolean aptoFisico;

        public SocioGrillaDTO(long id, long numAfiliado, string nombreCompleto, string dni, 
            DateOnly fechaAlta, DateOnly? fechaBaja, string telefono, Boolean apto)
        {
            Id = id;
            NumAfiliado = numAfiliado;
            NombreCompleto = nombreCompleto;
            Dni = dni;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            Telefono = telefono;
            AptoFisico = apto;
        }

        [Browsable(false)]
        public long Id { get => id; set => id = value; }

        [DisplayName("N° Afiliado")]
        public long NumAfiliado { get => numAfiliado; set => numAfiliado = value; }
        [DisplayName("Socio")]
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        [DisplayName("DNI")]
        public string Dni { get => dni; set => dni = value; }
        [DisplayName("Fecha alta")]
        public DateOnly FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        [DisplayName("Fecha baja")]
        public DateOnly? FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        [DisplayName("Teléfono")]
        public string Telefono { get => telefono; set => telefono = value; }

        [DisplayName("APTO")]
        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }
    }
}
