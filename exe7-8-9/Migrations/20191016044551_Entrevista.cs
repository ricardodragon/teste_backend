using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace exe7_8_9.Migrations
{
    public partial class Entrevista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entrevista",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    vagaId = table.Column<int>(nullable: false),
                    data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entrevista", x => x.id);
                    table.ForeignKey(
                        name: "FK_entrevista_vaga_vagaId",
                        column: x => x.vagaId,
                        principalTable: "vaga",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "entrevistaSkil",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    entrevistaId = table.Column<int>(nullable: false),
                    skilId = table.Column<int>(nullable: false),
                    pontuacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entrevistaSkil", x => x.id);
                    table.ForeignKey(
                        name: "FK_entrevistaSkil_entrevista_entrevistaId",
                        column: x => x.entrevistaId,
                        principalTable: "entrevista",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_entrevistaSkil_skil_skilId",
                        column: x => x.skilId,
                        principalTable: "skil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_entrevista_vagaId",
                table: "entrevista",
                column: "vagaId");

            migrationBuilder.CreateIndex(
                name: "IX_entrevistaSkil_entrevistaId",
                table: "entrevistaSkil",
                column: "entrevistaId");

            migrationBuilder.CreateIndex(
                name: "IX_entrevistaSkil_skilId",
                table: "entrevistaSkil",
                column: "skilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entrevistaSkil");

            migrationBuilder.DropTable(
                name: "entrevista");
        }
    }
}
