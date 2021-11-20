using Microsoft.EntityFrameworkCore.Migrations;

namespace Chinook.Core.Migrations
{
    public partial class InitialLoad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "NVARCHAR(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(30)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "NVARCHAR(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(40)");
        }
    }
}
