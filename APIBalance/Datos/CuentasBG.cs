using APIBalance.Modelo;
using Microsoft.EntityFrameworkCore;

namespace APIBalance.Datos
{
    public class CuentasBG : DbContext
    {
        public CuentasBG(DbContextOptions<CuentasBG> options) : base(options)
        {
        }

        public DbSet<CuentasI> Cuentas { get; set; }
        public DbSet<EntradasI> Entradas { get; set; }
        public DbSet<SalidasI> Salidas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CuentasI>().HasData(new CuentasI()
            {
                IdCuenta = 1,
                NombreCuenta = "Banco",
                TipoCuenta = "Activo",
                ValorCuenta = 1000
            });
        }
    }
}
