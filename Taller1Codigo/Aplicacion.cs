using System;
using System.Collections.Generic;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo
{
    public class Aplicacion
    {
        public Usuario User { get; set; }
        public List<INotificacion> Notificaciones { get; set; }

        public Aplicacion ( Usuario usuario , List<INotificacion> notificacions )
        {
            User = usuario;
            Notificaciones = notificacions;
            SetNotificador(Notificaciones);
        }

        private void SetNotificador ( List<INotificacion> pNotificaciones )
        {
            foreach ( var notificacion in pNotificaciones )
            {
                User.AddNotificacion(notificacion);
            }
        }

        public void EnviarMensaje ( string Mensaje )
        {
            string Prefijo = $"Enviando notificacion a {User.Nombre}";
            Console.WriteLine(Prefijo);

            foreach ( var notificacion in Notificaciones )
            {
                notificacion.enviar(Mensaje);
            }
        }
    }
}