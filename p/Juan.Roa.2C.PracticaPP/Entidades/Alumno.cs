using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno: Persona
    {
        private short anio;
        private Divisiones division;
        
        public string AnioDivision
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("El año es: ");
                sb.AppendLine(anio.ToString());
                sb.Append("y la division es: ");
                sb.AppendLine(division.ToString());

                return sb.ToString();
            }
        }

         
        protected override bool ValidarDocumentacion(string doc)
        {
            return new Regex(@"^\d{2}-\d{4}-\d{1}$").IsMatch(doc);
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ExponerDatos());
            sb.Append("Año: ");
            sb.Append(anio.ToString());
            sb.Append("\nDivision: ");
            sb.Append(division.ToString());


            return sb.ToString();
        }

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            :base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

    }
}
