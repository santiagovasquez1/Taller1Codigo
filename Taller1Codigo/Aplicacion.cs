using System.Collections.Generic;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo
{
      public class Aplicacion
      {
            public Notificador MiNotificador { get; set; }
            public List<ICuenta> Cuentas { get; set; }

            public Aplicacion(List<ICuenta> pcuentas)
            {
                  Cuentas = pcuentas;
                  SetNotificador(Cuentas);
            }

            public void SetNotificador(List<ICuenta> cuentas)
            {
                  MiNotificador = new Notificador(cuentas);
            }

            public void EnviarMensaje()
            {
                  MiNotificador.enviar("Alerta");
            }
      }
}