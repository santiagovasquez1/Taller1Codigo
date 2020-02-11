using Taller1Codigo.Cuentas;
using System.Text.RegularExpressions;

namespace Taller1Codigo
{
    public class FabricaNotificacion
    {
        private static INotificacion notificacion { get; set; }
        private static string parametro { get; set; }
        public FabricaNotificacion(string cuenta)
        {
            parametro = cuenta;
        }

        public INotificacion MetodoFabrica()
        {
            notificacion = null;

        public static INotificacion MetodoFabrica ( string parametro )
        {
            if ( parametro.Contains("@") )
            {
                notificacion = new NotificacionCorreo(parametro);
            }
            else if ( parametro.Contains("www") )
            {
                notificacion = new NotificacionFacebook(parametro);
            }
            else
            {
                string expresion = "[0-9]";
                string numerotl = MatchesExp(parametro, expresion);
                if (numerotl.Length >= 10)
                    notificacion = new NotificacionSMS(parametro);

            }
            return notificacion;
        }

        private static string MatchesExp(string texto, string exp)
        {
            var encontrado = Regex.Matches(texto, exp);
            string temp = "";

            foreach (var e in encontrado)
            {
                temp += e;
            }
            return temp;
        }
    }
}
