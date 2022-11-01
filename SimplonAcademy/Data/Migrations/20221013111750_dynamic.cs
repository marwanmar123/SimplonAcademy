using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class dynamic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OffreId",
                table: "FormationTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Durée",
                table: "Formations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OffreId",
                table: "Formations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localisation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Call = table.Column<int>(type: "int", nullable: true),
                    Maps = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Headers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleOffre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormationTypes_OffreId",
                table: "FormationTypes",
                column: "OffreId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_OffreId",
                table: "Formations",
                column: "OffreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Offres_OffreId",
                table: "Formations",
                column: "OffreId",
                principalTable: "Offres",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FormationTypes_Offres_OffreId",
                table: "FormationTypes",
                column: "OffreId",
                principalTable: "Offres",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Offres_OffreId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_FormationTypes_Offres_OffreId",
                table: "FormationTypes");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Headers");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Offres");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_FormationTypes_OffreId",
                table: "FormationTypes");

            migrationBuilder.DropIndex(
                name: "IX_Formations_OffreId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "OffreId",
                table: "FormationTypes");

            migrationBuilder.DropColumn(
                name: "Durée",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "OffreId",
                table: "Formations");
        }
    }
}
