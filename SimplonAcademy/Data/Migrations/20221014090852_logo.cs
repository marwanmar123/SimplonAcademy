using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class logo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Menus");

            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "Homes",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Homes");

            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "Menus",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
