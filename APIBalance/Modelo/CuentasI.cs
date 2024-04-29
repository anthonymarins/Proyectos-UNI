using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIBalance.Modelo
{
    public class CuentasI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCuenta { get; set; }
        [Required]
        public string? TipoCuenta { get; set; }
        public string? NombreCuenta { get; set; }
        public decimal ValorCuenta { get; set; }
        [ForeignKey("IdC")]
        EntradasI entradas { get; set; }

        [ForeignKey("IdC")]
        SalidasI salidas { get; set; }
    }
}
