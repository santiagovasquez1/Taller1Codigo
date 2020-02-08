using System.Collections.Generic;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo
{
    public class Usuario
    {
        public string Nombre { get; set; }

        public List<INotificacion> Notificaciones { get; private set; }

        public Usuario ( string nombre )
        {
            Nombre = nombre;
            Notificaciones = new List<INotificacion>();
        }

        public void AddNotificacion ( INotificacion notificacion )
        {
            Notificaciones.Add(notificacion);
        }
    }
}