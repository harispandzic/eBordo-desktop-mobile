using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addTrening : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "trening",
                columns: table => new
                {
                    treningID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumOdrzavanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    satnica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lokacija = table.Column<int>(type: "int", nullable: false),
                    fokusTreninga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isOdradjen = table.Column<bool>(type: "bit", nullable: false),
                    zabiljezioID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trening", x => x.treningID);
                    table.ForeignKey(
                        name: "FK_trening_treneri_zabiljezioID",
                        column: x => x.zabiljezioID,
                        principalTable: "treneri",
                        principalColumn: "trenerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_trening_zabiljezioID",
                table: "trening",
                column: "zabiljezioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "trening");
        }
    }
}
