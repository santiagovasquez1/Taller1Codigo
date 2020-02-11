using System;

namespace Taller1Codigo.Cuentas
{
    public class NotificacionCorreo : INotificacion
    {
        public string DirCorreo { get; set; }

        public NotificacionCorreo ( string dirCorreo )
        {
            DirCorreo = dirCorreo;
        }

        public void enviar ( string mensaje )
        {
            string formato = $"Enviando a {DirCorreo} : ";
            Console.WriteLine(formato + mensaje);
        }
    }
}