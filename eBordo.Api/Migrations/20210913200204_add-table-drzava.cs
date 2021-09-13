using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addtabledrzava : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "drzave",
                columns: table => new
                {
                    drzavaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivDrzave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zastavaUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drzave", x => x.drzavaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "drzave");
        }
    }
}
