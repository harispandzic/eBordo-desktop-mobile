using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addattributejacinSlabijeNogedeletesomeattributesfromigractable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "datumPristupaKlubu",
                table: "igraci");

            migrationBuilder.RenameColumn(
                name: "slika",
                table: "igraci",
                newName: "napomeneOIgracu");

            migrationBuilder.AddColumn<int>(
                name: "jacinaSlabijeNoge",
                table: "igraci",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "jacinaSlabijeNoge",
                table: "igraci");

            migrationBuilder.RenameColumn(
                name: "napomeneOIgracu",
                table: "igraci",
                newName: "slika");

            migrationBuilder.AddColumn<DateTime>(
                name: "datumPristupaKlubu",
                table: "igraci",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
