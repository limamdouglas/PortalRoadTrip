using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_roadtrip.Persistence.Migrations
{
    public partial class NovaPropriedadeEventoCliente_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EhReserva",
                table: "Evento_Cliente",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeVaga",
                table: "Evento_Cliente",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EhReserva",
                table: "Evento_Cliente");

            migrationBuilder.DropColumn(
                name: "QuantidadeVaga",
                table: "Evento_Cliente");
        }
    }
}
