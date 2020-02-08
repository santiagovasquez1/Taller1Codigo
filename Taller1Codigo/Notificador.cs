using System;
using System.Collections.Generic;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo
{
    public class Notificador
    {
        public List<INotificacion> Cuentas { get; set; }

        public Notificador(List<INotificacion> pCuentas)
        {
            Cuentas = pCuentas;
        }

        public void enviar(string mensaje)
        {
            foreach (var cuentai in Cuentas)
            {
                        cuentai.enviar(mensaje);
            }
        }
    }
}