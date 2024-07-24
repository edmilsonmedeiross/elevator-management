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
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Street = table.Column<string>(type: "varchar(100)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "varchar(100)", nullable: false),
                    City = table.Column<string>(type: "varchar(100)", nullable: false),
                    State = table.Column<string>(type: "varchar(100)", nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(100)", nullable: false),
                    BuildingId = table.Column<long>(type: "varchar(100)", nullable: false),
                    TenantId = table.Column<long>(type: "varchar(100)", nullable: false),
                    BuildingId1 = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    DocumentNumber = table.Column<string>(type: "varchar(20)", nullable: false),
                    IsSubActive = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "false"),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CustomerId = table.Column<string>(type: "varchar(100)", nullable: true),
                    TenantColor = table.Column<string>(type: "varchar(20)", nullable: true),
                    TenantLogo = table.Column<string>(type: "varchar(100)", nullable: true),
                    AddressId = table.Column<long>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tenants_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assignees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Tel = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BuildingId = table.Column<long>(type: "varchar(100)", nullable: false),
                    TenantId = table.Column<long>(type: "varchar(100)", nullable: false)
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
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StripeSubscriptionId = table.Column<long>(type: "varchar(100)", nullable: false),
                    PlanID = table.Column<long>(type: "varchar(100)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "false"),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    TenantId = table.Column<long>(type: "varchar(100)", nullable: false)
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
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    DocumentType = table.Column<string>(type: "varchar(20)", nullable: false),
                    DocumentNumber = table.Column<string>(type: "varchar(20)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", nullable: false),
                    Role = table.Column<string>(type: "varchar(20)", nullable: false),
                    Tel = table.Column<string>(type: "varchar(20)", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "true"),
                    PasswordChangedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    TenantId = table.Column<long>(type: "varchar(100)", nullable: false),
                    TenantModelId = table.Column<long>(type: "INTEGER", nullable: true)
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
                name: "Building",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "true"),
                    Tel = table.Column<string>(type: "varchar(20)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AssigneeId = table.Column<long>(type: "varchar(100)", nullable: false),
                    AddressId = table.Column<long>(type: "varchar(100)", nullable: false),
                    TenantId = table.Column<long>(type: "INTEGER", nullable: false),
                    UserId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Building_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Building_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Building_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Building_assignees_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "assignees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Elevators",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MaintenedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    BuildingId = table.Column<long>(type: "varchar(100)", nullable: false),
                    TenantId = table.Column<long>(type: "varchar(100)", nullable: false),
                    UserId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elevators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elevators_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
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
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "varchar(20)", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", nullable: false),
                    Problem = table.Column<string>(type: "varchar(100)", nullable: false),
                    IsPassengerStucked = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "false"),
                    Status = table.Column<string>(type: "varchar(20)", nullable: false),
                    ElevatorStatusPre = table.Column<string>(type: "varchar(50)", nullable: false, defaultValueSql: "stopped"),
                    ElevatorStatusPos = table.Column<string>(type: "varchar(50)", nullable: true),
                    CurrentFloor = table.Column<int>(type: "int", nullable: true),
                    ClosedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<long>(type: "varchar(100)", nullable: false),
                    BuildingId = table.Column<long>(type: "varchar(100)", nullable: false),
                    TenantId = table.Column<long>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
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
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Status = table.Column<string>(type: "varchar(20)", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", nullable: false),
                    Picture = table.Column<string>(type: "varchar(100)", nullable: true),
                    ClosedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserId = table.Column<long>(type: "varchar(100)", nullable: false),
                    ElevatorId = table.Column<long>(type: "varchar(100)", nullable: false),
                    TenantId = table.Column<long>(type: "varchar(100)", nullable: false)
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
                    ElevatorId = table.Column<long>(type: "INTEGER", nullable: false),
                    VisitId = table.Column<long>(type: "INTEGER", nullable: false)
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
                name: "IX_Address_BuildingId1",
                table: "Address",
                column: "BuildingId1");

            migrationBuilder.CreateIndex(
                name: "IX_assignees_TenantId",
                table: "assignees",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_AddressId",
                table: "Building",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Building_AssigneeId",
                table: "Building",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_TenantId",
                table: "Building",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_UserId",
                table: "Building",
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
                name: "FK_Address_Building_BuildingId1",
                table: "Address",
                column: "BuildingId1",
                principalTable: "Building",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Building_BuildingId1",
                table: "Address");

            migrationBuilder.DropTable(
                name: "Pendencies");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "VisitsElevators");

            migrationBuilder.DropTable(
                name: "Elevators");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "assignees");

            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
