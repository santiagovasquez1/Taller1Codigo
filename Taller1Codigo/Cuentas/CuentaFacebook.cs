using System;

namespace Taller1Codigo.Cuentas
{
    public class CuentaFacebook : ICuenta
    {
        public string NombreCuenta { get; set; }
        public string LinkFacebook { get; set; }

        public CuentaFacebook(string nombreCuenta, string link)
        {
            NombreCuenta = nombreCuenta;
            LinkFacebook = link;
        }

        public void enviar(string mensaje)
        {
            string formato = $"Enviando a {NombreCuenta} {LinkFacebook} : ";
            Console.WriteLine(formato + mensaje);
        }
    }
}