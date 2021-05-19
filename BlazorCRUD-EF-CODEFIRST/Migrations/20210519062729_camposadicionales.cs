using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCRUD_EF_CODEFIRST.Migrations
{
    public partial class camposadicionales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCaptura",
                table: "Cotizaciones",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "IVA",
                table: "Cotizaciones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Moneda",
                table: "Cotizaciones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "Cotizaciones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TerminosPago",
                table: "Cotizaciones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiempoEntrega",
                table: "Cotizaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Cotizaciones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Vigencia",
                table: "Cotizaciones",
                type: "date",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    ComentarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mensaje = table.Column<string>(type: "varchar(max)", nullable: false),
                    CotizacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.ComentarioId);
                    table.ForeignKey(
                        name: "FK_Comentarios_Cotizaciones_CotizacionId",
                        column: x => x.CotizacionId,
                        principalTable: "Cotizaciones",
                        principalColumn: "CotizacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_CotizacionId",
                table: "Comentarios",
                column: "CotizacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropColumn(
                name: "FechaCaptura",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "IVA",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "Moneda",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "TerminosPago",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "TiempoEntrega",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Cotizaciones");

            migrationBuilder.DropColumn(
                name: "Vigencia",
                table: "Cotizaciones");
        }
    }
}
