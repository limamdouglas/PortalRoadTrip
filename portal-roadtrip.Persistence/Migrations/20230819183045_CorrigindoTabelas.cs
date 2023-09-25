using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_roadtrip.Persistence.Migrations
{
    public partial class CorrigindoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDemissao",
                table: "Funcionario",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Conexao_Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    UsuarioId2 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conexao_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conexao_Usuario_Usuario_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conexao_Usuario_Usuario_UsuarioId2",
                        column: x => x.UsuarioId2,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conexao_Usuario_UsuarioId1",
                table: "Conexao_Usuario",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Conexao_Usuario_UsuarioId2",
                table: "Conexao_Usuario",
                column: "UsuarioId2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conexao_Usuario");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDemissao",
                table: "Funcionario",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
