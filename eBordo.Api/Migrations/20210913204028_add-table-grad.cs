using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addtablegrad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gradovi",
                columns: table => new
                {
                    gradId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivGrada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    drzavaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gradovi", x => x.gradId);
                    table.ForeignKey(
                        name: "FK_gradovi_drzave_drzavaId",
                        column: x => x.drzavaId,
                        principalTable: "drzave",
                        principalColumn: "drzavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_gradovi_drzavaId",
                table: "gradovi",
                column: "drzavaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gradovi");
        }
    }
}
