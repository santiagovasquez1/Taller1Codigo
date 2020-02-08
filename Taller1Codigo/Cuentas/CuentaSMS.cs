using System;

namespace Taller1Codigo.Cuentas
{
      internal class CuentaSMS : ICuenta
      {
            public string NombreCuenta { get; set; }
            public string NumeroTelefonico { get; set; }

            public CuentaSMS(string nombre, string numero)
            {
                  NombreCuenta = nombre;
                  NumeroTelefonico = numero;
            }

            public void enviar(string mensaje)
            {
                  string formato = $"Enviando a {NombreCuenta} {NumeroTelefonico} : ";
                  Console.WriteLine(formato + mensaje);
            }
      }
}