using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Migrations
{
    public partial class AddedAccountBalancetoCatalyst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13181694-4ecf-49cb-a5d5-a7f38a19cc43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8089f6dc-5cc9-45af-864e-c0f50c4d82d0");

            migrationBuilder.AddColumn<double>(
                name: "AccountBalance",
                table: "Catalysts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2d08bc2-b3e9-44da-b88b-c3aa2f22e5c5", "250c07d9-986a-42ee-8d9d-d1be74d43bfd", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a73003ae-f386-4351-ad58-246cebc08a23", "c6b0de75-4741-4786-b6b8-4981665a735b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a73003ae-f386-4351-ad58-246cebc08a23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d08bc2-b3e9-44da-b88b-c3aa2f22e5c5");

            migrationBuilder.DropColumn(
                name: "AccountBalance",
                table: "Catalysts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8089f6dc-5cc9-45af-864e-c0f50c4d82d0", "2152a6e6-41ee-42a3-8f3a-b5696ad3d108", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13181694-4ecf-49cb-a5d5-a7f38a19cc43", "2155e08d-fb8a-487f-a886-c5290be6e2ea", "Admin", "ADMIN" });
        }
    }
}
