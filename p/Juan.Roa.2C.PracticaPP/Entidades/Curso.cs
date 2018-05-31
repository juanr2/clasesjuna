using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision
        {
            get { return string.Format("{0}º{1}", anio, division); }
        }

        private Curso()
        {
            alumnos= new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor)
            :this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            if (ReferenceEquals(c, null)) return string.Empty;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Detalle del curso: ");
            sb.Append("\nAnio: ");
            sb.Append(c.anio.ToString());
            sb.Append("\nDivision: ");
            sb.Append(c.division);
            sb.AppendLine(string.Empty);
            sb.Append("\nProfesor: ");
            sb.Append(c.profesor.ExponerDatos());

            sb.AppendLine("\n\nAlumnos:\n ");

            if (c.alumnos.Count == 0)
            {
                sb.Append("\nNo se han cargado alumnos");
            }
            else
            {
                foreach (var alumno in c.alumnos)
                {
                    sb.AppendLine(alumno.ExponerDatos());
                }    
            }                                   

            return sb.ToString();
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return ReferenceEquals(c, null) || c.alumnos.IndexOf(a) == -1;
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            return !ReferenceEquals(c, null) && c.alumnos.IndexOf(a) >= 0;
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a) return c;

            c.alumnos.Add(a);

            return c;
        }
    }
}
