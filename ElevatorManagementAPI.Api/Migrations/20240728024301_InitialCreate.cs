using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElevatorManagementAPI.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityRoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<long>(type: "INTEGER", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRoleClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 180, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 180, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 180, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 180, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityClaim_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityRole_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_IdentityUserLogin_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRole",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_IdentityUserRole_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserToken",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 180, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_IdentityUserToken_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "varchar(100)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "varchar(100)", nullable: false),
                    City = table.Column<string>(type: "varchar(100)", nullable: false),
                    State = table.Column<string>(type: "varchar(100)", nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(100)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    BuildingId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TenantId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    DocumentNumber = table.Column<string>(type: "varchar(20)", nullable: false),
                    IsSubActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CustomerId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TenantColor = table.Column<string>(type: "varchar(20)", nullable: true),
                    TenantLogo = table.Column<string>(type: "varchar(100)", nullable: true),
                    AddressId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tenants_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assignees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Tel = table.Column<string>(type: "varchar(20)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    BuildingId = table.Column<Guid>(type: "varchar(100)", nullable: false),
                    TenantId = table.Column<Guid>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assignees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_assignees_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    StripeSubscriptionId = table.Column<Guid>(type: "varchar(100)", nullable: false),
                    PlanID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    TenantId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    DocumentType = table.Column<string>(type: "varchar(20)", nullable: false),
                    DocumentNumber = table.Column<string>(type: "varchar(20)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", nullable: false),
                    Role = table.Column<string>(type: "varchar(20)", nullable: false),
                    Tel = table.Column<string>(type: "varchar(20)", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordChangedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    TenantId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TenantModelId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Tenants_TenantModelId",
                        column: x => x.TenantModelId,
                        principalTable: "Tenants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Tel = table.Column<string>(type: "varchar(20)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    AssigneeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AddressId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TenantId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Buildings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Buildings_assignees_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "assignees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Elevators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "varchar(20)", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Technology = table.Column<string>(type: "varchar(100)", nullable: false),
                    StopsNum = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: true),
                    People = table.Column<int>(type: "int", nullable: true),
                    VelocityNum = table.Column<int>(type: "int", nullable: true),
                    FrequencyInversor = table.Column<string>(type: "varchar(100)", nullable: true),
                    Machine = table.Column<string>(type: "varchar(100)", nullable: true),
                    Command = table.Column<string>(type: "varchar(100)", nullable: true),
                    QttCables = table.Column<int>(type: "int", nullable: true),
                    CableGauge = table.Column<int>(type: "int", nullable: true),
                    IsHouseMachineLess = table.Column<bool>(type: "boolean", nullable: true),
                    IsHouseMachineOnTop = table.Column<bool>(type: "boolean", nullable: true),
                    Ipd = table.Column<string>(type: "varchar(100)", nullable: true),
                    Buttom = table.Column<string>(type: "varchar(100)", nullable: true),
                    OilType = table.Column<string>(type: "varchar(100)", nullable: true),
                    DoorOperator = table.Column<string>(type: "varchar(100)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    MaintenedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    BuildingId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TenantId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elevators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elevators_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Elevators_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Elevators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "varchar(20)", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", nullable: false),
                    Problem = table.Column<string>(type: "varchar(100)", nullable: false),
                    IsPassengerStucked = table.Column<bool>(type: "boolean", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", nullable: false),
                    ElevatorStatusPre = table.Column<string>(type: "varchar(50)", nullable: false),
                    ElevatorStatusPos = table.Column<string>(type: "varchar(50)", nullable: true),
                    CurrentFloor = table.Column<int>(type: "int", nullable: true),
                    ClosedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BuildingId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TenantId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pendencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", nullable: false),
                    Picture = table.Column<string>(type: "varchar(100)", nullable: true),
                    ClosedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ElevatorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TenantId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pendencies_Elevators_ElevatorId",
                        column: x => x.ElevatorId,
                        principalTable: "Elevators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pendencies_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pendencies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitsElevators",
                columns: table => new
                {
                    ElevatorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    VisitId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitsElevators", x => new { x.ElevatorId, x.VisitId });
                    table.ForeignKey(
                        name: "FK_VisitElevators_Elevators_ElevatorModelId",
                        column: x => x.ElevatorId,
                        principalTable: "Elevators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitElevators_Visits_VisitModelId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_BuildingId",
                table: "Addresses",
                column: "BuildingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_assignees_TenantId",
                table: "assignees",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_AssigneeId",
                table: "Buildings",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_TenantId",
                table: "Buildings",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_UserId",
                table: "Buildings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Elevators_BuildingId",
                table: "Elevators",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Elevators_TenantId",
                table: "Elevators",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Elevators_UserId",
                table: "Elevators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityClaim_UserId",
                table: "IdentityClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityRole_NormalizedName",
                table: "IdentityRole",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IdentityRole_UserId",
                table: "IdentityRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUser_NormalizedEmail",
                table: "IdentityUser",
                column: "NormalizedEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUser_NormalizedUserName",
                table: "IdentityUser",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUserLogin_UserId",
                table: "IdentityUserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencies_ElevatorId",
                table: "Pendencies",
                column: "ElevatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencies_TenantId",
                table: "Pendencies",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencies_UserId",
                table: "Pendencies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_TenantId",
                table: "Subscriptions",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_AddressId",
                table: "Tenants",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_TenantId",
                table: "Users",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TenantModelId",
                table: "Users",
                column: "TenantModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_BuildingId",
                table: "Visits",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_TenantId",
                table: "Visits",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_UserId",
                table: "Visits",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitsElevators_VisitId",
                table: "VisitsElevators",
                column: "VisitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Buildings_BuildingId",
                table: "Addresses",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Buildings_BuildingId",
                table: "Addresses");

            migrationBuilder.DropTable(
                name: "IdentityClaim");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "IdentityRoleClaim");

            migrationBuilder.DropTable(
                name: "IdentityUserLogin");

            migrationBuilder.DropTable(
                name: "IdentityUserRole");

            migrationBuilder.DropTable(
                name: "IdentityUserToken");

            migrationBuilder.DropTable(
                name: "Pendencies");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "VisitsElevators");

            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.DropTable(
                name: "Elevators");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "assignees");

            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
