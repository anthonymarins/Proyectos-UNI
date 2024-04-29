using System.ComponentModel.DataAnnotations;

namespace ApiBalance.Modelo.Dto
{
    public class SalidasDtoCreate
    {
        public int IdTransaccion { get; set; }
        [Required]
        public decimal salidas { get; set; }
        public int IdCuenta { get; set; }
    }
}
