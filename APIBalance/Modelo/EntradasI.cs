using System.ComponentModel.DataAnnotations;

namespace APIBalance.Modelo
{
    public class EntradasI
    {
        public int IdC { get; set; }
        public int IdTransaccion { get; set; }
        public decimal Entrada { get; set; }
    }
}
