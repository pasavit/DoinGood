using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Migrations
{
    public partial class updateneeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "527225dc-db30-41ff-8b72-008aea72e009");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c933095-5e65-4193-8c47-132f90898acc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e27196eb-19d9-4585-9fa9-d1f374c4ff39", "38bb2c0a-d5f8-4c4e-8bf6-5aba52d331e0", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "436a8084-1ef5-4752-aa29-bb8addee25aa", "2a32e4ef-0d5e-4ea2-a312-2c98dd8c10df", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "527225dc-db30-41ff-8b72-008aea72e009", "55c0dbf5-a0a7-4028-9709-de659d3c5b31", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c933095-5e65-4193-8c47-132f90898acc", "ce6c4fe3-a3de-49eb-a68e-e525ed34f882", "Admin", "ADMIN" });
        }
    }
}
