using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class db_seed_pozicija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "pozicije",
                columns: new[] { "pozicijaId", "nazivPozicije", "skracenica" },
                values: new object[,]
                {
                    { 1, "Golman", "GK" },
                    { 2, "Štoper", "CB" },
                    { 3, "Lijevi bek", "LB" },
                    { 4, "Desni bek", "RB" },
                    { 5, "Zadnji vezni", "CDM" },
                    { 6, "Centralni vezni", "CM" },
                    { 7, "Prednji vezni", "CAM" },
                    { 8, "Lijevi vezni", "LM" },
                    { 9, "Desni vezni", "RM" },
                    { 10, "Lijevo krilo", "LW" },
                    { 11, "Desno krilo", "RW" },
                    { 12, "Napadač", "ST" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "pozicije",
                keyColumn: "pozicijaId",
                keyValue: 12);
        }
    }
}
