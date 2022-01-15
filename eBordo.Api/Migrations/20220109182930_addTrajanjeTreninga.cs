using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addTrajanjeTreninga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "trajanje",
                table: "trening",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "trajanje",
                table: "trening");
        }
    }
}
