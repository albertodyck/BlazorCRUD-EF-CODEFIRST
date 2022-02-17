using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCRUD_EF_CODEFIRST.Migrations
{
    public partial class CambiosCliente2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_ClienteId",
                table: "Cotizaciones",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cotizaciones_Clientes_ClienteId",
                table: "Cotizaciones",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cotizaciones_Clientes_ClienteId",
                table: "Cotizaciones");

            migrationBuilder.DropIndex(
                name: "IX_Cotizaciones_ClienteId",
                table: "Cotizaciones");
        }
    }
}
