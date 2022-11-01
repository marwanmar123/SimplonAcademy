using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class homedash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Headers");

            migrationBuilder.DropColumn(
                name: "ContentMenu",
                table: "Menus");

            migrationBuilder.AddColumn<Guid>(
                name: "HomeId",
                table: "Teams",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HomeId",
                table: "Menus",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "HomeId",
                table: "Formations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescrpHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TitleAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleOffre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescrpOffre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleTeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescrpTeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescrpContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MapContact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_HomeId",
                table: "Teams",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_HomeId",
                table: "Menus",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_HomeId",
                table: "Formations",
                column: "HomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Homes_HomeId",
                table: "Formations",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Homes_HomeId",
                table: "Menus",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Homes_HomeId",
                table: "Teams",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Homes_HomeId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Homes_HomeId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Homes_HomeId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Homes");

            migrationBuilder.DropIndex(
                name: "IX_Teams_HomeId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Menus_HomeId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Formations_HomeId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "HomeId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "HomeId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "HomeId",
                table: "Formations");

            migrationBuilder.AddColumn<string>(
                name: "ContentMenu",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContentAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleAbout = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    CallContact = table.Column<int>(type: "int", nullable: true),
                    DescriptionContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalisationContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MapsContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleContact = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    DescriptionHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageHeader = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TitleHeader = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headers", x => x.Id);
                });
        }
    }
}
