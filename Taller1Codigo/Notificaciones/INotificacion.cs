namespace Taller1Codigo.Cuentas
{
    /*
    Interfaz que representa casa una de las clases del tipo de 
    notificacion, lo que nos permite agregar más de una clase
    que la implementa.
    */
    public interface INotificacion
    {
         void enviar(string mensaje);
    }
}