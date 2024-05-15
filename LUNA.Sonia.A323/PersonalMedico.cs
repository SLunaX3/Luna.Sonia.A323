using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUNA.Sonia.A323_
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esRecidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente)
            : base(nombre, apellido, nacimiento)
        {
            this.consultas = new List<Consulta>();
            this.esRecidente = esResidente;
        }

        /// <summary>
        /// Muestra ficha de los datos de atencion
        /// </summary>
        /// <returns></returns>
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("¿Finalizo Residencia? {0}",
                            this.esRecidente ? "SI" : "NO"));
            sb.AppendLine($"ATENCIONES: ");
            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine($"{consulta.ToString()}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Agrega nuevas consultas a la lista, 
        /// tomando como fecha de inicio usando método Now
        /// </summary>
        /// <param name="doctor"></param>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public static bool operator + (PersonalMedico doctor, Paciente paciente)
        {
            if (doctor is not null && paciente is not null)
            {
                Consulta consultaAux = new Consulta(DateTime.Now, paciente);
                doctor.consultas.Add(consultaAux);
                return true;
            }
            return false;
        }
    }
}
