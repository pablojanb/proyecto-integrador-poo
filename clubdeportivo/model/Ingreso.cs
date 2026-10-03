using System;
using System.Collections.Generic;
using System.Text;

namespace clubdeportivo.model
{
    internal class Ingreso
    {
        private long id;
        private Persona persona;
        private DateTime ingresoHorario;
        private DateTime egresoHorario;

        public Ingreso(Persona persona, DateTime ingresoHorario)
        {
            Persona = persona;
            IngresoHorario = ingresoHorario;
        }

        public long Id { get => id; set => id = value; }
  
        public DateTime EgresoHorario { get => egresoHorario; set => egresoHorario = value; }
        public DateTime IngresoHorario { get => ingresoHorario; set => ingresoHorario = value; }
        internal Persona Persona { get => persona; set => persona = value; }
    }
}
