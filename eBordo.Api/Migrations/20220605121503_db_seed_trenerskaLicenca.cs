using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class db_seed_trenerskaLicenca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "trenerskeLicence",
                columns: new[] { "trenerskaLicencaId", "nazivLicence" },
                values: new object[] { 1, "UEFA A" });

            migrationBuilder.InsertData(
                table: "trenerskeLicence",
                columns: new[] { "trenerskaLicencaId", "nazivLicence" },
                values: new object[] { 2, "UEFA B" });

            migrationBuilder.InsertData(
                table: "trenerskeLicence",
                columns: new[] { "trenerskaLicencaId", "nazivLicence" },
                values: new object[] { 3, "UEFA PRO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "trenerskeLicence",
                keyColumn: "trenerskaLicencaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "trenerskeLicence",
                keyColumn: "trenerskaLicencaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "trenerskeLicence",
                keyColumn: "trenerskaLicencaId",
                keyValue: 3);
        }
    }
}
