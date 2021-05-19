using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCRUD_EF_CODEFIRST.Migrations
{
    public partial class ProductoCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Cotizaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    TelefonoContacto = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CotizacionId = table.Column<int>(type: "int", nullable: false),
                    CotizacionId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_Cotizaciones_CotizacionId1",
                        column: x => x.CotizacionId1,
                        principalTable: "Cotizaciones",
                        principalColumn: "CotizacionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKU = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalFila = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CotizacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productos_Cotizaciones_CotizacionId",
                        column: x => x.CotizacionId,
                        principalTable: "Cotizaciones",
                        principalColumn: "CotizacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CotizacionId1",
                table: "Clientes",
                column: "CotizacionId1");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CotizacionId",
                table: "Productos",
                column: "CotizacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Cotizaciones");
        }
    }
}
