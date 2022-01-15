using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addIsAktivan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAktivan",
                table: "korisnici",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAktivan",
                table: "korisnici");
        }
    }
}
