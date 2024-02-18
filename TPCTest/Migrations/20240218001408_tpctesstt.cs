using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPCTest.Migrations
{
    /// <inheritdoc />
    public partial class tpctesstt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Manager",
                table: "Manager");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Manager",
                newName: "managers");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "employees");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_managers",
                table: "managers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_managers",
                table: "managers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.RenameTable(
                name: "managers",
                newName: "Manager");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manager",
                table: "Manager",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");
        }
    }
}
