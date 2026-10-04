using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.model
{
    internal class Membresia
    {
        private long id;
        private Persona persona;
        private decimal monto;
        private DateOnly periodo;
        private DateOnly fechaVencimiento;

        public long Id { get => id; set => id = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public DateOnly Periodo { get => periodo; set => periodo = value; }
        public DateOnly FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        internal Persona Persona { get => persona; set => persona = value; }
    }
}
