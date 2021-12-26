using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class updateNotifikacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_notifikacije_korisnici_korisnikId",
                table: "notifikacije");

            migrationBuilder.DropIndex(
                name: "IX_notifikacije_korisnikId",
                table: "notifikacije");

            migrationBuilder.AlterColumn<int>(
                name: "korisnikId",
                table: "notifikacije",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "korisnikId",
                table: "notifikacije",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
