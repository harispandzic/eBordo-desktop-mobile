using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class removeprvaZvanicnaUtakmicatrzisnaVrijednostattributesfromtrener : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prvaZvanicnaUtakmica",
                table: "treneri");

            migrationBuilder.DropColumn(
                name: "trzisnaVrijednost",
                table: "treneri");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "prvaZvanicnaUtakmica",
                table: "treneri",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "trzisnaVrijednost",
                table: "treneri",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
