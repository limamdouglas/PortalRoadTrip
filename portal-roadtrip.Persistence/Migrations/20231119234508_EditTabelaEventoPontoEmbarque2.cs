using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_roadtrip.Persistence.Migrations
{
    public partial class EditTabelaEventoPontoEmbarque2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Horario",
                table: "Evento_Ponto_Embarque",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Evento_Ponto_Embarque");
        }
    }
}
