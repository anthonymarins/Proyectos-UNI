using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFactura.Modelo
{
    public class Clientes
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public char Nombre { get; set; }
        public char Apellido { get; set; }
        public char Direccion { get; set; } 
    }
}
