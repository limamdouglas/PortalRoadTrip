using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_roadtrip.Persistence.Migrations
{
    public partial class AddRelacionamentoCategoriaEvento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaEventoId",
                table: "Evento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Evento_CategoriaEventoId",
                table: "Evento",
                column: "CategoriaEventoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_CategoriaEvento_CategoriaEventoId",
                table: "Evento",
                column: "CategoriaEventoId",
                principalTable: "CategoriaEvento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_CategoriaEvento_CategoriaEventoId",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_CategoriaEventoId",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "CategoriaEventoId",
                table: "Evento");
        }
    }
}
