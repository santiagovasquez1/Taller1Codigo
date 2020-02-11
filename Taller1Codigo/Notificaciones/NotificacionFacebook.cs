using System;

namespace Taller1Codigo.Cuentas
{
    public class NotificacionFacebook : INotificacion
    {
        public string LinkFacebook { get; set; }

        public NotificacionFacebook ( string link )
        {
            LinkFacebook = link;
        }

        public void enviar ( string mensaje )
        {
            string formato = $"Enviando a {LinkFacebook} : ";
            Console.WriteLine(formato + mensaje);
        }
    }
}