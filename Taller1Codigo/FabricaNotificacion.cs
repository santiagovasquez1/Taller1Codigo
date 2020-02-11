using Taller1Codigo.Cuentas;

namespace Taller1Codigo
{
    public class FabricaNotificacion
    {
        public static INotificacion notificacion { get; set; }
        private NotificacionCorreo NotificacionCorreo { get; set; }
        private NotificacionFacebook NotificacionFacebook { get; set; }
        private NotificacionSMS NotificacionSMS { get; set; }

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
                notificacion = new NotificacionSMS(parametro);
            }
            return notificacion;
        }
    }
}