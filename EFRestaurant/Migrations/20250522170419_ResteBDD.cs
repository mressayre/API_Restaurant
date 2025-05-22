using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class ResteBDD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Events",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmployeeManager",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "INTEGER", nullable: false),
                    ManagersManagerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeManager", x => new { x.EmployeesId, x.ManagersManagerId });
                    table.ForeignKey(
                        name: "FK_EmployeeManager_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeManager_Managers_ManagersManagerId",
                        column: x => x.ManagersManagerId,
                        principalTable: "Managers",
                        principalColumn: "ManagerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shift_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShiftAssignment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShiftId = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    CheckInTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CheckOutTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftAssignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShiftAssignment_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShiftAssignment_Shift_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shift",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_ManagerId",
                table: "Events",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeManager_ManagersManagerId",
                table: "EmployeeManager",
                column: "ManagersManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Shift_EventId",
                table: "Shift",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftAssignment_EmployeeId",
                table: "ShiftAssignment",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftAssignment_ShiftId",
                table: "ShiftAssignment",
                column: "ShiftId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Managers_ManagerId",
                table: "Events",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Managers_ManagerId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "EmployeeManager");

            migrationBuilder.DropTable(
                name: "ShiftAssignment");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropIndex(
                name: "IX_Events_ManagerId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Events");
        }
    }
}
