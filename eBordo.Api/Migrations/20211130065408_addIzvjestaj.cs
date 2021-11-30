using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addIzvjestaj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "izmjena",
                columns: table => new
                {
                    izmjenaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    igracOutId = table.Column<int>(type: "int", nullable: false),
                    igracInId = table.Column<int>(type: "int", nullable: false),
                    minuta = table.Column<int>(type: "int", nullable: false),
                    izmjenaRazlog = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_izmjena", x => x.izmjenaId);
                    table.ForeignKey(
                        name: "FK_izmjena_igraci_igracInId",
                        column: x => x.igracInId,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_izmjena_igraci_igracOutId",
                        column: x => x.igracOutId,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "izvještaj",
                columns: table => new
                {
                    izvještajId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    goloviSarajevo = table.Column<int>(type: "int", nullable: false),
                    goloviProtivnik = table.Column<int>(type: "int", nullable: false),
                    rezultat = table.Column<int>(type: "int", nullable: false),
                    brojGledalaca = table.Column<int>(type: "int", nullable: false),
                    datumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    zapisnik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    slikaSaUtakmice = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    vrijeme = table.Column<int>(type: "int", nullable: false),
                    igracUtakmicaID = table.Column<int>(type: "int", nullable: false),
                    utakmicaID = table.Column<int>(type: "int", nullable: false),
                    trenerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_izvještaj", x => x.izvještajId);
                    table.ForeignKey(
                        name: "FK_izvještaj_igraci_igracUtakmicaID",
                        column: x => x.igracUtakmicaID,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_izvještaj_treneri_trenerID",
                        column: x => x.trenerID,
                        principalTable: "treneri",
                        principalColumn: "trenerId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_izvještaj_utakmice_utakmicaID",
                        column: x => x.utakmicaID,
                        principalTable: "utakmice",
                        principalColumn: "utakmicaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "utakmicaIzmjena",
                columns: table => new
                {
                    utakmicaIzmjenaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    utakmicaId = table.Column<int>(type: "int", nullable: false),
                    izmjenaId = table.Column<int>(type: "int", nullable: false),
                    izvještajId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utakmicaIzmjena", x => x.utakmicaIzmjenaID);
                    table.ForeignKey(
                        name: "FK_utakmicaIzmjena_izmjena_izmjenaId",
                        column: x => x.izmjenaId,
                        principalTable: "izmjena",
                        principalColumn: "izmjenaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmicaIzmjena_izvještaj_izvještajId",
                        column: x => x.izvještajId,
                        principalTable: "izvještaj",
                        principalColumn: "izvještajId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmicaIzmjena_utakmice_utakmicaId",
                        column: x => x.utakmicaId,
                        principalTable: "utakmice",
                        principalColumn: "utakmicaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "utakmicaNastup",
                columns: table => new
                {
                    utakmicaNastupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    igracId = table.Column<int>(type: "int", nullable: false),
                    trenerId = table.Column<int>(type: "int", nullable: false),
                    minute = table.Column<int>(type: "int", nullable: false),
                    golovi = table.Column<int>(type: "int", nullable: false),
                    asistencije = table.Column<int>(type: "int", nullable: false),
                    zutiKartoni = table.Column<int>(type: "int", nullable: false),
                    crveniKartoni = table.Column<int>(type: "int", nullable: false),
                    ocjena = table.Column<int>(type: "int", nullable: false),
                    komentar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    izvještajId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utakmicaNastup", x => x.utakmicaNastupId);
                    table.ForeignKey(
                        name: "FK_utakmicaNastup_igraci_igracId",
                        column: x => x.igracId,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmicaNastup_izvještaj_izvještajId",
                        column: x => x.izvještajId,
                        principalTable: "izvještaj",
                        principalColumn: "izvještajId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmicaNastup_treneri_trenerId",
                        column: x => x.trenerId,
                        principalTable: "treneri",
                        principalColumn: "trenerId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "utakmicaOcjena",
                columns: table => new
                {
                    utakmicaOcjenaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    igracId = table.Column<int>(type: "int", nullable: false),
                    utakmicaId = table.Column<int>(type: "int", nullable: false),
                    kontrolaLopte = table.Column<int>(type: "int", nullable: false),
                    driblanje = table.Column<int>(type: "int", nullable: false),
                    dodavanje = table.Column<int>(type: "int", nullable: false),
                    kretanje = table.Column<int>(type: "int", nullable: false),
                    brzina = table.Column<int>(type: "int", nullable: false),
                    sut = table.Column<int>(type: "int", nullable: false),
                    snaga = table.Column<int>(type: "int", nullable: false),
                    markiranje = table.Column<int>(type: "int", nullable: false),
                    klizeciStart = table.Column<int>(type: "int", nullable: false),
                    skok = table.Column<int>(type: "int", nullable: false),
                    odbrana = table.Column<int>(type: "int", nullable: false),
                    prosjecnaOcjena = table.Column<float>(type: "real", nullable: false),
                    izvještajId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utakmicaOcjena", x => x.utakmicaOcjenaId);
                    table.ForeignKey(
                        name: "FK_utakmicaOcjena_igraci_igracId",
                        column: x => x.igracId,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmicaOcjena_izvještaj_izvještajId",
                        column: x => x.izvještajId,
                        principalTable: "izvještaj",
                        principalColumn: "izvještajId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmicaOcjena_utakmice_utakmicaId",
                        column: x => x.utakmicaId,
                        principalTable: "utakmice",
                        principalColumn: "utakmicaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_izmjena_igracInId",
                table: "izmjena",
                column: "igracInId");

            migrationBuilder.CreateIndex(
                name: "IX_izmjena_igracOutId",
                table: "izmjena",
                column: "igracOutId");

            migrationBuilder.CreateIndex(
                name: "IX_izvještaj_igracUtakmicaID",
                table: "izvještaj",
                column: "igracUtakmicaID");

            migrationBuilder.CreateIndex(
                name: "IX_izvještaj_trenerID",
                table: "izvještaj",
                column: "trenerID");

            migrationBuilder.CreateIndex(
                name: "IX_izvještaj_utakmicaID",
                table: "izvještaj",
                column: "utakmicaID");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaIzmjena_izmjenaId",
                table: "utakmicaIzmjena",
                column: "izmjenaId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaIzmjena_izvještajId",
                table: "utakmicaIzmjena",
                column: "izvještajId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaIzmjena_utakmicaId",
                table: "utakmicaIzmjena",
                column: "utakmicaId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaNastup_igracId",
                table: "utakmicaNastup",
                column: "igracId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaNastup_izvještajId",
                table: "utakmicaNastup",
                column: "izvještajId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaNastup_trenerId",
                table: "utakmicaNastup",
                column: "trenerId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaOcjena_igracId",
                table: "utakmicaOcjena",
                column: "igracId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaOcjena_izvještajId",
                table: "utakmicaOcjena",
                column: "izvještajId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaOcjena_utakmicaId",
                table: "utakmicaOcjena",
                column: "utakmicaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "utakmicaIzmjena");

            migrationBuilder.DropTable(
                name: "utakmicaNastup");

            migrationBuilder.DropTable(
                name: "utakmicaOcjena");

            migrationBuilder.DropTable(
                name: "izmjena");

            migrationBuilder.DropTable(
                name: "izvještaj");
        }
    }
}
