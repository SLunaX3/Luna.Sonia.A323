using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial1Dispositivo
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        private static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>(); // instancia de lista
            sistemaOperativo = SistemaOperativo.ANDROID; // seteará el sistema operativo de este dispositivo en ANDROID.
        }

        /// <summary>
        /// Recibe por parámetro una aplicación para ser instalada.
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool InstalarApp(Aplicacion app)
        {
            if (app.SistemaOperativo == sistemaOperativo)
            {
                return appsInstaladas + app;
            }
            return false;
        }

        /// <summary>
        /// Muestra toda la información del dispositivo, 
        /// y el detalle de sus aplicaciones instaladas.
        /// </summary>
        /// <returns></returns>
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Sietema Operativo: {sistemaOperativo}{Environment.NewLine}");

            foreach (Aplicacion aplicacion in appsInstaladas)
            {
                stringBuilder.AppendLine(aplicacion.ObtenerInformacionApp());
                // reutiliza el metodo ObtenerInformacionApp()
            }

            return stringBuilder.ToString();
        }
    }
}
