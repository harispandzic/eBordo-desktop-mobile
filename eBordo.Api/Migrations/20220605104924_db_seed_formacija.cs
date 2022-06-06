using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class db_seed_formacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "formacije",
                columns: new[] { "formacijaId", "nazivFormacije" },
                values: new object[,]
                {
                    { 1, "4-4-2" },
                    { 2, "4-4-3" },
                    { 3, "4-3-3" },
                    { 4, "4-2-3-1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "formacije",
                keyColumn: "formacijaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "formacije",
                keyColumn: "formacijaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "formacije",
                keyColumn: "formacijaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "formacije",
                keyColumn: "formacijaId",
                keyValue: 4);
        }
    }
}
