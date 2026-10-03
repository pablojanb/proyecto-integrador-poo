using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.model
{
    internal class MedioPago
    {
        private long id;
        private string descripcion;

        public long Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
