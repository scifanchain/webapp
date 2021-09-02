using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class updateblog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Blog");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Blog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Owner",
                table: "Blog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "Blog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Blog");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Blog",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
