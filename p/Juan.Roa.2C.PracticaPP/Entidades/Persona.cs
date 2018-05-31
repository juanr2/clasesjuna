using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        public string Apellido
        {
            get { return this.apellido; }
        }

        public string Documento
        {
            get { return this.documento; }

            set
            {
                if (ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }

        }
        public string Nombre
        {
            get { return this.nombre; }
        }

        protected abstract bool ValidarDocumentacion(string doc);
        

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nApellido: ");
            sb.Append(apellido);
            sb.Append("\nDocumento: ");
            sb.Append(documento);
            sb.Append("\nNombre: ");
            sb.AppendLine(nombre);

            return sb.ToString();
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }


    }
}
