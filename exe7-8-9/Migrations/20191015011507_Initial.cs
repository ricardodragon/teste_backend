using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace exe7_8_9.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "candidato",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidato", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "skil",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skil", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vaga",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vaga", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CandidatoSkil",
                columns: table => new
                {
                    candidatoId = table.Column<int>(nullable: false),
                    skilId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoSkil", x => new { x.candidatoId, x.skilId });
                    table.ForeignKey(
                        name: "FK_CandidatoSkil_candidato_candidatoId",
                        column: x => x.candidatoId,
                        principalTable: "candidato",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatoSkil_skil_skilId",
                        column: x => x.skilId,
                        principalTable: "skil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VagaSkil",
                columns: table => new
                {
                    vagaId = table.Column<int>(nullable: false),
                    skilId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VagaSkil", x => new { x.vagaId, x.skilId });
                    table.ForeignKey(
                        name: "FK_VagaSkil_skil_skilId",
                        column: x => x.skilId,
                        principalTable: "skil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VagaSkil_vaga_vagaId",
                        column: x => x.vagaId,
                        principalTable: "vaga",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoSkil_skilId",
                table: "CandidatoSkil",
                column: "skilId");

            migrationBuilder.CreateIndex(
                name: "IX_VagaSkil_skilId",
                table: "VagaSkil",
                column: "skilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidatoSkil");

            migrationBuilder.DropTable(
                name: "VagaSkil");

            migrationBuilder.DropTable(
                name: "candidato");

            migrationBuilder.DropTable(
                name: "skil");

            migrationBuilder.DropTable(
                name: "vaga");
        }
    }
}
