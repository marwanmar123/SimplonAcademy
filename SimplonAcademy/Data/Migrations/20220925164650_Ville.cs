using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class Ville : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_formations_formationTypes_FormationTypeId",
                table: "formations");

            migrationBuilder.DropForeignKey(
                name: "FK_inscriptionForms_formations_FormationId",
                table: "inscriptionForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_inscriptionForms",
                table: "inscriptionForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_formationTypes",
                table: "formationTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_formations",
                table: "formations");

            migrationBuilder.RenameTable(
                name: "inscriptionForms",
                newName: "InscriptionForms");

            migrationBuilder.RenameTable(
                name: "formationTypes",
                newName: "FormationTypes");

            migrationBuilder.RenameTable(
                name: "formations",
                newName: "Formations");

            migrationBuilder.RenameIndex(
                name: "IX_inscriptionForms_FormationId",
                table: "InscriptionForms",
                newName: "IX_InscriptionForms_FormationId");

            migrationBuilder.RenameColumn(
                name: "Ville",
                table: "Formations",
                newName: "VilleId");

            migrationBuilder.RenameIndex(
                name: "IX_formations_FormationTypeId",
                table: "Formations",
                newName: "IX_Formations_FormationTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InscriptionForms",
                table: "InscriptionForms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormationTypes",
                table: "FormationTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Formations",
                table: "Formations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Villes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Villes_Formations_FormationId",
                        column: x => x.FormationId,
                        principalTable: "Formations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Villes_FormationId",
                table: "Villes",
                column: "FormationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Formations_FormationTypes_FormationTypeId",
                table: "Formations",
                column: "FormationTypeId",
                principalTable: "FormationTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InscriptionForms_Formations_FormationId",
                table: "InscriptionForms",
                column: "FormationId",
                principalTable: "Formations",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formations_FormationTypes_FormationTypeId",
                table: "Formations");

            migrationBuilder.DropForeignKey(
                name: "FK_InscriptionForms_Formations_FormationId",
                table: "InscriptionForms");

            migrationBuilder.DropTable(
                name: "Villes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InscriptionForms",
                table: "InscriptionForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormationTypes",
                table: "FormationTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Formations",
                table: "Formations");

            migrationBuilder.RenameTable(
                name: "InscriptionForms",
                newName: "inscriptionForms");

            migrationBuilder.RenameTable(
                name: "FormationTypes",
                newName: "formationTypes");

            migrationBuilder.RenameTable(
                name: "Formations",
                newName: "formations");

            migrationBuilder.RenameIndex(
                name: "IX_InscriptionForms_FormationId",
                table: "inscriptionForms",
                newName: "IX_inscriptionForms_FormationId");

            migrationBuilder.RenameColumn(
                name: "VilleId",
                table: "formations",
                newName: "Ville");

            migrationBuilder.RenameIndex(
                name: "IX_Formations_FormationTypeId",
                table: "formations",
                newName: "IX_formations_FormationTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_inscriptionForms",
                table: "inscriptionForms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_formationTypes",
                table: "formationTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_formations",
                table: "formations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_formations_formationTypes_FormationTypeId",
                table: "formations",
                column: "FormationTypeId",
                principalTable: "formationTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_inscriptionForms_formations_FormationId",
                table: "inscriptionForms",
                column: "FormationId",
                principalTable: "formations",
                principalColumn: "Id");
        }
    }
}
