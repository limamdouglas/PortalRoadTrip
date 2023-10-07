using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_roadtrip.Persistence.Migrations
{
    public partial class AddTabelaEventoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Ponto_Funcionario_Evento_EventoId",
                table: "Evento_Ponto_Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Ponto_Funcionario_Funcionario_FuncionarioId",
                table: "Evento_Ponto_Funcionario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Evento_Ponto_Funcionario",
                table: "Evento_Ponto_Funcionario");

            migrationBuilder.RenameTable(
                name: "Evento_Ponto_Funcionario",
                newName: "Evento_Funcionario");

            migrationBuilder.RenameIndex(
                name: "IX_Evento_Ponto_Funcionario_FuncionarioId",
                table: "Evento_Funcionario",
                newName: "IX_Evento_Funcionario_FuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Evento_Ponto_Funcionario_EventoId",
                table: "Evento_Funcionario",
                newName: "IX_Evento_Funcionario_EventoId");

            migrationBuilder.AddColumn<int>(
                name: "EventoId1",
                table: "Evento_Ponto_Embarque",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Evento",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Preco",
                table: "Evento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeVagas",
                table: "Evento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeVagasReservas",
                table: "Evento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Roteiro",
                table: "Evento",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Evento_Funcionario",
                table: "Evento_Funcionario",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Evento_Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventoId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsuarioID = table.Column<int>(type: "INTEGER", nullable: false),
                    EventoId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evento_Cliente_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_Cliente_Evento_EventoId1",
                        column: x => x.EventoId1,
                        principalTable: "Evento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Evento_Cliente_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evento_Ponto_Embarque_EventoId1",
                table: "Evento_Ponto_Embarque",
                column: "EventoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_Cliente_EventoId",
                table: "Evento_Cliente",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_Cliente_EventoId1",
                table: "Evento_Cliente",
                column: "EventoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_Cliente_UsuarioID",
                table: "Evento_Cliente",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Funcionario_Evento_EventoId",
                table: "Evento_Funcionario",
                column: "EventoId",
                principalTable: "Evento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Funcionario_Funcionario_FuncionarioId",
                table: "Evento_Funcionario",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Ponto_Embarque_Evento_EventoId1",
                table: "Evento_Ponto_Embarque",
                column: "EventoId1",
                principalTable: "Evento",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Funcionario_Evento_EventoId",
                table: "Evento_Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Funcionario_Funcionario_FuncionarioId",
                table: "Evento_Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Ponto_Embarque_Evento_EventoId1",
                table: "Evento_Ponto_Embarque");

            migrationBuilder.DropTable(
                name: "Evento_Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Evento_Ponto_Embarque_EventoId1",
                table: "Evento_Ponto_Embarque");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Evento_Funcionario",
                table: "Evento_Funcionario");

            migrationBuilder.DropColumn(
                name: "EventoId1",
                table: "Evento_Ponto_Embarque");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "QuantidadeVagas",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "QuantidadeVagasReservas",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "Roteiro",
                table: "Evento");

            migrationBuilder.RenameTable(
                name: "Evento_Funcionario",
                newName: "Evento_Ponto_Funcionario");

            migrationBuilder.RenameIndex(
                name: "IX_Evento_Funcionario_FuncionarioId",
                table: "Evento_Ponto_Funcionario",
                newName: "IX_Evento_Ponto_Funcionario_FuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Evento_Funcionario_EventoId",
                table: "Evento_Ponto_Funcionario",
                newName: "IX_Evento_Ponto_Funcionario_EventoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Evento_Ponto_Funcionario",
                table: "Evento_Ponto_Funcionario",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Ponto_Funcionario_Evento_EventoId",
                table: "Evento_Ponto_Funcionario",
                column: "EventoId",
                principalTable: "Evento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Ponto_Funcionario_Funcionario_FuncionarioId",
                table: "Evento_Ponto_Funcionario",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
