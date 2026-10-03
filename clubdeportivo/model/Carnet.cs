using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.model
{
    internal class Carnet
    {
        private long id;
        private Persona persona;
        private DateOnly fechaEntrega;
        private Boolean activo;

        public long Id { get => id; set => id = value; }
        public DateOnly FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public bool Activo { get => activo; set => activo = value; }
        internal Persona Persona { get => persona; set => persona = value; }
    }
}
