using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class FieldtypeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "Users",
                newName: "EmployeeCode");

            migrationBuilder.RenameColumn(
                name: "SlrId",
                table: "Salaries",
                newName: "SalaryCode");

            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "Salaries",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Roles",
                newName: "RoleCode");

            migrationBuilder.RenameColumn(
                name: "PrjId",
                table: "Projects",
                newName: "ProjectCode");

            migrationBuilder.RenameColumn(
                name: "DesigId",
                table: "Designations",
                newName: "DesignationCode");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "Departments",
                newName: "DepartmentCode");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProjectId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "DesignationId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "DepartmentId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeCode",
                table: "Users",
                newName: "EmpId");

            migrationBuilder.RenameColumn(
                name: "SalaryCode",
                table: "Salaries",
                newName: "SlrId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Salaries",
                newName: "EmpId");

            migrationBuilder.RenameColumn(
                name: "RoleCode",
                table: "Roles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "ProjectCode",
                table: "Projects",
                newName: "PrjId");

            migrationBuilder.RenameColumn(
                name: "DesignationCode",
                table: "Designations",
                newName: "DesigId");

            migrationBuilder.RenameColumn(
                name: "DepartmentCode",
                table: "Departments",
                newName: "DeptId");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "DesignationId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }
    }
}
