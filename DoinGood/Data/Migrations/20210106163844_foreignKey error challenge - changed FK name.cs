using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Data.Migrations
{
    public partial class foreignKeyerrorchallengechangedFKname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "416b06e7-5fe2-4cc5-b276-3117977d958a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a59921c3-71aa-4d5a-ae11-754045fa0860");

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

            migrationBuilder.AddColumn<int>(
                name: "DeservingCauseDerservingCauseId",
                table: "Donations",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "034d70cc-977e-4573-a74b-d70b5dd28496", "99b28934-3154-4a5c-8976-5e4ccc4f58f7", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "640da779-94b2-41de-91d5-cb85642311a5", "410150ec-f854-4df1-8152-9a9bfd5921de", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_DerservingCauseId",
                table: "Tasks",
                column: "DerservingCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_AddressId",
                table: "Donations",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DeservingCauseDerservingCauseId",
                table: "Donations",
                column: "DeservingCauseDerservingCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_Deeds_CatalystId",
                table: "Deeds",
                column: "CatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Deeds_DeservingCauseId",
                table: "Deeds",
                column: "DeservingCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_CatalystId",
                table: "Challenges",
                column: "CatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_DeedCatalystId",
                table: "Challenges",
                column: "DeedCatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_DeservingCauseId",
                table: "Challenges",
                column: "DeservingCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalysts_AddressId",
                table: "Catalysts",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalysts_Addresses_AddressId",
                table: "Catalysts",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Challenges_Catalysts_CatalystId",
                table: "Challenges",
                column: "CatalystId",
                principalTable: "Catalysts",
                principalColumn: "CatalystId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Challenges_Catalysts_DeedCatalystId",
                table: "Challenges",
                column: "DeedCatalystId",
                principalTable: "Catalysts",
                principalColumn: "CatalystId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Challenges_DeservingCauses_DeservingCauseId",
                table: "Challenges",
                column: "DeservingCauseId",
                principalTable: "DeservingCauses",
                principalColumn: "DerservingCauseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deeds_Catalysts_CatalystId",
                table: "Deeds",
                column: "CatalystId",
                principalTable: "Catalysts",
                principalColumn: "CatalystId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deeds_DeservingCauses_DeservingCauseId",
                table: "Deeds",
                column: "DeservingCauseId",
                principalTable: "DeservingCauses",
                principalColumn: "DerservingCauseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Addresses_AddressId",
                table: "Donations",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_DeservingCauses_DeservingCauseDerservingCauseId",
                table: "Donations",
                column: "DeservingCauseDerservingCauseId",
                principalTable: "DeservingCauses",
                principalColumn: "DerservingCauseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_DeservingCauses_DerservingCauseId",
                table: "Tasks",
                column: "DerservingCauseId",
                principalTable: "DeservingCauses",
                principalColumn: "DerservingCauseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalysts_Addresses_AddressId",
                table: "Catalysts");

            migrationBuilder.DropForeignKey(
                name: "FK_Challenges_Catalysts_CatalystId",
                table: "Challenges");

            migrationBuilder.DropForeignKey(
                name: "FK_Challenges_Catalysts_DeedCatalystId",
                table: "Challenges");

            migrationBuilder.DropForeignKey(
                name: "FK_Challenges_DeservingCauses_DeservingCauseId",
                table: "Challenges");

            migrationBuilder.DropForeignKey(
                name: "FK_Deeds_Catalysts_CatalystId",
                table: "Deeds");

            migrationBuilder.DropForeignKey(
                name: "FK_Deeds_DeservingCauses_DeservingCauseId",
                table: "Deeds");

            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Addresses_AddressId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_Donations_DeservingCauses_DeservingCauseDerservingCauseId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_DeservingCauses_DerservingCauseId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_DerservingCauseId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Donations_AddressId",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_DeservingCauseDerservingCauseId",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Deeds_CatalystId",
                table: "Deeds");

            migrationBuilder.DropIndex(
                name: "IX_Deeds_DeservingCauseId",
                table: "Deeds");

            migrationBuilder.DropIndex(
                name: "IX_Challenges_CatalystId",
                table: "Challenges");

            migrationBuilder.DropIndex(
                name: "IX_Challenges_DeedCatalystId",
                table: "Challenges");

            migrationBuilder.DropIndex(
                name: "IX_Challenges_DeservingCauseId",
                table: "Challenges");

            migrationBuilder.DropIndex(
                name: "IX_Catalysts_AddressId",
                table: "Catalysts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "034d70cc-977e-4573-a74b-d70b5dd28496");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "640da779-94b2-41de-91d5-cb85642311a5");

            migrationBuilder.DropColumn(
                name: "DeservingCauseDerservingCauseId",
                table: "Donations");

            migrationBuilder.AddColumn<int>(
                name: "PosterCatalystId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaskerCatalystId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DonorCatalystId",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PosterCatalystId",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "416b06e7-5fe2-4cc5-b276-3117977d958a", "81de818d-5e8b-4a6c-baaf-05cfe137aba5", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a59921c3-71aa-4d5a-ae11-754045fa0860", "b57ce98f-b0df-47b9-a875-336164b2ee6a", "Admin", "ADMIN" });
        }
    }
}
