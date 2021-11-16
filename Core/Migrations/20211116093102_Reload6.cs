using Microsoft.EntityFrameworkCore.Migrations;

namespace Chinook.Core.Migrations
{
    public partial class Reload6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "NVARCHAR(60)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(60)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "NVARCHAR(60)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(60)");
        }
    }
}
