using Taller1Codigo.Cuentas;
using System.Text.RegularExpressions;

namespace Taller1Codigo
{
    public class FabricaNotificacion
    {
        /*
        Clase encargada de creaer las clases que se derivan de INotificacion
        desacoplando asi de la responsabilidad al cliente de la libreria.
        */
        
        private static INotificacion notificacion { get; set; }
        private static string parametro { get; set; }
        public FabricaNotificacion(string cuenta)
        {
            parametro = cuenta;
        }

        public INotificacion MetodoFabrica()
        {
            /*
            Metodo utilizado para instanciar cada una de las clase notificacion
            de acuerdo a caracteres claves dentro del parametro que se pase desde el cliente
            */

            notificacion = null;

            if (parametro.Contains("@"))
            {
                notificacion = new NotificacionCorreo(parametro);
            }
            else if (parametro.ToLower().Contains("facebook"))
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
            /*
            Metodo privado que se utiliza para determinart si dentro de la cadena 
            que se pasa como parametro se encuentran numeros
            */
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
