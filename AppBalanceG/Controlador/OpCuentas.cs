using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBalanceG.Modelo;

namespace AppBalanceG.Controlador
{
    public  class OpCuentas:Cuentas
    {
        static List<Cuentas> ListaCuentas = new List<Cuentas> { };

        public OpCuentas(int idCuenta, string tipoCuenta, string nombreCuenta, decimal valorCuenta) : base(idCuenta, tipoCuenta, nombreCuenta, valorCuenta)
        {

        }

        public static List<Cuentas> ListaCuentas1 { get => ListaCuentas; set => ListaCuentas = value; }

        public static void EditarCuenta(int i, string tipo,string nombre,decimal valor) 
        {
            ListaCuentas1[i].TipoCuenta = tipo;
            ListaCuentas1[i].NombreCuenta = nombre;
            ListaCuentas1[i].ValorCuenta = valor;
        }
    }
}
