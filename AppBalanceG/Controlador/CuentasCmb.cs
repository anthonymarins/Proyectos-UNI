using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBalanceG.Controlador
{
    public class CuentasCmb
    {

        public string TipoCuenta { get; set; }
        public string NombreCuenta { get; set; }
        public static bool condi { get; set; } = false;

        public CuentasCmb(string tipoCuenta, string nombreCuenta)
        {
            TipoCuenta = tipoCuenta;
            NombreCuenta = nombreCuenta;
        }
        static List<CuentasCmb> ListCuentasCmb = new List<CuentasCmb> { };
        public static List<CuentasCmb> ListasCuentasCmb1 { get => ListCuentasCmb; set => ListCuentasCmb = value; }

        public static void GuardarCmb(CuentasCmb CC)
        {
            ListasCuentasCmb1.Add(CC);
        }
    }
}
