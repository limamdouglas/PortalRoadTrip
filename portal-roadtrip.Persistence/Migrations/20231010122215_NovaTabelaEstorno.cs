using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portal_roadtrip.Persistence.Migrations
{
    public partial class NovaTabelaEstorno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estorno",
                columns: table => new
                {
                    EstornoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataPagamento = table.Column<string>(type: "TEXT", nullable: true),
                    DataSolicitacao = table.Column<string>(type: "TEXT", nullable: true),
                    IdTransacao = table.Column<string>(type: "TEXT", nullable: true),
                    Plataforma = table.Column<string>(type: "TEXT", nullable: true),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    PorcentagemDevolvida = table.Column<decimal>(type: "TEXT", nullable: false),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    Estornado = table.Column<decimal>(type: "TEXT", nullable: false),
                    FormaPg = table.Column<string>(type: "TEXT", nullable: true),
                    PrazoEstimado = table.Column<string>(type: "TEXT", nullable: true),
                    Acompanhamento = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Motivo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estorno", x => x.EstornoId);
                    table.ForeignKey(
                        name: "FK_Estorno_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estorno_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estorno_ClienteId",
                table: "Estorno",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Estorno_EventoId",
                table: "Estorno",
                column: "EventoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estorno");
        }
    }
}
