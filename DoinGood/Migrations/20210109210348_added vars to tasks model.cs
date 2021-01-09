using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Migrations
{
    public partial class addedvarstotasksmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a73003ae-f386-4351-ad58-246cebc08a23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d08bc2-b3e9-44da-b88b-c3aa2f22e5c5");

            migrationBuilder.AddColumn<int>(
                name: "PosterValue",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaskerFundId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskerValue",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AccountBalance",
                table: "Catalysts",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "527225dc-db30-41ff-8b72-008aea72e009", "55c0dbf5-a0a7-4028-9709-de659d3c5b31", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c933095-5e65-4193-8c47-132f90898acc", "ce6c4fe3-a3de-49eb-a68e-e525ed34f882", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskerFundId",
                table: "Tasks",
                column: "TaskerFundId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Fund_TaskerFundId",
                table: "Tasks",
                column: "TaskerFundId",
                principalTable: "Fund",
                principalColumn: "FundId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Fund_TaskerFundId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TaskerFundId",
                table: "Tasks");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "527225dc-db30-41ff-8b72-008aea72e009");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c933095-5e65-4193-8c47-132f90898acc");

            migrationBuilder.DropColumn(
                name: "PosterValue",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskerFundId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskerValue",
                table: "Tasks");

            migrationBuilder.AlterColumn<double>(
                name: "AccountBalance",
                table: "Catalysts",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2d08bc2-b3e9-44da-b88b-c3aa2f22e5c5", "250c07d9-986a-42ee-8d9d-d1be74d43bfd", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a73003ae-f386-4351-ad58-246cebc08a23", "c6b0de75-4741-4786-b6b8-4981665a735b", "Admin", "ADMIN" });
        }
    }
}
