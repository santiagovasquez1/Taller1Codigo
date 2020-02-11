using System;
using System.Collections.Generic;
using System.Linq;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            //List<INotificacion> notificacion;
            INotificacion notificacion1 = null;

            string[] ListaDatos ={ "santivasquez1@gmail.com",
            "www.facebook.com/luismesa",
            "Fabio Salazar-310 4509341",
            "svasquez@unal.edu.co"};

            foreach (var cuentai in ListaDatos)
            {
                notificacion1 = FabricaNotificacion.MetodoFabrica(cuentai);
                if (notificacion1 != null)
                {
                    notificacion1.enviar($"{notificacion1.ToString()} Prueba");
                }

            }

            Console.ReadLine();
        }

    }
}
