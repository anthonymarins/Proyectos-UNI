using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFactura.Modelo
{
    public class DetalleFactura
    {
        [Key,ForeignKey("facturas")]
        public int idFactura { get; set; }
        public Facturas facturas { get; set; }
        [Key,ForeignKey("productos")]
        public int idProducto { get; set; }
        public Productos productos { get; set; }
        public int catidad { get; set; }
    }
}
