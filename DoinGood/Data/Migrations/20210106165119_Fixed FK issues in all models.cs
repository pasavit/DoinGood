using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Data.Migrations
{
    public partial class FixedFKissuesinallmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Challenges_Catalysts_CatalystId",
                table: "Challenges");

            migrationBuilder.DropIndex(
                name: "IX_Challenges_CatalystId",
                table: "Challenges");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "034d70cc-977e-4573-a74b-d70b5dd28496");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "640da779-94b2-41de-91d5-cb85642311a5");

            migrationBuilder.DropColumn(
                name: "CatalystId",
                table: "Challenges");

            migrationBuilder.AddColumn<int>(
                name: "PosterCatalystId",
                table: "Tasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaskerCatalystId",
                table: "Tasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DonorCatalystId",
                table: "Donations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PosterCatalystId",
                table: "Donations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChallengeCatalystId",
                table: "Challenges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b8f7a4e-61ff-407f-8223-5dd5449b2a84", "dd53b01d-c164-47ec-91ac-bdf6c7cd7620", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50540d5e-f5c4-496d-bc0f-0e806a2f5f98", "0ae3945f-67c9-4663-8f1f-a3ecbc23432e", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_PosterCatalystId",
                table: "Tasks",
                column: "PosterCatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskerCatalystId",
                table: "Tasks",
                column: "TaskerCatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonorCatalystId",
                table: "Donations",
                column: "DonorCatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_PosterCatalystId",
                table: "Donations",
                column: "PosterCatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_ChallengeCatalystId",
                table: "Challenges",
                column: "ChallengeCatalystId");

            migrationBuilder.AddForeignKey(
                name: "FK_Challenges_Catalysts_ChallengeCatalystId",
                table: "Challenges",
                column: "ChallengeCatalystId",
                principalTable: "Catalysts",
                principalColumn: "CatalystId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Catalysts_DonorCatalystId",
                table: "Donations",
                column: "DonorCatalystId",
                principalTable: "Catalysts",
                principalColumn: "CatalystId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Catalysts_PosterCatalystId",
                table: "Donations",
                column: "PosterCatalystId",
                principalTable: "Catalysts",
                principalColumn: "CatalystId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Catalysts_PosterCatalystId",
                table: "Tasks",
                column: "PosterCatalystId",
                principalTable: "Catalysts",
                principalColumn: "CatalystId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Catalysts_TaskerCatalystId",
                table: "Tasks",
                column: "TaskerCatalystId",
                principalTable: "Catalysts",
                principalColumn: "CatalystId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Challenges_Catalysts_ChallengeCatalystId",
                table: "Challenges");

            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Catalysts_DonorCatalystId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Catalysts_PosterCatalystId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Catalysts_PosterCatalystId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Catalysts_TaskerCatalystId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_PosterCatalystId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TaskerCatalystId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Donations_DonorCatalystId",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_PosterCatalystId",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Challenges_ChallengeCatalystId",
                table: "Challenges");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b8f7a4e-61ff-407f-8223-5dd5449b2a84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50540d5e-f5c4-496d-bc0f-0e806a2f5f98");

            migrationBuilder.DropColumn(
                name: "PosterCatalystId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskerCatalystId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "DonorCatalystId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "PosterCatalystId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "ChallengeCatalystId",
                table: "Challenges");

            migrationBuilder.AddColumn<int>(
                name: "CatalystId",
                table: "Challenges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "034d70cc-977e-4573-a74b-d70b5dd28496", "99b28934-3154-4a5c-8976-5e4ccc4f58f7", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "640da779-94b2-41de-91d5-cb85642311a5", "410150ec-f854-4df1-8152-9a9bfd5921de", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_CatalystId",
                table: "Challenges",
                column: "CatalystId");

            migrationBuilder.AddForeignKey(
                name: "FK_Challenges_Catalysts_CatalystId",
                table: "Challenges",
                column: "CatalystId",
                principalTable: "Catalysts",
                principalColumn: "CatalystId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
