using System.Collections.Generic;

namespace Taller1Codigo
{
    public class Aplicacion
    {
        public Notificador MiNotificador { get; set; }
        public List<string> Correos { get; set; }

        public Aplicacion()
        {
            Correos = new List<string>
            {
                "santivasquez1@gmail.com",
                "betomm@gmail.com ",
                "fsalazarpaardo@gmail.com"
            };
            SetNotificador(Correos);
        }

        public void SetNotificador(List<string> pcorreos)
        {
            MiNotificador = new Notificador(pcorreos);
        }

        public void EnviarMensaje()
        {
            MiNotificador.enviar("Alerta");
        }
    }
}