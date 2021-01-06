using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoinGood.Migrations
{
    public partial class FKmadenullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Catalysts",
                columns: table => new
                {
                    CatalystId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Catalysts_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Catalysts_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    ChallengeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChallengeCatalystId = table.Column<int>(nullable: true),
                    DeedCatalystId = table.Column<int>(nullable: true),
                    DeservingCauseId = table.Column<int>(nullable: false),
                    Impact = table.Column<string>(nullable: true),
                    DonateAmount = table.Column<int>(nullable: false),
                    MaxAmount = table.Column<int>(nullable: false),
                    ChallengeCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.ChallengeId);
                    table.ForeignKey(
                        name: "FK_Challenges_Catalysts_ChallengeCatalystId",
                        column: x => x.ChallengeCatalystId,
                        principalTable: "Catalysts",
                        principalColumn: "CatalystId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Challenges_Catalysts_DeedCatalystId",
                        column: x => x.DeedCatalystId,
                        principalTable: "Catalysts",
                        principalColumn: "CatalystId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Challenges_DeservingCauses_DeservingCauseId",
                        column: x => x.DeservingCauseId,
                        principalTable: "DeservingCauses",
                        principalColumn: "DerservingCauseId",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Deeds_Catalysts_CatalystId",
                        column: x => x.CatalystId,
                        principalTable: "Catalysts",
                        principalColumn: "CatalystId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deeds_DeservingCauses_DeservingCauseId",
                        column: x => x.DeservingCauseId,
                        principalTable: "DeservingCauses",
                        principalColumn: "DerservingCauseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    DonationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(nullable: false),
                    PosterCatalystId = table.Column<int>(nullable: true),
                    DonorCatalystId = table.Column<int>(nullable: true),
                    DerservingCauseId = table.Column<int>(nullable: false),
                    DeservingCauseDerservingCauseId = table.Column<int>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.DonationId);
                    table.ForeignKey(
                        name: "FK_Donations_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_DeservingCauses_DeservingCauseDerservingCauseId",
                        column: x => x.DeservingCauseDerservingCauseId,
                        principalTable: "DeservingCauses",
                        principalColumn: "DerservingCauseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Donations_Catalysts_DonorCatalystId",
                        column: x => x.DonorCatalystId,
                        principalTable: "Catalysts",
                        principalColumn: "CatalystId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Donations_Catalysts_PosterCatalystId",
                        column: x => x.PosterCatalystId,
                        principalTable: "Catalysts",
                        principalColumn: "CatalystId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosterCatalystId = table.Column<int>(nullable: true),
                    TaskerCatalystId = table.Column<int>(nullable: true),
                    DerservingCauseId = table.Column<int>(nullable: false),
                    TaskTitle = table.Column<string>(nullable: true),
                    TaskDescription = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_Tasks_DeservingCauses_DerservingCauseId",
                        column: x => x.DerservingCauseId,
                        principalTable: "DeservingCauses",
                        principalColumn: "DerservingCauseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Catalysts_PosterCatalystId",
                        column: x => x.PosterCatalystId,
                        principalTable: "Catalysts",
                        principalColumn: "CatalystId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_Catalysts_TaskerCatalystId",
                        column: x => x.TaskerCatalystId,
                        principalTable: "Catalysts",
                        principalColumn: "CatalystId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db002ad2-b409-4da3-8f2e-a30b8737ecb9", "fadc5ee9-cb82-4d3a-8b7e-28afa703a959", "Benefactor", "BENEFACTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2a3159a-f98f-44e0-a5f3-7e719eab379b", "8a09cae2-dfbc-40bd-b4ea-d8d0bf033907", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Catalysts_AddressId",
                table: "Catalysts",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalysts_IdentityUserId",
                table: "Catalysts",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_ChallengeCatalystId",
                table: "Challenges",
                column: "ChallengeCatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_DeedCatalystId",
                table: "Challenges",
                column: "DeedCatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_DeservingCauseId",
                table: "Challenges",
                column: "DeservingCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_Deeds_CatalystId",
                table: "Deeds",
                column: "CatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Deeds_DeservingCauseId",
                table: "Deeds",
                column: "DeservingCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_AddressId",
                table: "Donations",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DeservingCauseDerservingCauseId",
                table: "Donations",
                column: "DeservingCauseDerservingCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonorCatalystId",
                table: "Donations",
                column: "DonorCatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_PosterCatalystId",
                table: "Donations",
                column: "PosterCatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_DerservingCauseId",
                table: "Tasks",
                column: "DerservingCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_PosterCatalystId",
                table: "Tasks",
                column: "PosterCatalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskerCatalystId",
                table: "Tasks",
                column: "TaskerCatalystId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "Deeds");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "InspiredFunds");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DeservingCauses");

            migrationBuilder.DropTable(
                name: "Catalysts");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
