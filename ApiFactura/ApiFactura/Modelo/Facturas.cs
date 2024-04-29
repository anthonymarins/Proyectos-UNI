using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFactura.Modelo
{
    public class Facturas
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime fecha { get; set; }
        [ForeignKey("clientes")]
        public int idCliente  { get; set; } 
        public Clientes? clientes { get; set; }
    }
}
