using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;
        
        public int Antiguedad
        {
            get
            {  
                return (DateTime.Now-fechaIngreso).Days;
            }
        }


        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;

            if (doc.Length >= 0)
            { return true; }

            return retorno;
        }


        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ExponerDatos());
            sb.Append("Fecha de ingreso es: ");
            sb.Append(fechaIngreso.ToString());
         
            return sb.ToString();
        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            :base(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

    }
}
