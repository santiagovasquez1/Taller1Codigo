using System;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo
{
    internal class Program
    {
        private static FabricaNotificacion fabricaNotificacion { get; set; }
        private static void Main(string[] args)
        {
            INotificacion notificacion1 = null;

            /*
            Se crea esta lista, para ejemplificar que la clase Fabrica notificación 
            será la encargada de la creación de la clase notificación requerida y asi 
            el cliente no se tiene que preocupar por establecer algun parametro en especifico
            para el envio de la notificación.
            */

            string[] ListaDatos ={"santivasquez1@gmail.com",
                                "fsalazarpaardo@gmail.com",
                                "www.facebook.com/luismesa",
                                "Fabio Salazar-310 4509341",
                                "Santiago Vasquez 310 450 94 12",
                                "svasquez@unal.edu.co",
                                "Pepito perez",
                                "2562284"};

            foreach ( var cuentai in ListaDatos )
            {
                fabricaNotificacion = new FabricaNotificacion(cuentai);
                notificacion1 = fabricaNotificacion.MetodoFabrica();

                if (notificacion1 != null)
                {
                    notificacion1.enviar($"{notificacion1.ToString()} Prueba");
                }
            }

        }
    }
}
