using System.Collections.Generic;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo.FabricaCuentas
{
      public class FabricaCuentasFacebook
      {
            public List<ICuenta> CuentaFacebooks { get; set; }

            public FabricaCuentasFacebook()
            {
                  CuentaFacebooks = new List<ICuenta>
                  {
                        new CuentaFacebook("Santiago Vasquez", "www.facebook/santiagovasques.com"),
                        new CuentaFacebook("Luis Marin","www.facebook/luismarin.com"),
                        new CuentaFacebook("Fabio Salazar","www.facebook/fabiosalazar.com")
                  };
            }
      }
}