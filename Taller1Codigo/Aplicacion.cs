using System.Collections.Generic;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo
{
      public class Aplicacion
      {
            public Notificador MiNotificador { get; set; }
            public List<INotificacion> Cuentas { get; set; }

            public Aplicacion(List<INotificacion> pcuentas)
            {
                  Cuentas = pcuentas;
                  SetNotificador(Cuentas);
            }

            public void SetNotificador(List<INotificacion> cuentas)
            {
                  MiNotificador = new Notificador(cuentas);
            }

            public void EnviarMensaje()
            {
                  MiNotificador.enviar("Alerta");
            }
      }
}