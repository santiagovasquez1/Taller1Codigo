using System;

namespace Taller1Codigo.Cuentas
{
    public class CuentaCorreo : ICuenta
    {
        public string NombreCuenta { get; set; }
        public string DirCorreo { get; set; }

        public CuentaCorreo(string nombreCuenta, string dirCorreo)
        {
            NombreCuenta = nombreCuenta;
            DirCorreo = dirCorreo;
        }

        public void enviar(string mensaje)
        {
            string formato = $"Enviando a {DirCorreo} : ";
            Console.WriteLine(formato + mensaje);
        }
    }
}