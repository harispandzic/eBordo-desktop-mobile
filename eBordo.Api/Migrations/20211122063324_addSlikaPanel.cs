using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class addSlikaPanel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "slikaPanel",
                table: "treneri",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ulogaTrenera",
                table: "treneri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "slikaPanel",
                table: "igraci",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "slikaPanel",
                table: "treneri");

            migrationBuilder.DropColumn(
                name: "ulogaTrenera",
                table: "treneri");

            migrationBuilder.DropColumn(
                name: "slikaPanel",
                table: "igraci");
        }
    }
}
