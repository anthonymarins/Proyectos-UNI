using System.ComponentModel.DataAnnotations;

namespace ApiBalance.Modelo.Dto
{
    public class CuentasDtoCreate
    {
        [Required]
        public string? tipoCuenta { get; set; }
        public string? NombreCuenta { get; set; }
        public decimal SaldoCuentas { get; set; }
        public string? Estado { get; set; }
    }
}
