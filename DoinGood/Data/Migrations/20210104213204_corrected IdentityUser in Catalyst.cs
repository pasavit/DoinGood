using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Data.Migrations
{
    public partial class correctedIdentityUserinCatalyst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "850859a7-8723-49d7-b988-9ac1e1f3ac76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaf6e10b-2622-44ab-836d-3cb82d0a0108");

            migrationBuilder.DropColumn(
                name: "IdentityUser",
                table: "Catalysts");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Catalysts",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "416b06e7-5fe2-4cc5-b276-3117977d958a", "81de818d-5e8b-4a6c-baaf-05cfe137aba5", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a59921c3-71aa-4d5a-ae11-754045fa0860", "b57ce98f-b0df-47b9-a875-336164b2ee6a", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Catalysts_IdentityUserId",
                table: "Catalysts",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalysts_AspNetUsers_IdentityUserId",
                table: "Catalysts",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalysts_AspNetUsers_IdentityUserId",
                table: "Catalysts");

            migrationBuilder.DropIndex(
                name: "IX_Catalysts_IdentityUserId",
                table: "Catalysts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "416b06e7-5fe2-4cc5-b276-3117977d958a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a59921c3-71aa-4d5a-ae11-754045fa0860");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Catalysts");

            migrationBuilder.AddColumn<int>(
                name: "IdentityUser",
                table: "Catalysts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eaf6e10b-2622-44ab-836d-3cb82d0a0108", "c9320e56-679b-49c0-b7dc-96daaeba0f16", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "850859a7-8723-49d7-b988-9ac1e1f3ac76", "d617d6d3-bbe6-446b-9bcd-fcce702d5262", "Admin", "ADMIN" });
        }
    }
}
