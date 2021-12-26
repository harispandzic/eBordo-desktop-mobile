using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class updateNotifikacijaWithKorisnik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_notifikacije_korisnikId",
                table: "notifikacije",
                column: "korisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_notifikacije_korisnici_korisnikId",
                table: "notifikacije",
                column: "korisnikId",
                principalTable: "korisnici",
                principalColumn: "korisnikId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_notifikacije_korisnici_korisnikId",
                table: "notifikacije");

            migrationBuilder.DropIndex(
                name: "IX_notifikacije_korisnikId",
                table: "notifikacije");
        }
    }
}
