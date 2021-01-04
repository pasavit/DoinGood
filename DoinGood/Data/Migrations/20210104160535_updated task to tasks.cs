using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Data.Migrations
{
    public partial class updatedtasktotasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26771a78-88fa-407c-9323-23b6981f3b54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d53f4dc6-bac3-4915-888e-489af2c5ba4f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eaf6e10b-2622-44ab-836d-3cb82d0a0108", "c9320e56-679b-49c0-b7dc-96daaeba0f16", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "850859a7-8723-49d7-b988-9ac1e1f3ac76", "d617d6d3-bbe6-446b-9bcd-fcce702d5262", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "850859a7-8723-49d7-b988-9ac1e1f3ac76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaf6e10b-2622-44ab-836d-3cb82d0a0108");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d53f4dc6-bac3-4915-888e-489af2c5ba4f", "c1643a18-49ac-4e46-8d9d-4b6842920c12", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26771a78-88fa-407c-9323-23b6981f3b54", "7890dc05-c87f-4623-9a16-fb9d94dce947", "Admin", "ADMIN" });
        }
    }
}
