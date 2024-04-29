using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBalanceG.Modelo;

namespace AppBalanceG.Controlador
{
    public class EntradasClase: Cuentas
    {
        public decimal Entrada { get; set; }
        public int IdTransaccion { get; set; }

        static List<EntradasClase> ListEntradas = new List<EntradasClase> { };
        public static List<EntradasClase> ListEntradas1 { get => ListEntradas; set => ListEntradas = value; }

        public EntradasClase(int idcuenta, string tipocuenta, string nombrecuenta, decimal valorcuenta, 
                        int idtransacciones, decimal entrada)
                       : base(idcuenta, tipocuenta, nombrecuenta, valorcuenta)
        {
            this.IdTransaccion = idtransacciones;
            this.Entrada = entrada;
        }

        public static void AgregarEntradas(EntradasClase e)
        {
            ListEntradas.Add(e);
        }

        public static void EditarEntradas(int id, decimal entradas)
        {
            ListEntradas1[id].Entrada = entradas;
        }
    }
}
