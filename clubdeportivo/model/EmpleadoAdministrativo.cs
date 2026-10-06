using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.model
{
    internal class EmpleadoAdministrativo
    {
        private long numLegajo;
        private string username;
        private string password;
        private DateOnly fechaAlta;
        private DateOnly fechaBaja;

        public long NumLegajo { get => numLegajo; set => numLegajo = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateOnly FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateOnly FechaBaja { get => fechaBaja; set => fechaBaja = value; }
    }
}
