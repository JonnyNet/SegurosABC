using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SegurosABC.Repositories.Migrations
{
    public partial class DB_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cedula = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PIN = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cedula);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaPago = table.Column<DateTime>(type: "datetime", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(11,2)", precision: 11, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagos_Clientes_Cedula",
                        column: x => x.Cedula,
                        principalTable: "Clientes",
                        principalColumn: "Cedula");
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Cedula", "Nombre", "PIN" },
                values: new object[] { "8-75-584", "Juan Perez", 1478 });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Cedula", "Nombre", "PIN" },
                values: new object[] { "PE-254-845", "Miguel Batista", 1244 });

            migrationBuilder.InsertData(
                table: "Pagos",
                columns: new[] { "Id", "Cedula", "FechaPago", "Monto" },
                values: new object[,]
                {
                    { 1, "8-75-584", new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.00m },
                    { 2, "8-75-584", new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 198.22m },
                    { 3, "8-75-584", new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.00m },
                    { 4, "PE-254-845", new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.00m },
                    { 5, "PE-254-845", new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 198.22m },
                    { 6, "PE-254-845", new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PIN",
                table: "Clientes",
                column: "PIN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_Cedula",
                table: "Pagos",
                column: "Cedula");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
