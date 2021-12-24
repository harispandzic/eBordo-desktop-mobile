using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class deletedIzmjena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_utakmicaIzmjena_izmjena_izmjenaId",
                table: "utakmicaIzmjena");

            migrationBuilder.DropTable(
                name: "izmjena");

            migrationBuilder.DropIndex(
                name: "IX_utakmicaIzmjena_izmjenaId",
                table: "utakmicaIzmjena");

            migrationBuilder.RenameColumn(
                name: "izmjenaId",
                table: "utakmicaIzmjena",
                newName: "minuta");

            migrationBuilder.AddColumn<int>(
                name: "igracInId",
                table: "utakmicaIzmjena",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "igracOutId",
                table: "utakmicaIzmjena",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "izmjenaRazlog",
                table: "utakmicaIzmjena",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaIzmjena_igracInId",
                table: "utakmicaIzmjena",
                column: "igracInId");

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaIzmjena_igracOutId",
                table: "utakmicaIzmjena",
                column: "igracOutId");

            migrationBuilder.AddForeignKey(
                name: "FK_utakmicaIzmjena_igraci_igracInId",
                table: "utakmicaIzmjena",
                column: "igracInId",
                principalTable: "igraci",
                principalColumn: "igracId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_utakmicaIzmjena_igraci_igracOutId",
                table: "utakmicaIzmjena",
                column: "igracOutId",
                principalTable: "igraci",
                principalColumn: "igracId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_utakmicaIzmjena_igraci_igracInId",
                table: "utakmicaIzmjena");

            migrationBuilder.DropForeignKey(
                name: "FK_utakmicaIzmjena_igraci_igracOutId",
                table: "utakmicaIzmjena");

            migrationBuilder.DropIndex(
                name: "IX_utakmicaIzmjena_igracInId",
                table: "utakmicaIzmjena");

            migrationBuilder.DropIndex(
                name: "IX_utakmicaIzmjena_igracOutId",
                table: "utakmicaIzmjena");

            migrationBuilder.DropColumn(
                name: "igracInId",
                table: "utakmicaIzmjena");

            migrationBuilder.DropColumn(
                name: "igracOutId",
                table: "utakmicaIzmjena");

            migrationBuilder.DropColumn(
                name: "izmjenaRazlog",
                table: "utakmicaIzmjena");

            migrationBuilder.RenameColumn(
                name: "minuta",
                table: "utakmicaIzmjena",
                newName: "izmjenaId");

            migrationBuilder.CreateTable(
                name: "izmjena",
                columns: table => new
                {
                    izmjenaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    igracInId = table.Column<int>(type: "int", nullable: false),
                    igracOutId = table.Column<int>(type: "int", nullable: false),
                    izmjenaRazlog = table.Column<int>(type: "int", nullable: false),
                    minuta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_izmjena", x => x.izmjenaId);
                    table.ForeignKey(
                        name: "FK_izmjena_igraci_igracInId",
                        column: x => x.igracInId,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_izmjena_igraci_igracOutId",
                        column: x => x.igracOutId,
                        principalTable: "igraci",
                        principalColumn: "igracId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_utakmicaIzmjena_izmjenaId",
                table: "utakmicaIzmjena",
                column: "izmjenaId");

            migrationBuilder.CreateIndex(
                name: "IX_izmjena_igracInId",
                table: "izmjena",
                column: "igracInId");

            migrationBuilder.CreateIndex(
                name: "IX_izmjena_igracOutId",
                table: "izmjena",
                column: "igracOutId");

            migrationBuilder.AddForeignKey(
                name: "FK_utakmicaIzmjena_izmjena_izmjenaId",
                table: "utakmicaIzmjena",
                column: "izmjenaId",
                principalTable: "izmjena",
                principalColumn: "izmjenaId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
