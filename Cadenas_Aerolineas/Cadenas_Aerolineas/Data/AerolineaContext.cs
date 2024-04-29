using Cadenas_Aerolineas.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadenas_Aerolineas.Data
{
    public class AerolineaContext : DbContext
    {
        public AerolineaContext(DbContextOptions<AerolineaContext> options): base(options)
        { }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<Pasajeros> Peliculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pasajeros>().HasData(
                new Pasajeros()
                {
                    ID = 1,
                    Name = "Axel",
                    APaterno = "Carrion",
                    AMaterno = "Castellon",
                    Email = "axel.carrion60u.com",
                    Telefono = Convert.ToInt32("88445577"),
                    IdPais = 1
                });

            modelBuilder.Entity<Pasajeros>().HasData(
                new Pasajeros()
                {
                    ID = 2,
                    Name = "Angel",
                    APaterno = "Carrion",
                    AMaterno = "Castellon",
                    Email = "angel.carrion60u.com",
                    Telefono = Convert.ToInt32("77215056"),
                    IdPais = 1
                });

            modelBuilder.Entity<Paises>().HasData(
                new Paises()
                {
                    ID = 1,
                    Name = "Nicaragua"
                });
        }

    }
}
