using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_roadtrip.Persistence.Migrations
{
    public partial class AddTabelaCategoriaEvento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Evento",
                newName: "Nome");

            migrationBuilder.CreateTable(
                name: "CategoriaEvento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaEvento", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaEvento");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Evento",
                newName: "Descricao");
        }
    }
}
