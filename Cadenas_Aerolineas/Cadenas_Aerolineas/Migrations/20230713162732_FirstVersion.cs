using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cadenas_Aerolineas.Migrations
{
    /// <inheritdoc />
    public partial class FirstVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    APaterno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AMaterno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    IdPais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Peliculas_Paises_IdPais",
                        column: x => x.IdPais,
                        principalTable: "Paises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Nicaragua" });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "ID", "AMaterno", "APaterno", "Email", "IdPais", "Name", "Telefono" },
                values: new object[,]
                {
                    { 1, "Castellon", "Carrion", "axel.carrion60u.com", 1, "Axel", 88445577 },
                    { 2, "Castellon", "Carrion", "angel.carrion60u.com", 1, "Angel", 77215056 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_IdPais",
                table: "Peliculas",
                column: "IdPais");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
