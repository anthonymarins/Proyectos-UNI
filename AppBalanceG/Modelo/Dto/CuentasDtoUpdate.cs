using System.ComponentModel.DataAnnotations;

namespace ApiBalance.Modelo.Dto
{
    public class CuentasDtoUpdate
    {
        [Required]
        public int IdCuenta { get; set; }
        public string? tipoCuenta { get; set; }
        public string? NombreCuenta { get; set; }
        public decimal SaldoCuentas { get; set; }
        public string? Estado { get; set; }

    }
}
