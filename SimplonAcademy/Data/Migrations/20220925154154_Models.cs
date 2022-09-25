using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "formationTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "formations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Presentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Programme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Competences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormationTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_formations_formationTypes_FormationTypeId",
                        column: x => x.FormationTypeId,
                        principalTable: "formationTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "inscriptionForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: true),
                    JobRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscriptionForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inscriptionForms_formations_FormationId",
                        column: x => x.FormationId,
                        principalTable: "formations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_formations_FormationTypeId",
                table: "formations",
                column: "FormationTypeId",
                unique: true,
                filter: "[FormationTypeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_inscriptionForms_FormationId",
                table: "inscriptionForms",
                column: "FormationId",
                unique: true,
                filter: "[FormationId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inscriptionForms");

            migrationBuilder.DropTable(
                name: "formations");

            migrationBuilder.DropTable(
                name: "formationTypes");
        }
    }
}
