

using System.Text;

namespace LUNA.Sonia.A323_
{
    public abstract class Persona
    {
        protected string apellido;
        protected string nombre;
        protected string barrioRecidencia;
        protected DateTime nacimiento;


        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }

        public string NombreCompleto
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(string.Format("{0}, {1}", this.apellido, this.nombre));
                return sb.ToString();
            }
        }

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.barrioRecidencia = barrioRecidencia;
        }


        public override string ToString()
        {
            return this.NombreCompleto;
        }

        /// <summary>
        /// Muestra ficha de datos de la persona
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public string FichaPersonal(Persona persona)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.ToString()}");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Barrio de Recidencia: {this.barrioRecidencia}");
            sb.AppendLine($"Fecha de Nacimiento: {this.nacimiento.ToString()}");

            return sb.ToString();
        }

        abstract internal string FichaExtra();

    }
}
