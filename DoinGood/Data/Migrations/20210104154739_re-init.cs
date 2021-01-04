using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Data.Migrations
{
    public partial class reinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad920be7-3593-42b6-aad4-dddbabbe9e2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da95a0d7-5716-450d-bad5-dd09e11d9886");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    Lat = table.Column<int>(nullable: false),
                    Lng = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Catalysts",
                columns: table => new
                {
                    CatalystId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUser = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DeedCount = table.Column<int>(nullable: false),
                    TaskCompletedCount = table.Column<int>(nullable: false),
                    DonationCount = table.Column<int>(nullable: false),
                    ChallengedCount = table.Column<int>(nullable: false),
                    TotalContribution = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalysts", x => x.CatalystId);
                });

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    ChallengeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatalystId = table.Column<int>(nullable: false),
                    DeedCatalystId = table.Column<int>(nullable: false),
                    DeservingCauseId = table.Column<int>(nullable: false),
                    Impact = table.Column<string>(nullable: true),
                    DonateAmount = table.Column<int>(nullable: false),
                    MaxAmount = table.Column<int>(nullable: false),
                    ChallengeCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.ChallengeId);
                });

            migrationBuilder.CreateTable(
                name: "Deeds",
                columns: table => new
                {
                    DeedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatalystId = table.Column<int>(nullable: false),
                    DeservingCauseId = table.Column<int>(nullable: false),
                    Beneficence = table.Column<string>(nullable: true),
                    Impact = table.Column<string>(nullable: true),
                    DonateAmount = table.Column<int>(nullable: false),
                    MaxAmount = table.Column<int>(nullable: false),
                    InspireCount = table.Column<int>(nullable: false),
                    ChallengeCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deeds", x => x.DeedId);
                });

            migrationBuilder.CreateTable(
                name: "DeservingCauses",
                columns: table => new
                {
                    DerservingCauseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentFunds = table.Column<int>(nullable: false),
                    NumberOfDonations = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeservingCauses", x => x.DerservingCauseId);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    DonationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(nullable: false),
                    PosterCatalystId = table.Column<int>(nullable: false),
                    DonorCatalystId = table.Column<int>(nullable: false),
                    DerservingCauseId = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.DonationId);
                });

            migrationBuilder.CreateTable(
                name: "InspiredFunds",
                columns: table => new
                {
                    InspiredFundId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentFunds = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspiredFunds", x => x.InspiredFundId);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosterCatalystId = table.Column<int>(nullable: false),
                    TaskerCatalystId = table.Column<int>(nullable: false),
                    DerservingCauseId = table.Column<int>(nullable: false),
                    TaskTitle = table.Column<string>(nullable: true),
                    TaskDescription = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d53f4dc6-bac3-4915-888e-489af2c5ba4f", "c1643a18-49ac-4e46-8d9d-4b6842920c12", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26771a78-88fa-407c-9323-23b6981f3b54", "7890dc05-c87f-4623-9a16-fb9d94dce947", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Catalysts");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "Deeds");

            migrationBuilder.DropTable(
                name: "DeservingCauses");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "InspiredFunds");

            migrationBuilder.DropTable(
                name: "Tasks");

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
                values: new object[] { "da95a0d7-5716-450d-bad5-dd09e11d9886", "c0cca048-718f-433d-9c93-23a097fb481e", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad920be7-3593-42b6-aad4-dddbabbe9e2c", "25cf1764-3d53-49bc-89b2-7199531b15f1", "Admin", "ADMIN" });
        }
    }
}
