using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addtablekorisnikigracigracSkillsigracStatistikaugovor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "igracSkills",
                columns: table => new
                {
                    igracSkillsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    igracId = table.Column<int>(type: "int", nullable: true),
                    kontrolaLopte = table.Column<float>(type: "real", nullable: false),
                    kontrolaLopteZbir = table.Column<int>(type: "int", nullable: false),
                    driblanje = table.Column<float>(type: "real", nullable: false),
                    dribljanjeZbir = table.Column<int>(type: "int", nullable: false),
                    dodavanje = table.Column<float>(type: "real", nullable: false),
                    dodavanjeZbir = table.Column<int>(type: "int", nullable: false),
                    kretanje = table.Column<float>(type: "real", nullable: false),
                    kretanjeZbir = table.Column<int>(type: "int", nullable: false),
                    brzina = table.Column<float>(type: "real", nullable: false),
                    brzinaZbir = table.Column<int>(type: "int", nullable: false),
                    sut = table.Column<float>(type: "real", nullable: false),
                    sutZbir = table.Column<int>(type: "int", nullable: false),
                    snaga = table.Column<float>(type: "real", nullable: false),
                    snagaZbir = table.Column<int>(type: "int", nullable: false),
                    markiranje = table.Column<float>(type: "real", nullable: false),
                    markiranjeZbir = table.Column<int>(type: "int", nullable: false),
                    klizeciStart = table.Column<float>(type: "real", nullable: false),
                    klizeciStartZbir = table.Column<int>(type: "int", nullable: false),
                    skok = table.Column<float>(type: "real", nullable: false),
                    skokZbir = table.Column<int>(type: "int", nullable: false),
                    odbrana = table.Column<float>(type: "real", nullable: false),
                    odbranaZbir = table.Column<int>(type: "int", nullable: false),
                    zbirOcjena = table.Column<float>(type: "real", nullable: false),
                    prosjekOcjena = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_igracSkills", x => x.igracSkillsId);
                });

            migrationBuilder.CreateTable(
                name: "igracStatistika",
                columns: table => new
                {
                    igracStatistikaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brojNastupa = table.Column<int>(type: "int", nullable: false),
                    golovi = table.Column<int>(type: "int", nullable: false),
                    asistencije = table.Column<int>(type: "int", nullable: false),
                    zutiKartoni = table.Column<int>(type: "int", nullable: false),
                    crveniKartoni = table.Column<int>(type: "int", nullable: false),
                    zbirOcjena = table.Column<int>(type: "int", nullable: false),
                    prosjecnaOcjena = table.Column<float>(type: "real", nullable: false),
                    igracId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_igracStatistika", x => x.igracStatistikaId);
                });

            migrationBuilder.CreateTable(
                name: "korisnici",
                columns: table => new
                {
                    korisnikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    korisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lozinkaHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lozinkaSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    drzavljanstvoId = table.Column<int>(type: "int", nullable: false),
                    gradRodjenjaId = table.Column<int>(type: "int", nullable: false),
                    igracId = table.Column<int>(type: "int", nullable: false),
                    isIgrac = table.Column<bool>(type: "bit", nullable: false),
                    isTrener = table.Column<bool>(type: "bit", nullable: false),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_korisnici", x => x.korisnikId);
                    table.ForeignKey(
                        name: "FK_korisnici_drzave_drzavljanstvoId",
                        column: x => x.drzavljanstvoId,
                        principalTable: "drzave",
                        principalColumn: "drzavaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_korisnici_gradovi_gradRodjenjaId",
                        column: x => x.gradRodjenjaId,
                        principalTable: "gradovi",
                        principalColumn: "gradId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ugovori",
                columns: table => new
                {
                    ugovorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumPocetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    datumZavrsetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    iznosPlate = table.Column<float>(type: "real", nullable: false),
                    igracId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ugovori", x => x.ugovorId);
                });

            migrationBuilder.CreateTable(
                name: "igraci",
                columns: table => new
                {
                    igracId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visina = table.Column<float>(type: "real", nullable: false),
                    tezina = table.Column<int>(type: "int", nullable: false),
                    brojDresa = table.Column<int>(type: "int", nullable: false),
                    trzisnaVrijednost = table.Column<float>(type: "real", nullable: false),
                    slika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datumPristupaKlubu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pozicija = table.Column<int>(type: "int", nullable: false),
                    boljaNoga = table.Column<int>(type: "int", nullable: false),
                    igracStatistikaId = table.Column<int>(type: "int", nullable: false),
                    igracSkillsId = table.Column<int>(type: "int", nullable: false),
                    ugovorId = table.Column<int>(type: "int", nullable: false),
                    korisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_igraci", x => x.igracId);
                    table.ForeignKey(
                        name: "FK_igraci_igracSkills_igracSkillsId",
                        column: x => x.igracSkillsId,
                        principalTable: "igracSkills",
                        principalColumn: "igracSkillsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_igraci_igracStatistika_igracStatistikaId",
                        column: x => x.igracStatistikaId,
                        principalTable: "igracStatistika",
                        principalColumn: "igracStatistikaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_igraci_korisnici_korisnikId",
                        column: x => x.korisnikId,
                        principalTable: "korisnici",
                        principalColumn: "korisnikId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_igraci_ugovori_ugovorId",
                        column: x => x.ugovorId,
                        principalTable: "ugovori",
                        principalColumn: "ugovorId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_igraci_igracSkillsId",
                table: "igraci",
                column: "igracSkillsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_igraci_igracStatistikaId",
                table: "igraci",
                column: "igracStatistikaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_igraci_korisnikId",
                table: "igraci",
                column: "korisnikId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_igraci_ugovorId",
                table: "igraci",
                column: "ugovorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_korisnici_drzavljanstvoId",
                table: "korisnici",
                column: "drzavljanstvoId");

            migrationBuilder.CreateIndex(
                name: "IX_korisnici_gradRodjenjaId",
                table: "korisnici",
                column: "gradRodjenjaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "igraci");

            migrationBuilder.DropTable(
                name: "igracSkills");

            migrationBuilder.DropTable(
                name: "igracStatistika");

            migrationBuilder.DropTable(
                name: "korisnici");

            migrationBuilder.DropTable(
                name: "ugovori");
        }
    }
}
