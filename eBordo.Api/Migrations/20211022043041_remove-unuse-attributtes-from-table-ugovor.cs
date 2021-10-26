using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class removeunuseattributtesfromtableugovor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "datumPotpisa",
                table: "ugovori");

            migrationBuilder.DropColumn(
                name: "iznosPlate",
                table: "ugovori");

            migrationBuilder.DropColumn(
                name: "napomene",
                table: "ugovori");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "datumPotpisa",
                table: "ugovori",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "iznosPlate",
                table: "ugovori",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "napomene",
                table: "ugovori",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
