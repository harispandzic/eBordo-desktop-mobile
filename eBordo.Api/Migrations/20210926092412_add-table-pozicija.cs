using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addtablepozicija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pozicija",
                table: "igraci",
                newName: "pozicijaId");

            migrationBuilder.CreateTable(
                name: "pozicije",
                columns: table => new
                {
                    pozicijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivPozicije = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pozicije", x => x.pozicijaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_igraci_pozicijaId",
                table: "igraci",
                column: "pozicijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_igraci_pozicije_pozicijaId",
                table: "igraci",
                column: "pozicijaId",
                principalTable: "pozicije",
                principalColumn: "pozicijaId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_igraci_pozicije_pozicijaId",
                table: "igraci");

            migrationBuilder.DropTable(
                name: "pozicije");

            migrationBuilder.DropIndex(
                name: "IX_igraci_pozicijaId",
                table: "igraci");

            migrationBuilder.RenameColumn(
                name: "pozicijaId",
                table: "igraci",
                newName: "pozicija");
        }
    }
}
