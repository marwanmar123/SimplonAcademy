using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class link : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Homes_HomeId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Homes_HomeId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_HomeId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Menus_HomeId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "HomeId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "HomeId",
                table: "Menus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HomeId",
                table: "Teams",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HomeId",
                table: "Menus",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_HomeId",
                table: "Teams",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_HomeId",
                table: "Menus",
                column: "HomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Homes_HomeId",
                table: "Menus",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Homes_HomeId",
                table: "Teams",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id");
        }
    }
}
