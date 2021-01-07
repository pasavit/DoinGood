using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Migrations
{
    public partial class Changedlatandlngfromaddresstocatalyst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d3d98e3-93a8-4c81-8277-85c3840bb2c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "991d9ff7-6e7a-44bd-8a85-f06a523633d5");

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Lng",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "Lat",
                table: "Catalysts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Lng",
                table: "Catalysts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0440c994-8fba-48c9-818d-a47c4666ce78", "7ad97d5a-34e6-4661-844e-4bf07cc84bf1", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dceebc13-9363-43db-bef1-201c0b7a2c47", "d54842d7-b58a-44b1-9495-bd9a463e8f67", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0440c994-8fba-48c9-818d-a47c4666ce78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dceebc13-9363-43db-bef1-201c0b7a2c47");

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Catalysts");

            migrationBuilder.DropColumn(
                name: "Lng",
                table: "Catalysts");

            migrationBuilder.AddColumn<int>(
                name: "Lat",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Lng",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d3d98e3-93a8-4c81-8277-85c3840bb2c8", "0e8364e8-53b6-455f-85cd-51d62b69077f", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "991d9ff7-6e7a-44bd-8a85-f06a523633d5", "ed75868e-2409-4e35-8ab7-dd6f0d9d6641", "Admin", "ADMIN" });
        }
    }
}
