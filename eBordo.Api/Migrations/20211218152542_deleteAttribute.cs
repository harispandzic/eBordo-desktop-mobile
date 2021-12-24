using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class deleteAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "brojGledalaca",
                table: "izvještaj");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "brojGledalaca",
                table: "izvještaj",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
