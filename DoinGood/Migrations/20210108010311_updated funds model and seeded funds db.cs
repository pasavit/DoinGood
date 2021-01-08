using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Migrations
{
    public partial class updatedfundsmodelandseededfundsdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84cad964-8609-4d0c-81bd-d68080ab52ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5743f4b-f0ea-4f69-a77f-2926c839b5f2");

            migrationBuilder.AddColumn<string>(
                name: "Mission",
                table: "Fund",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e4c9cd91-7f0e-4d51-8569-f9ec490ba9f4", "75ffe30f-2a57-439d-a0af-6fb2946fd238", "Benefactor", "BENEFACTOR" },
                    { "86e220a3-9b30-4924-8871-7cf23a8e25b8", "eb2b9729-e679-43ce-8813-11c1ddf35831", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Fund",
                keyColumn: "FundId",
                keyValue: 1,
                column: "Mission",
                value: "TBD");

            migrationBuilder.InsertData(
                table: "Fund",
                columns: new[] { "FundId", "CurrentFunds", "FundName", "Mission", "NumberOfDonations" },
                values: new object[,]
                {
                    { 2, 0, "American Humane", "To ensure the safety, welfare and well-being of animals; to serve in promoting and nurturing the bonds between animals and humans.", 0 },
                    { 3, 0, "American Red Cross", "Prevents and alleviates human suffering in the face of emergencies by mobilizing the power of volunteers and the generosity of donors.", 0 },
                    { 4, 0, "Astraea Lesbian Foundation for Justice", "Funds LGBTQI activism globally, serving as a feminist social justice hub and working side-by-side with grantee and donor partners to achieve rural, economic, social and gender justice worldwide.", 0 },
                    { 5, 0, "Cancer Research Institute", "To save more lives by fueling the discovery and development of powerful immunotherapies for all types of cancer.", 0 },
                    { 6, 0, "Equal Justice Initiative", "To end mass incarceration & excessive punishment in the U.S.; to challenge racial & economic injustice; and to protect basic human rights for the most vulnerable people in American society.", 0 },
                    { 7, 0, "Feeding America", "To feed America's hungry through a nationwide network of food banks and engage our country in the fight to end hunger.", 0 },
                    { 8, 0, "Homes For Our Troops", "To build and donate specially adapted custom homes nationwide for the most severely injured post-9/11 veterans, to enable them to rebuild their lives.", 0 },
                    { 9, 0, "National Wildlife Federation", "To unite all Americans to ensure wildlife thrives in a rapidly changing world.", 0 },
                    { 10, 0, "Scholarship America", "To mobilize America through scholarships and educational support to make post-secondary education possible for all students.", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86e220a3-9b30-4924-8871-7cf23a8e25b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4c9cd91-7f0e-4d51-8569-f9ec490ba9f4");

            migrationBuilder.DeleteData(
                table: "Fund",
                keyColumn: "FundId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fund",
                keyColumn: "FundId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fund",
                keyColumn: "FundId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fund",
                keyColumn: "FundId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fund",
                keyColumn: "FundId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fund",
                keyColumn: "FundId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fund",
                keyColumn: "FundId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fund",
                keyColumn: "FundId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Fund",
                keyColumn: "FundId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Mission",
                table: "Fund");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84cad964-8609-4d0c-81bd-d68080ab52ee", "3d655a77-c72a-48d2-b8dd-11d7702ec1c0", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5743f4b-f0ea-4f69-a77f-2926c839b5f2", "635e24b3-5646-46ea-b3a4-389b49f07945", "Admin", "ADMIN" });
        }
    }
}
