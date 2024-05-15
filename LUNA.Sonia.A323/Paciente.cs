using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUNA.Sonia.A323_
{
    public class Paciente : Persona
    {
        public string diagnostico;

        public string Diagnostico
        {
            get
            {
                return this.diagnostico;
            }
            set
            { 
                this.diagnostico = value; 
            }
        }
        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia) 
            : base(nombre, apellido, nacimiento, barrioRecidencia)
        {
            
        }

        /// <summary>
        /// Muestra ficha con de Recidencia y Diagnostico
        /// </summary>
        /// <returns></returns>
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Recide en: {this.barrioRecidencia}");
            sb.AppendLine($"{this.Diagnostico}");

            return sb.ToString();
        }
    }
}
