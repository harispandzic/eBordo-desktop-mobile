using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addTakmicenjeLogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "logoTakmicenja",
                table: "takmicenje");

            migrationBuilder.AddColumn<byte[]>(
                name: "logo",
                table: "takmicenje",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "logo",
                table: "takmicenje");

            migrationBuilder.AddColumn<string>(
                name: "logoTakmicenja",
                table: "takmicenje",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
