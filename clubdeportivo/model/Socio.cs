using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.model
{
    internal class Socio
    {
        private string numAfiliado;
        private DateOnly fechaAlta;
        private DateOnly fechaBaja;
        private Boolean aptoFisico;

        public string NumAfiliado { get => numAfiliado; set => numAfiliado = value; }
        public DateOnly FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateOnly FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }
    }
}
