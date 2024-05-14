using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial1Dispositivo
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        /// <summary>
        /// Retorna el tamaño de la app
        /// </summary>
        protected override int Tamanio
        {
            get //Por cada canción cargada, su tamaño crecerá en 2mb más. 
            {
                return tamanioMb + listaCanciones.Count *2;
            }
        }


        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial) 
            : this(nombre, sistemaOperativo, tamanioInicial, new List<string>())
            // uso this para reutilizar lo del otro constructor
            // y genera lista con instancia
        {
        
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones)
            : base(nombre, sistemaOperativo, tamanioInicial)
        {
            if (listaCanciones != null)
            {
                //si no es NULL lo asigno al atributo
                this.listaCanciones = listaCanciones;
            }
            else
            {
                this.listaCanciones = new List<string>();
            }
        }

        /// <summary>
        /// Muestra TAMBIEN(override) la lista de canciones
        /// </summary>
        /// <returns></returns>
        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());
            sb.AppendLine($"{Environment.NewLine} Lista de canciones: ");

            foreach (string cancion in listaCanciones)
            {
                sb.AppendLine(cancion);
            }

            return sb.ToString();
        }

    }
}
