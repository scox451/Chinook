using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chinook.Core.Migrations
{
    public partial class Reload4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "NVARCHAR(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR",
                oldMaxLength: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "NVARCHAR",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(30)");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Customers",
                type: "BLOB",
                nullable: true);
        }
    }
}
