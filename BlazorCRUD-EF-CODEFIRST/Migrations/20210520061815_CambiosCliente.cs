using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCRUD_EF_CODEFIRST.Migrations
{
    public partial class CambiosCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Cotizaciones_CotizacionId1",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_CotizacionId1",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CotizacionId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CotizacionId1",
                table: "Clientes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CotizacionId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CotizacionId1",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CotizacionId1",
                table: "Clientes",
                column: "CotizacionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Cotizaciones_CotizacionId1",
                table: "Clientes",
                column: "CotizacionId1",
                principalTable: "Cotizaciones",
                principalColumn: "CotizacionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
