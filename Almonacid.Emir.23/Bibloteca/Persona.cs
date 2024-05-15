using System;
using System.Text;

namespace Bibloteca
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string apellido, string barrioRecidencia, DateTime nacimiento, string nombre)
        {
            this.apellido = apellido;
            this.barrioRecidencia = barrioRecidencia;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }

        public Persona(string apellido, string barrioRecidencia, DateTime nacimiento) { }

        public int Edad
        {
            get { return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year; }
        }

        public string NombreCompleto
        {
            get { return ($"{apellido} {nombre}"); }
        }

        internal abstract string FichaExtra();

        public string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{apellido} {nombre}");
            sb.AppendLine($"EDAD: {Edad}");
            sb.AppendLine($"Barrio de Recidencia {barrioRecidencia}");
            sb.AppendLine($"Nacimiento: {nacimiento}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ($"{apellido} {nombre}");
        }
    }
}
