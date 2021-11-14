using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addZastava : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "zastavaUrl",
                table: "drzave");

            migrationBuilder.AddColumn<byte[]>(
                name: "zastava",
                table: "drzave",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "zastava",
                table: "drzave");

            migrationBuilder.AddColumn<string>(
                name: "zastavaUrl",
                table: "drzave",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
