using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class days : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Day",
                table: "Formations",
                newName: "DayStart");

            migrationBuilder.AddColumn<DateTime>(
                name: "DayEnd",
                table: "Formations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayEnd",
                table: "Formations");

            migrationBuilder.RenameColumn(
                name: "DayStart",
                table: "Formations",
                newName: "Day");
        }
    }
}
