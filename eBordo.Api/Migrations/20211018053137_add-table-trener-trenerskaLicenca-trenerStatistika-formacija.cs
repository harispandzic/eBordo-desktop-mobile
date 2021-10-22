using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addtabletrenertrenerskaLicencatrenerStatistikaformacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "trenerID",
                table: "ugovori",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "trenerID",
                table: "korisnici",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "treneri",
                columns: table => new
                {
                    trenerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prvaZvanicnaUtakmica = table.Column<DateTime>(type: "datetime2", nullable: false),
                    trzisnaVrijednost = table.Column<float>(type: "real", nullable: false),
                    trenerStatistikaId = table.Column<int>(type: "int", nullable: false),
                    ugovorId = table.Column<int>(type: "int", nullable: false),
                    korisnikId = table.Column<int>(type: "int", nullable: false),
                    formacijaId = table.Column<int>(type: "int", nullable: false),
                    trenerskaLicencaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treneri", x => x.trenerId);
                    table.ForeignKey(
                        name: "FK_treneri_formacije_formacijaId",
                        column: x => x.formacijaId,
                        principalTable: "formacije",
                        principalColumn: "formacijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_treneri_korisnici_korisnikId",
                        column: x => x.korisnikId,
                        principalTable: "korisnici",
                        principalColumn: "korisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_treneri_trenerskeLicence_trenerskaLicencaId",
                        column: x => x.trenerskaLicencaId,
                        principalTable: "trenerskeLicence",
                        principalColumn: "trenerskaLicencaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_treneri_trenerStatistika_trenerStatistikaId",
                        column: x => x.trenerStatistikaId,
                        principalTable: "trenerStatistika",
                        principalColumn: "trenerStatistikaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_treneri_ugovori_ugovorId",
                        column: x => x.ugovorId,
                        principalTable: "ugovori",
                        principalColumn: "ugovorId",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "treneri");

            migrationBuilder.DropTable(
                name: "formacije");

            migrationBuilder.DropTable(
                name: "trenerskeLicence");

            migrationBuilder.DropTable(
                name: "trenerStatistika");

            migrationBuilder.DropColumn(
                name: "trenerID",
                table: "ugovori");

            migrationBuilder.DropColumn(
                name: "trenerID",
                table: "korisnici");
        }
    }
}
