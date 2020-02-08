using System;

namespace Taller1Codigo.Cuentas
{
    internal class NotificacionSMS : INotificacion
    {
        public string NumeroTelefonico { get; set; }

        public NotificacionSMS ( string numero )
        {
            NumeroTelefonico = numero;
        }

        public void enviar ( string mensaje )
        {
            string formato = $"Enviando a  {NumeroTelefonico} : ";
            Console.WriteLine(formato + mensaje);
        }
    }
}