using System;
using System.Collections.Generic;

namespace Taller1Codigo
{
    public class Notificador
    {
        public List<string> Correos { get; set; }

        public Notificador(List<string> pCorreos)
        {
            Correos = pCorreos;
        }

        public void enviar(string mensaje)
        {
            foreach (var correoi in Correos)
            {
                Console.WriteLine($"Enviando mensaje a {correoi} : {mensaje}");
            }
        }
    }
}