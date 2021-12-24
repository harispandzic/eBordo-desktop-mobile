using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addUtakmicaInUtakmicaNastup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "utakmicaId",
                table: "utakmicaNastup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaNastup_utakmicaId",
                table: "utakmicaNastup",
                column: "utakmicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_utakmicaNastup_utakmice_utakmicaId",
                table: "utakmicaNastup",
                column: "utakmicaId",
                principalTable: "utakmice",
                principalColumn: "utakmicaId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_utakmicaNastup_utakmice_utakmicaId",
                table: "utakmicaNastup");

            migrationBuilder.DropIndex(
                name: "IX_utakmicaNastup_utakmicaId",
                table: "utakmicaNastup");

            migrationBuilder.DropColumn(
                name: "utakmicaId",
                table: "utakmicaNastup");
        }
    }
}
