using System.ComponentModel.DataAnnotations;

namespace ApiBalance.Modelo.Dto
{
    public class EntradasDto
    {
        [Required]
        public int IdTransaccion { get; set; }
        public decimal entradas { get; set; }
        public int IdCuenta { get; set; }
    }
}
