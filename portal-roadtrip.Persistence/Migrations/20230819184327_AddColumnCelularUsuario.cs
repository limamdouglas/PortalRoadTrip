using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_roadtrip.Persistence.Migrations
{
    public partial class AddColumnCelularUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Usuario",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Usuario");
        }
    }
}
