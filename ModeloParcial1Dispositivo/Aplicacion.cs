using System;
using System.Text;

namespace ModeloParcial1Dispositivo
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo
        { 
            get 
            {  
                return sistemaOperativo; 
            } 
        }

        protected abstract int Tamanio { get; }

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }


        /// <summary>
        /// Recibe una lista de aplicaciones 
        /// y devuelve la instancia de la aplicación que más tamaño tenga.
        /// </summary>
        /// <param name="listaApp"></param>
        public static implicit operator Aplicacion(List<Aplicacion> listaApp) 
        {
            Aplicacion aplicacionMasPesada = null;

            foreach (Aplicacion aplicacion in listaApp) 
            {
                /// comprueba registro de tamaño y deja/reemplaza 
                /// la más pesada hasta la ultima iteracion
                if (aplicacionMasPesada is null || aplicacion.Tamanio > aplicacionMasPesada.Tamanio)
                {
                    aplicacionMasPesada = aplicacion;
                }
            }

            return aplicacionMasPesada;
        }

        /// <summary>
        /// Retorna los datos de la aplicación
        /// </summary>
        /// <returns></returns>
        public virtual string ObtenerInformacionApp() 
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {nombre}{Environment.NewLine}");
            stringBuilder.AppendLine($"Sietema Operativo: {SistemaOperativo}{Environment.NewLine}");
            stringBuilder.AppendLine($"Tamaño Ocupado: {Tamanio}{Environment.NewLine}");

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Retorna TRUE si una aplicación existe en la lista recibida por parámetro comparando por su nombre.
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator == (List<Aplicacion> listaApp, Aplicacion app)
        {
            foreach (Aplicacion aplicacion in listaApp)
            {
                if (aplicacion.nombre == app.nombre)
                {
                    return true;
                }

            }

            return false;
        }

        /// Reutiliza lo del operador ==
        public static bool operator != (List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }


        /// <summary>
        /// Añade una aplicación a la lista de aplicaciones 
        /// pasada por parámetro siempre y cuando sea no exista previamente
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator + (List<Aplicacion> listaApp, Aplicacion app)
        {
            if (listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }

            return false;
        }



        /// <summary>
        /// Devuelve el nombre de la aplicación
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return nombre;
        }

    }
}