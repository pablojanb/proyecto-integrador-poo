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

        public Persona(string nombre, string apellido, string dni, string direccion, string telefono, 
            string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
