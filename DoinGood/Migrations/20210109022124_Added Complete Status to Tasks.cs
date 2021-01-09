using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Migrations
{
    public partial class AddedCompleteStatustoTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0810ffcd-4f82-4c1a-867c-2be627bb2b5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43d0827a-2567-49f1-92b5-924e9f24c299");

            migrationBuilder.AddColumn<bool>(
                name: "PosterComplete",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TaskerComplete",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8089f6dc-5cc9-45af-864e-c0f50c4d82d0", "2152a6e6-41ee-42a3-8f3a-b5696ad3d108", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13181694-4ecf-49cb-a5d5-a7f38a19cc43", "2155e08d-fb8a-487f-a886-c5290be6e2ea", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13181694-4ecf-49cb-a5d5-a7f38a19cc43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8089f6dc-5cc9-45af-864e-c0f50c4d82d0");

            migrationBuilder.DropColumn(
                name: "PosterComplete",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskerComplete",
                table: "Tasks");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0810ffcd-4f82-4c1a-867c-2be627bb2b5e", "30830841-5271-48de-a2e7-70e6b63c3b93", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43d0827a-2567-49f1-92b5-924e9f24c299", "9fe52b7e-5b39-49ae-a0b6-7d102d92239a", "Admin", "ADMIN" });
        }
    }
}
