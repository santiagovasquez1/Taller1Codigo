using System;
using System.Collections.Generic;
using System.Text;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo.FabricaCuentas
{
      public class FabricaCuentasCorreo
      {
            public List<ICuenta> CuentasCorreos { get; set; }

            public FabricaCuentasCorreo()
            {
                  CuentasCorreos = new List<ICuenta>()
                  {
                        new CuentaCorreo("Santiago Vasquez", "santivasquez1@gmail.com"),
                        new CuentaCorreo("Luis Marin","betomm@gmail.com"),
                        new CuentaCorreo("Fabio Salazar","fsalazarpaardo@gmail.com")
                  };
            }

      }
}
