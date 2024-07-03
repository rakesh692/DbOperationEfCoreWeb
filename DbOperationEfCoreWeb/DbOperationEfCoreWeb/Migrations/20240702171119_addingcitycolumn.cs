using Microsoft.EntityFrameworkCore.Migrations;

namespace DbOperationEfCoreWeb.Migrations
{
    public partial class addingcitycolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeCity",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeCity",
                table: "Employees");
        }
    }
}
