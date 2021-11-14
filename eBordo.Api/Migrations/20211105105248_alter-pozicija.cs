using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class alterpozicija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "skracenica",
                table: "formacije");

            migrationBuilder.AddColumn<string>(
                name: "skracenica",
                table: "pozicije",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "skracenica",
                table: "pozicije");

            migrationBuilder.AddColumn<string>(
                name: "skracenica",
                table: "formacije",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
