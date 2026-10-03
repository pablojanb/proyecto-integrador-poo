using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.model
{
    internal class Socio : Persona
    {
        private string numAfiliado;
        private DateOnly fechaAlta;
        private DateOnly fechaBaja;
        private Boolean aptoFisico;

        public Socio(string nombre, string apellido, string dni, string direccion, string telefono,
            string email, Boolean aptoFisico) : base(nombre, apellido, dni, direccion, telefono, email)
        {
            AptoFisico = aptoFisico;
            fechaAlta = new DateOnly();
        }

        public string NumAfiliado { get => numAfiliado; set => numAfiliado = value; }
        public DateOnly FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateOnly FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }
    }
}
