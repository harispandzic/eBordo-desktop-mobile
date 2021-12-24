using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addTrenerIdInUtakmicaOCjena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "trenerId",
                table: "utakmicaOcjena",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaOcjena_trenerId",
                table: "utakmicaOcjena",
                column: "trenerId");

            migrationBuilder.AddForeignKey(
                name: "FK_utakmicaOcjena_treneri_trenerId",
                table: "utakmicaOcjena",
                column: "trenerId",
                principalTable: "treneri",
                principalColumn: "trenerId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_utakmicaOcjena_treneri_trenerId",
                table: "utakmicaOcjena");

            migrationBuilder.DropIndex(
                name: "IX_utakmicaOcjena_trenerId",
                table: "utakmicaOcjena");

            migrationBuilder.DropColumn(
                name: "trenerId",
                table: "utakmicaOcjena");
        }
    }
}
