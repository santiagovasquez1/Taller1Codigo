using System;

namespace Taller1Codigo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Aplicacion aplicacion = new Aplicacion();
            aplicacion.EnviarMensaje();
            Console.ReadLine();
        }
    }
}