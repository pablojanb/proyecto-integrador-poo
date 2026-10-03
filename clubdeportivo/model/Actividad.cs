using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.model
{
    internal class Actividad
    {
        private long id;
        private string descripcion;
        private decimal precio;

        public long Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
