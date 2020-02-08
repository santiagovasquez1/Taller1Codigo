using System;
using System.Collections.Generic;
using Taller1Codigo.Cuentas;
using Taller1Codigo.FabricaCuentas;

namespace Taller1Codigo
{
      internal class Program
      {
            public static Aplicacion aplicacion = null;

            private static void Main(string[] args)
            {
                  List<ICuenta> CuentasCorreos = new FabricaCuentasCorreo().CuentasCorreos;
                  List<ICuenta> CuentasFacebook = new FabricaCuentasFacebook().CuentaFacebooks;
                  List<ICuenta> CuentasSmS = new FabricaCuentasSMS().CuentaSMSS;

                  aplicacion = new Aplicacion(CuentasCorreos);
                  aplicacion.EnviarMensaje();
                  Console.WriteLine("------------");

                  aplicacion = new Aplicacion(CuentasFacebook);
                  aplicacion.EnviarMensaje();
                  Console.WriteLine("------------");

                  aplicacion = new Aplicacion(CuentasSmS);
                  aplicacion.EnviarMensaje();
                  Console.WriteLine("------------");

                  Console.ReadLine();
            }
      }
}