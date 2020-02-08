using System.Collections.Generic;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo.FabricaCuentas
{
      public class FabricaCuentasSMS
      {
            public List<ICuenta> CuentaSMSS { get; set; }

            public FabricaCuentasSMS()
            {
                  CuentaSMSS = new List<ICuenta>()
                  {
                        new CuentaSMS("Santiago Vasquez", "310 4509399"),
                        new CuentaSMS("Luis Marin","311 7609582"),
                        new CuentaSMS("Fabio Salazar","310 3934690")
                  };
            }
      }
}