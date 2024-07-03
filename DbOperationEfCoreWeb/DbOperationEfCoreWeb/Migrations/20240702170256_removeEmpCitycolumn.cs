using Microsoft.EntityFrameworkCore.Migrations;

namespace DbOperationEfCoreWeb.Migrations
{
    public partial class removeEmpCitycolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeCity",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeCity",
                table: "Employees",
                nullable: true);
        }
    }
}
