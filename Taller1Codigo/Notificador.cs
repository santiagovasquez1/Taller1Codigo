using System;
using System.Collections.Generic;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo
{
    public class Notificador
    {
        public List<ICuenta> Cuentas { get; set; }

        public Notificador(List<ICuenta> pCuentas)
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