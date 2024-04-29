using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFactura.Modelo
{
    public class Productos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        //[StringLength(60)]
        public char Nombre { get; set; }  
        //[MaxLength(18)]
        public decimal Precio { get; set; } 
        public int  Stock { get; set; } 
    }
}
