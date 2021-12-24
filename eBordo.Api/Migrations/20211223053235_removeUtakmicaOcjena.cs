using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class removeUtakmicaOcjena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "utakmicaOcjena");

            migrationBuilder.AddColumn<int>(
                name: "brzina",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "dodavanje",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "driblanje",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "klizeciStart",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "kontrolaLopte",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "kretanje",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "markiranje",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "odbrana",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "skok",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "snaga",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sut",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "brzina",
                table: "utakmicaNastup");

            migrationBuilder.DropColumn(
                name: "dodavanje",
                table: "utakmicaNastup");

            migrationBuilder.DropColumn(
                name: "driblanje",
                table: "utakmicaNastup");

            migrationBuilder.DropColumn(
                name: "klizeciStart",
                table: "utakmicaNastup");

            migrationBuilder.DropColumn(
                name: "kontrolaLopte",
                table: "utakmicaNastup");

            migrationBuilder.DropColumn(
                name: "kretanje",
                table: "utakmicaNastup");

            migrationBuilder.DropColumn(
                name: "markiranje",
                table: "utakmicaNastup");

            migrationBuilder.DropColumn(
                name: "odbrana",
                table: "utakmicaNastup");

            migrationBuilder.DropColumn(
                name: "skok",
                table: "utakmicaNastup");

            migrationBuilder.DropColumn(
                name: "snaga",
                table: "utakmicaNastup");

            migrationBuilder.DropColumn(
                name: "sut",
                table: "utakmicaNastup");

            migrationBuilder.CreateTable(
                name: "utakmicaOcjena",
                columns: table => new
                {
                    utakmicaOcjenaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brzina = table.Column<int>(type: "int", nullable: false),
                    dodavanje = table.Column<int>(type: "int", nullable: false),
                    driblanje = table.Column<int>(type: "int", nullable: false),
                    igracId = table.Column<int>(type: "int", nullable: false),
                    izvještajId = table.Column<int>(type: "int", nullable: true),
                    klizeciStart = table.Column<int>(type: "int", nullable: false),
                    kontrolaLopte = table.Column<int>(type: "int", nullable: false),
                    kretanje = table.Column<int>(type: "int", nullable: false),
                    markiranje = table.Column<int>(type: "int", nullable: false),
                    odbrana = table.Column<int>(type: "int", nullable: false),
                    prosjecnaOcjena = table.Column<float>(type: "real", nullable: false),
                    skok = table.Column<int>(type: "int", nullable: false),
                    snaga = table.Column<int>(type: "int", nullable: false),
                    sut = table.Column<int>(type: "int", nullable: false),
                    trenerId = table.Column<int>(type: "int", nullable: false),
                    utakmicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utakmicaOcjena", x => x.utakmicaOcjenaId);
                    table.ForeignKey(
                        name: "FK_utakmicaOcjena_igraci_igracId",
                        column: x => x.igracId,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_utakmicaOcjena_izvještaj_izvještajId",
                        column: x => x.izvještajId,
                        principalTable: "izvještaj",
                        principalColumn: "izvještajId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_utakmicaOcjena_treneri_trenerId",
                        column: x => x.trenerId,
                        principalTable: "treneri",
                        principalColumn: "trenerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_utakmicaOcjena_utakmice_utakmicaId",
                        column: x => x.utakmicaId,
                        principalTable: "utakmice",
                        principalColumn: "utakmicaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaOcjena_igracId",
                table: "utakmicaOcjena",
                column: "igracId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaOcjena_izvještajId",
                table: "utakmicaOcjena",
                column: "izvještajId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaOcjena_trenerId",
                table: "utakmicaOcjena",
                column: "trenerId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaOcjena_utakmicaId",
                table: "utakmicaOcjena",
                column: "utakmicaId");
        }
    }
}
