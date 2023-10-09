using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_roadtrip.Persistence.Migrations
{
    public partial class AlterarTabelaEventoCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Cliente_Usuario_UsuarioID",
                table: "Evento_Cliente");

            migrationBuilder.RenameColumn(
                name: "UsuarioID",
                table: "Evento_Cliente",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Evento_Cliente_UsuarioID",
                table: "Evento_Cliente",
                newName: "IX_Evento_Cliente_ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Cliente_Cliente_ClienteID",
                table: "Evento_Cliente",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Cliente_Cliente_ClienteID",
                table: "Evento_Cliente");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Evento_Cliente",
                newName: "UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Evento_Cliente_ClienteID",
                table: "Evento_Cliente",
                newName: "IX_Evento_Cliente_UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Cliente_Usuario_UsuarioID",
                table: "Evento_Cliente",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
