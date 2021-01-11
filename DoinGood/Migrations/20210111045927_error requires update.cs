using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Migrations
{
    public partial class errorrequiresupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "436a8084-1ef5-4752-aa29-bb8addee25aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e27196eb-19d9-4585-9fa9-d1f374c4ff39");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4546585-8735-43f4-bf5c-1e809ad5d326", "d6e7bf69-d2fd-454f-bb79-2bf09ce0e593", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d5b2429-9d1f-4b82-9faa-da8f8db8c7db", "ad3ee30e-87df-475a-a1dd-efda82ff2241", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d5b2429-9d1f-4b82-9faa-da8f8db8c7db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4546585-8735-43f4-bf5c-1e809ad5d326");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e27196eb-19d9-4585-9fa9-d1f374c4ff39", "38bb2c0a-d5f8-4c4e-8bf6-5aba52d331e0", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "436a8084-1ef5-4752-aa29-bb8addee25aa", "2a32e4ef-0d5e-4ea2-a312-2c98dd8c10df", "Admin", "ADMIN" });
        }
    }
}
