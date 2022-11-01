using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class homed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Homes_HomeId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_Formations_Offres_OffreId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_FormationTypes_Offres_OffreId",
                table: "FormationTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Homes_HomeId",
                table: "Menus");

            migrationBuilder.DropTable(
                name: "Offres");

            migrationBuilder.DropIndex(
                name: "IX_FormationTypes_OffreId",
                table: "FormationTypes");

            migrationBuilder.DropIndex(
                name: "IX_Formations_HomeId",
                table: "Formations");

            migrationBuilder.DropIndex(
                name: "IX_Formations_OffreId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "OffreId",
                table: "FormationTypes");

            migrationBuilder.DropColumn(
                name: "HomeId",
                table: "Formations");

            migrationBuilder.DropColumn(
                name: "OffreId",
                table: "Formations");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Homes",
                newName: "ImageHeader");

            migrationBuilder.AlterColumn<Guid>(
                name: "HomeId",
                table: "Menus",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Durée",
                table: "Formations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Homes_HomeId",
                table: "Menus",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Homes_HomeId",
                table: "Menus");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.RenameColumn(
                name: "ImageHeader",
                table: "Homes",
                newName: "Image");

            migrationBuilder.AlterColumn<Guid>(
                name: "HomeId",
                table: "Menus",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OffreId",
                table: "FormationTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Durée",
                table: "Formations",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HomeId",
                table: "Formations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OffreId",
                table: "Formations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Offres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleOffre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offres", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormationTypes_OffreId",
                table: "FormationTypes",
                column: "OffreId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_HomeId",
                table: "Formations",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_OffreId",
                table: "Formations",
                column: "OffreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_Homes_HomeId",
                table: "Formations",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Homes_HomeId",
                table: "Menus",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
