using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class db_init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "drzave",
                columns: table => new
                {
                    drzavaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivDrzave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zastava = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drzave", x => x.drzavaId);
                });

            migrationBuilder.CreateTable(
                name: "formacije",
                columns: table => new
                {
                    formacijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivFormacije = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formacije", x => x.formacijaId);
                });

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
                name: "pozicije",
                columns: table => new
                {
                    pozicijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivPozicije = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    skracenica = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pozicije", x => x.pozicijaId);
                });

            migrationBuilder.CreateTable(
                name: "takmicenje",
                columns: table => new
                {
                    takmicenjeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivTakmicenja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_takmicenje", x => x.takmicenjeId);
                });

            migrationBuilder.CreateTable(
                name: "trenerskeLicence",
                columns: table => new
                {
                    trenerskaLicencaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivLicence = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trenerskeLicence", x => x.trenerskaLicencaId);
                });

            migrationBuilder.CreateTable(
                name: "trenerStatistika",
                columns: table => new
                {
                    trenerStatistikaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brojUtakmica = table.Column<int>(type: "int", nullable: false),
                    brojPobjeda = table.Column<int>(type: "int", nullable: false),
                    brojNerjesenih = table.Column<int>(type: "int", nullable: false),
                    brojPoraza = table.Column<int>(type: "int", nullable: false),
                    trenerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trenerStatistika", x => x.trenerStatistikaID);
                });

            migrationBuilder.CreateTable(
                name: "ugovori",
                columns: table => new
                {
                    ugovorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumPocetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    datumZavrsetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    igracId = table.Column<int>(type: "int", nullable: true),
                    trenerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ugovori", x => x.ugovorId);
                });

            migrationBuilder.CreateTable(
                name: "gradovi",
                columns: table => new
                {
                    gradId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivGrada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    drzavaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gradovi", x => x.gradId);
                    table.ForeignKey(
                        name: "FK_gradovi_drzave_drzavaId",
                        column: x => x.drzavaId,
                        principalTable: "drzave",
                        principalColumn: "drzavaId",
                        onDelete: ReferentialAction.NoAction);
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
                    isAktivan = table.Column<bool>(type: "bit", nullable: false),
                    drzavljanstvoId = table.Column<int>(type: "int", nullable: false),
                    gradRodjenjaId = table.Column<int>(type: "int", nullable: false),
                    igracId = table.Column<int>(type: "int", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    trenerID = table.Column<int>(type: "int", nullable: false),
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
                name: "stadioni",
                columns: table => new
                {
                    stadionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivStadiona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lokacijaStadionaId = table.Column<int>(type: "int", nullable: false),
                    slikaStadiona = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stadioni", x => x.stadionId);
                    table.ForeignKey(
                        name: "FK_stadioni_gradovi_lokacijaStadionaId",
                        column: x => x.lokacijaStadionaId,
                        principalTable: "gradovi",
                        principalColumn: "gradId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "igraci",
                columns: table => new
                {
                    igracId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisnikId = table.Column<int>(type: "int", nullable: false),
                    visina = table.Column<float>(type: "real", nullable: false),
                    tezina = table.Column<int>(type: "int", nullable: false),
                    brojDresa = table.Column<int>(type: "int", nullable: false),
                    trzisnaVrijednost = table.Column<float>(type: "real", nullable: false),
                    jacinaSlabijeNoge = table.Column<int>(type: "int", nullable: false),
                    napomeneOIgracu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pozicijaId = table.Column<int>(type: "int", nullable: false),
                    boljaNoga = table.Column<int>(type: "int", nullable: false),
                    igracStatistikaId = table.Column<int>(type: "int", nullable: false),
                    igracSkillsId = table.Column<int>(type: "int", nullable: false),
                    ugovorId = table.Column<int>(type: "int", nullable: false),
                    slikaPanel = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_igraci", x => x.igracId);
                    table.ForeignKey(
                        name: "FK_igraci_igracSkills_igracSkillsId",
                        column: x => x.igracSkillsId,
                        principalTable: "igracSkills",
                        principalColumn: "igracSkillsId",
                        onDelete: ReferentialAction.NoAction);
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
                        name: "FK_igraci_pozicije_pozicijaId",
                        column: x => x.pozicijaId,
                        principalTable: "pozicije",
                        principalColumn: "pozicijaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_igraci_ugovori_ugovorId",
                        column: x => x.ugovorId,
                        principalTable: "ugovori",
                        principalColumn: "ugovorId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "notifikacije",
                columns: table => new
                {
                    notifikacijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisnikId = table.Column<int>(type: "int", nullable: false),
                    tekstNotifikacije = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datumNotifikacije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    statusNotifikacije = table.Column<int>(type: "int", nullable: false),
                    tipNotifikacije = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notifikacije", x => x.notifikacijaId);
                    table.ForeignKey(
                        name: "FK_notifikacije_korisnici_korisnikId",
                        column: x => x.korisnikId,
                        principalTable: "korisnici",
                        principalColumn: "korisnikId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "treneri",
                columns: table => new
                {
                    trenerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trenerStatistikaId = table.Column<int>(type: "int", nullable: false),
                    ugovorId = table.Column<int>(type: "int", nullable: false),
                    korisnikId = table.Column<int>(type: "int", nullable: false),
                    formacijaId = table.Column<int>(type: "int", nullable: false),
                    trenerskaLicencaId = table.Column<int>(type: "int", nullable: false),
                    ulogaTrenera = table.Column<int>(type: "int", nullable: false),
                    slikaPanel = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treneri", x => x.trenerId);
                    table.ForeignKey(
                        name: "FK_treneri_formacije_formacijaId",
                        column: x => x.formacijaId,
                        principalTable: "formacije",
                        principalColumn: "formacijaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_treneri_korisnici_korisnikId",
                        column: x => x.korisnikId,
                        principalTable: "korisnici",
                        principalColumn: "korisnikId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_treneri_trenerskeLicence_trenerskaLicencaId",
                        column: x => x.trenerskaLicencaId,
                        principalTable: "trenerskeLicence",
                        principalColumn: "trenerskaLicencaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_treneri_trenerStatistika_trenerStatistikaId",
                        column: x => x.trenerStatistikaId,
                        principalTable: "trenerStatistika",
                        principalColumn: "trenerStatistikaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_treneri_ugovori_ugovorId",
                        column: x => x.ugovorId,
                        principalTable: "ugovori",
                        principalColumn: "ugovorId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "klubovi",
                columns: table => new
                {
                    klubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivKluba = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gradId = table.Column<int>(type: "int", nullable: false),
                    stadionId = table.Column<int>(type: "int", nullable: false),
                    grb = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_klubovi", x => x.klubId);
                    table.ForeignKey(
                        name: "FK_klubovi_gradovi_gradId",
                        column: x => x.gradId,
                        principalTable: "gradovi",
                        principalColumn: "gradId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_klubovi_stadioni_stadionId",
                        column: x => x.stadionId,
                        principalTable: "stadioni",
                        principalColumn: "stadionId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "trening",
                columns: table => new
                {
                    treningID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumOdrzavanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    satnica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lokacija = table.Column<int>(type: "int", nullable: false),
                    fokusTreninga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isOdradjen = table.Column<bool>(type: "bit", nullable: false),
                    zabiljezioID = table.Column<int>(type: "int", nullable: false),
                    trajanje = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trening", x => x.treningID);
                    table.ForeignKey(
                        name: "FK_trening_treneri_zabiljezioID",
                        column: x => x.zabiljezioID,
                        principalTable: "treneri",
                        principalColumn: "trenerId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "utakmice",
                columns: table => new
                {
                    utakmicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumOdigravanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    satnica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sudija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stadionId = table.Column<int>(type: "int", nullable: false),
                    opisUtakmice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    napomene = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    takmicenjeId = table.Column<int>(type: "int", nullable: false),
                    kapitenId = table.Column<int>(type: "int", nullable: false),
                    trenerId = table.Column<int>(type: "int", nullable: false),
                    protivnikId = table.Column<int>(type: "int", nullable: false),
                    tipGarniture = table.Column<int>(type: "int", nullable: false),
                    vrstaUtakmice = table.Column<int>(type: "int", nullable: false),
                    odigrana = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utakmice", x => x.utakmicaId);
                    table.ForeignKey(
                        name: "FK_utakmice_igraci_kapitenId",
                        column: x => x.kapitenId,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmice_klubovi_protivnikId",
                        column: x => x.protivnikId,
                        principalTable: "klubovi",
                        principalColumn: "klubId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmice_stadioni_stadionId",
                        column: x => x.stadionId,
                        principalTable: "stadioni",
                        principalColumn: "stadionId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmice_takmicenje_takmicenjeId",
                        column: x => x.takmicenjeId,
                        principalTable: "takmicenje",
                        principalColumn: "takmicenjeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmice_treneri_trenerId",
                        column: x => x.trenerId,
                        principalTable: "treneri",
                        principalColumn: "trenerId",
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
                name: "utakmicaSastav",
                columns: table => new
                {
                    utakmicaSastavId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    igracId = table.Column<int>(type: "int", nullable: false),
                    utakmicaId = table.Column<int>(type: "int", nullable: true),
                    pozicijaId = table.Column<int>(type: "int", nullable: false),
                    uloga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utakmicaSastav", x => x.utakmicaSastavId);
                    table.ForeignKey(
                        name: "FK_utakmicaSastav_igraci_igracId",
                        column: x => x.igracId,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmicaSastav_pozicije_pozicijaId",
                        column: x => x.pozicijaId,
                        principalTable: "pozicije",
                        principalColumn: "pozicijaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmicaSastav_utakmice_utakmicaId",
                        column: x => x.utakmicaId,
                        principalTable: "utakmice",
                        principalColumn: "utakmicaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "utakmicaIzmjena",
                columns: table => new
                {
                    utakmicaIzmjenaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    utakmicaId = table.Column<int>(type: "int", nullable: false),
                    igracOutId = table.Column<int>(type: "int", nullable: false),
                    igracInId = table.Column<int>(type: "int", nullable: false),
                    minuta = table.Column<int>(type: "int", nullable: false),
                    izmjenaRazlog = table.Column<int>(type: "int", nullable: false),
                    izvještajId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utakmicaIzmjena", x => x.utakmicaIzmjenaID);
                    table.ForeignKey(
                        name: "FK_utakmicaIzmjena_igraci_igracInId",
                        column: x => x.igracInId,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmicaIzmjena_igraci_igracOutId",
                        column: x => x.igracOutId,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmicaIzmjena_izvještaj_izvještajId",
                        column: x => x.izvještajId,
                        principalTable: "izvještaj",
                        principalColumn: "izvještajId",
                        onDelete: ReferentialAction.Restrict);
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
                    utakmicaId = table.Column<int>(type: "int", nullable: false),
                    minute = table.Column<int>(type: "int", nullable: false),
                    golovi = table.Column<int>(type: "int", nullable: false),
                    asistencije = table.Column<int>(type: "int", nullable: false),
                    zutiKartoni = table.Column<int>(type: "int", nullable: false),
                    crveniKartoni = table.Column<int>(type: "int", nullable: false),
                    ocjena = table.Column<int>(type: "int", nullable: false),
                    komentar = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_utakmicaNastup_treneri_trenerId",
                        column: x => x.trenerId,
                        principalTable: "treneri",
                        principalColumn: "trenerId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_utakmicaNastup_utakmice_utakmicaId",
                        column: x => x.utakmicaId,
                        principalTable: "utakmice",
                        principalColumn: "utakmicaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_gradovi_drzavaId",
                table: "gradovi",
                column: "drzavaId");

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
                name: "IX_igraci_pozicijaId",
                table: "igraci",
                column: "pozicijaId");

            migrationBuilder.CreateIndex(
                name: "IX_igraci_ugovorId",
                table: "igraci",
                column: "ugovorId",
                unique: true);

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
                name: "IX_klubovi_gradId",
                table: "klubovi",
                column: "gradId");

            migrationBuilder.CreateIndex(
                name: "IX_klubovi_stadionId",
                table: "klubovi",
                column: "stadionId");

            migrationBuilder.CreateIndex(
                name: "IX_korisnici_drzavljanstvoId",
                table: "korisnici",
                column: "drzavljanstvoId");

            migrationBuilder.CreateIndex(
                name: "IX_korisnici_gradRodjenjaId",
                table: "korisnici",
                column: "gradRodjenjaId");

            migrationBuilder.CreateIndex(
                name: "IX_notifikacije_korisnikId",
                table: "notifikacije",
                column: "korisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_stadioni_lokacijaStadionaId",
                table: "stadioni",
                column: "lokacijaStadionaId");

            migrationBuilder.CreateIndex(
                name: "IX_treneri_formacijaId",
                table: "treneri",
                column: "formacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_treneri_korisnikId",
                table: "treneri",
                column: "korisnikId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_treneri_trenerskaLicencaId",
                table: "treneri",
                column: "trenerskaLicencaId");

            migrationBuilder.CreateIndex(
                name: "IX_treneri_trenerStatistikaId",
                table: "treneri",
                column: "trenerStatistikaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_treneri_ugovorId",
                table: "treneri",
                column: "ugovorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_trening_zabiljezioID",
                table: "trening",
                column: "zabiljezioID");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaIzmjena_igracInId",
                table: "utakmicaIzmjena",
                column: "igracInId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaIzmjena_igracOutId",
                table: "utakmicaIzmjena",
                column: "igracOutId");

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
                name: "IX_utakmicaNastup_utakmicaId",
                table: "utakmicaNastup",
                column: "utakmicaId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaSastav_igracId",
                table: "utakmicaSastav",
                column: "igracId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaSastav_pozicijaId",
                table: "utakmicaSastav",
                column: "pozicijaId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaSastav_utakmicaId",
                table: "utakmicaSastav",
                column: "utakmicaId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmice_kapitenId",
                table: "utakmice",
                column: "kapitenId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmice_protivnikId",
                table: "utakmice",
                column: "protivnikId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmice_stadionId",
                table: "utakmice",
                column: "stadionId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmice_takmicenjeId",
                table: "utakmice",
                column: "takmicenjeId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmice_trenerId",
                table: "utakmice",
                column: "trenerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "notifikacije");

            migrationBuilder.DropTable(
                name: "trening");

            migrationBuilder.DropTable(
                name: "utakmicaIzmjena");

            migrationBuilder.DropTable(
                name: "utakmicaNastup");

            migrationBuilder.DropTable(
                name: "utakmicaSastav");

            migrationBuilder.DropTable(
                name: "izvještaj");

            migrationBuilder.DropTable(
                name: "utakmice");

            migrationBuilder.DropTable(
                name: "igraci");

            migrationBuilder.DropTable(
                name: "klubovi");

            migrationBuilder.DropTable(
                name: "takmicenje");

            migrationBuilder.DropTable(
                name: "treneri");

            migrationBuilder.DropTable(
                name: "igracSkills");

            migrationBuilder.DropTable(
                name: "igracStatistika");

            migrationBuilder.DropTable(
                name: "pozicije");

            migrationBuilder.DropTable(
                name: "stadioni");

            migrationBuilder.DropTable(
                name: "formacije");

            migrationBuilder.DropTable(
                name: "korisnici");

            migrationBuilder.DropTable(
                name: "trenerskeLicence");

            migrationBuilder.DropTable(
                name: "trenerStatistika");

            migrationBuilder.DropTable(
                name: "ugovori");

            migrationBuilder.DropTable(
                name: "gradovi");

            migrationBuilder.DropTable(
                name: "drzave");
        }
    }
}
