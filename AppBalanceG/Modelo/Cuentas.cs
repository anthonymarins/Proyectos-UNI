using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBalanceG.Modelo
{
    public class Cuentas
    {    
        public int IdCuenta { get; set;}
        public string TipoCuenta { get; set;}
        public string NombreCuenta { get; set;}
        public decimal ValorCuenta { get; set;}

        public Cuentas(int idCuenta, string tipoCuenta, string nombreCuenta, decimal valorCuenta)
        {
            IdCuenta = idCuenta;
            TipoCuenta = tipoCuenta;
            NombreCuenta = nombreCuenta;
            ValorCuenta = valorCuenta;
        }

    }
}
