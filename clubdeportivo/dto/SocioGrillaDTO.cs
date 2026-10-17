
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

        decimal montoTotal;

        decimal diferenciaTotalYPagos;

        DateOnly fechaVencimiento;
        public SocioGrillaDTO()
        {

        }

        public SocioGrillaDTO(long id, long numAfiliado, string nombreCompleto, string dni, 
            DateOnly fechaAlta, DateOnly? fechaBaja, string telefono, Boolean apto, decimal montoTotal, 
            decimal diferenciaTotalYPagos, DateOnly fechaVencimiento)
        {
            Id = id;
            NumAfiliado = numAfiliado;
            NombreCompleto = nombreCompleto;
            Dni = dni;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            Telefono = telefono;
            AptoFisico = apto;
            MontoTotal = montoTotal;
            DiferenciaTotalYPagos = diferenciaTotalYPagos;
            FechaVencimiento = fechaVencimiento;
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
        [DisplayName("Total")]
        public decimal MontoTotal { get => montoTotal; set => montoTotal = value; }
        [DisplayName("Faltante")]
        public decimal DiferenciaTotalYPagos { get => diferenciaTotalYPagos; set => diferenciaTotalYPagos = value; }
        [DisplayName("Vencimiento")]
        public DateOnly FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
    }
}