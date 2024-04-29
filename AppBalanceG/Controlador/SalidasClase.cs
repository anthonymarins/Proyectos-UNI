using AppBalanceG.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBalanceG.Controlador
{
    public class SalidasClase: Cuentas
    {
        public decimal Salida { get; set; }
        public int IdTransaccion { get; set; }

        static List<SalidasClase> ListSalidas = new List<SalidasClase> { };
        public static List<SalidasClase> ListSalidas1 { get => ListSalidas; set => ListSalidas = value; }

        public SalidasClase(int idcuenta, string tipocuenta, string nombrecuenta, decimal valorcuenta,
                        int idtransacciones,decimal salidas)
                       : base(idcuenta, tipocuenta, nombrecuenta, valorcuenta)
        {
            this.IdTransaccion = idtransacciones;
            this.Salida = salidas;
        }

        public static void AgregarSalidas(SalidasClase e)
        {
            ListSalidas.Add(e);
        }

        public static void EditarSalidas( int id, decimal salida)
        {
            ListSalidas1[id].Salida =salida;
        }
    }
}
