using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.model
{
    internal class Pago
    {
        private long id;
        private Membresia membresia;
        private DateTime fechaPago;
        private decimal monto;
        private string detalle;
        private MedioPago medioPago;

        public long Id { get => id; set => id = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        internal Membresia Membresia { get => membresia; set => membresia = value; }
        internal MedioPago MedioPago { get => medioPago; set => medioPago = value; }
    }
}
