using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class rela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Villes_Formations_FormationId",
                table: "Villes");

            migrationBuilder.DropIndex(
                name: "IX_Villes_FormationId",
                table: "Villes");

            migrationBuilder.DropColumn(
                name: "FormationId",
                table: "Villes");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_VilleId",
                table: "Formations",
                column: "VilleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Villes_VilleId",
                table: "Formations",
                column: "VilleId",
                principalTable: "Villes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Villes_VilleId",
                table: "Formations");

            migrationBuilder.DropIndex(
                name: "IX_Formations_VilleId",
                table: "Formations");

            migrationBuilder.AddColumn<Guid>(
                name: "FormationId",
                table: "Villes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Villes_FormationId",
                table: "Villes",
                column: "FormationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Villes_Formations_FormationId",
                table: "Villes",
                column: "FormationId",
                principalTable: "Formations",
                principalColumn: "Id");
        }
    }
}
