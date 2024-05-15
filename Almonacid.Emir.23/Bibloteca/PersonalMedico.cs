using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bibloteca
{
    public  class PersonalMedico: Persona
    {
        private List<Consulta> consultas = new List<Consulta>();
        private bool esResidente;


        public PersonalMedico(string apellido, string nombre, DateTime nacimiento, bool esResidente)
            : base(apellido, nombre, nacimiento)
        {
            this.esResidente = esResidente;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("ATENCIONES: ");
            if (consultas != null)
            {
                foreach (Consulta consulta in consultas)
                {
                    sb.AppendLine(consulta.ToString());
                }
            }

            return sb.ToString();

        }

        public static PersonalMedico operator +(PersonalMedico doctor, Paciente paciente)
        {
            doctor.consultas.Add(new Consulta(DateTime.Now, paciente));
            return doctor;
        }

    }
}
