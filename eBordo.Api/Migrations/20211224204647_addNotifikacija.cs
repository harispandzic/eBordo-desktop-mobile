using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addNotifikacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "notifikacije",
                columns: table => new
                {
                    notifikacijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tekstNotifikacije = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datumNotifikacije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    statusNotifikacije = table.Column<int>(type: "int", nullable: false),
                    tipNotifikacije = table.Column<int>(type: "int", nullable: false),
                    korisnikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notifikacije", x => x.notifikacijaId);
                    table.ForeignKey(
                        name: "FK_notifikacije_korisnici_korisnikId",
                        column: x => x.korisnikId,
                        principalTable: "korisnici",
                        principalColumn: "korisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_notifikacije_korisnikId",
                table: "notifikacije",
                column: "korisnikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "notifikacije");
        }
    }
}
