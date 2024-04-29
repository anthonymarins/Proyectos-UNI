using System.ComponentModel.DataAnnotations;

namespace APIBalance.Modelo
{
    public class SalidasI
    {
        public int IdC { get; set; }
        public int IdTransaccion { get; set; }
        public decimal Salida { get; set; }
    }
}
