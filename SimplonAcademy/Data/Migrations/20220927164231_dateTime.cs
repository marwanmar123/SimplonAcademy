using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class dateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Formations_FormationTypeId",
                table: "Formations");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Formations",
                newName: "TimeEnd");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeBeginning",
                table: "Formations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Formations_FormationTypeId",
                table: "Formations",
                column: "FormationTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Formations_FormationTypeId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "TimeBeginning",
                table: "Formations");

            migrationBuilder.RenameColumn(
                name: "TimeEnd",
                table: "Formations",
                newName: "Time");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_FormationTypeId",
                table: "Formations",
                column: "FormationTypeId",
                unique: true,
                filter: "[FormationTypeId] IS NOT NULL");
        }
    }
}
