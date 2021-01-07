using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Migrations
{
    public partial class changedlatandlngfrominttodbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0440c994-8fba-48c9-818d-a47c4666ce78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dceebc13-9363-43db-bef1-201c0b7a2c47");

            migrationBuilder.AlterColumn<double>(
                name: "Lng",
                table: "Catalysts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Lat",
                table: "Catalysts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "181a8672-3549-4568-905d-e174a45b3f5d", "bb7083af-8bc2-427e-b736-22d6a1ccc3a0", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bdc3d7b2-7b34-4ded-b572-536283867a02", "b9e34f56-48c3-4bb4-97c5-53b7b5d6e827", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "181a8672-3549-4568-905d-e174a45b3f5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdc3d7b2-7b34-4ded-b572-536283867a02");

            migrationBuilder.AlterColumn<int>(
                name: "Lng",
                table: "Catalysts",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Lat",
                table: "Catalysts",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0440c994-8fba-48c9-818d-a47c4666ce78", "7ad97d5a-34e6-4661-844e-4bf07cc84bf1", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dceebc13-9363-43db-bef1-201c0b7a2c47", "d54842d7-b58a-44b1-9495-bd9a463e8f67", "Admin", "ADMIN" });
        }
    }
}
