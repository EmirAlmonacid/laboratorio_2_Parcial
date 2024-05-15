using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
     public  class Paciente: Persona
    {
        public string diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
            : base(apellido, barrioRecidencia, nacimiento, nombre)
        {

        }



        public string Diagnostico
        {
            get { return diagnostico;}
            set { diagnostico = value; }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Recide en: {barrioRecidencia}");
            sb.AppendLine(diagnostico);
            return sb.ToString();
        }
        internal override string FichaExtra()
        {
            
            return string.Empty;
        }
    }
}
