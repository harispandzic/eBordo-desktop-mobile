using Microsoft.EntityFrameworkCore.Migrations;

namespace eBordo.Api.Migrations
{
    public partial class db_seed_grad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "gradovi",
                columns: new[] { "gradId", "drzavaId", "nazivGrada" },
                values: new object[,]
                {
                    { 1, 1, "Sarajevo" },
                    { 21, 11, "Bijelo Polje" },
                    { 20, 1, "Travnik" },
                    { 19, 9, "London" },
                    { 18, 4, "Dubrovnik" },
                    { 17, 4, "Split" },
                    { 16, 5, "Struga" },
                    { 15, 1, "Konjic" },
                    { 14, 10, "Wien" },
                    { 13, 1, "Sanski Most" },
                    { 22, 4, "Sinj" },
                    { 12, 1, "Kasindo" },
                    { 10, 1, "Tešanj" },
                    { 9, 1, "Zenica" },
                    { 8, 9, "Manchester" },
                    { 7, 6, "Glasgow" },
                    { 6, 8, "Mönchengladbach" },
                    { 5, 2, "Istanbul" },
                    { 4, 3, "Bergamo" },
                    { 3, 1, "Tuzla" },
                    { 2, 1, "Mostar" },
                    { 11, 7, "Smederevska Palanka" },
                    { 23, 1, "Stolac" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "gradovi",
                keyColumn: "gradId",
                keyValue: 23);
        }
    }
}
