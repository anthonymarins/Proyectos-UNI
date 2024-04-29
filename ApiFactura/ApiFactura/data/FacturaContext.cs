using ApiFactura.Modelo;
using Microsoft.EntityFrameworkCore;
namespace ApiFactura.data
{
    public class FacturaContext : DbContext
    {
        public FacturaContext(DbContextOptions<FacturaContext> options) : base(options)
        {

        }
        public DbSet<Productos> productos { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Facturas> facturas { get; set; }
        public DbSet<DetalleFactura> detallesFactura { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleFactura>()
            .HasKey(df => new { df.idFactura, df.idProducto });

            base.OnModelCreating(modelBuilder);
        }
    }
}
