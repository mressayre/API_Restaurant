using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class DbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shift_Events_EventId",
                table: "Shift");

            migrationBuilder.DropForeignKey(
                name: "FK_ShiftAssignment_Employees_EmployeeId",
                table: "ShiftAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_ShiftAssignment_Shift_ShiftId",
                table: "ShiftAssignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShiftAssignment",
                table: "ShiftAssignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shift",
                table: "Shift");

            migrationBuilder.RenameTable(
                name: "ShiftAssignment",
                newName: "ShiftAssignments");

            migrationBuilder.RenameTable(
                name: "Shift",
                newName: "Shifts");

            migrationBuilder.RenameIndex(
                name: "IX_ShiftAssignment_ShiftId",
                table: "ShiftAssignments",
                newName: "IX_ShiftAssignments_ShiftId");

            migrationBuilder.RenameIndex(
                name: "IX_ShiftAssignment_EmployeeId",
                table: "ShiftAssignments",
                newName: "IX_ShiftAssignments_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Shift_EventId",
                table: "Shifts",
                newName: "IX_Shifts_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShiftAssignments",
                table: "ShiftAssignments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shifts",
                table: "Shifts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftAssignments_Employees_EmployeeId",
                table: "ShiftAssignments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftAssignments_Shifts_ShiftId",
                table: "ShiftAssignments",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shifts_Events_EventId",
                table: "Shifts",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShiftAssignments_Employees_EmployeeId",
                table: "ShiftAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_ShiftAssignments_Shifts_ShiftId",
                table: "ShiftAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Shifts_Events_EventId",
                table: "Shifts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shifts",
                table: "Shifts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShiftAssignments",
                table: "ShiftAssignments");

            migrationBuilder.RenameTable(
                name: "Shifts",
                newName: "Shift");

            migrationBuilder.RenameTable(
                name: "ShiftAssignments",
                newName: "ShiftAssignment");

            migrationBuilder.RenameIndex(
                name: "IX_Shifts_EventId",
                table: "Shift",
                newName: "IX_Shift_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_ShiftAssignments_ShiftId",
                table: "ShiftAssignment",
                newName: "IX_ShiftAssignment_ShiftId");

            migrationBuilder.RenameIndex(
                name: "IX_ShiftAssignments_EmployeeId",
                table: "ShiftAssignment",
                newName: "IX_ShiftAssignment_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shift",
                table: "Shift",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShiftAssignment",
                table: "ShiftAssignment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shift_Events_EventId",
                table: "Shift",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftAssignment_Employees_EmployeeId",
                table: "ShiftAssignment",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShiftAssignment_Shift_ShiftId",
                table: "ShiftAssignment",
                column: "ShiftId",
                principalTable: "Shift",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
