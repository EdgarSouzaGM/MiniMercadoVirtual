using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniMercadoVirtual.Migrations
{
    public partial class Alteradocampoprecoparadecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Produto",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produto",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Preco",
                table: "Produto",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
