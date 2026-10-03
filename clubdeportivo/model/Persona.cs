using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.model
{
    internal class Persona
    {
        private long id;
        private string nombre;
        private string apellido;
        private string dni;
        private string direccion;
        private string telefono;
        private string email;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
