using Taller1Codigo.Cuentas;

namespace Taller1Codigo
{
    public class FabricaNotificacion
    {
        public static INotificacion MetodoFabrica(string parametro)
        {
            INotificacion notificacion = null;

            if (parametro.Contains("@"))
            {
                notificacion = new NotificacionCorreo(parametro);
            }
            else if (parametro.Contains("www"))
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