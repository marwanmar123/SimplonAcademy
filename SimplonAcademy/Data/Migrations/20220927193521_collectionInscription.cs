using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class collectionInscription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InscriptionForms_FormationId",
                table: "InscriptionForms");

            migrationBuilder.CreateIndex(
                name: "IX_InscriptionForms_FormationId",
                table: "InscriptionForms",
                column: "FormationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InscriptionForms_FormationId",
                table: "InscriptionForms");

            migrationBuilder.CreateIndex(
                name: "IX_InscriptionForms_FormationId",
                table: "InscriptionForms",
                column: "FormationId",
                unique: true,
                filter: "[FormationId] IS NOT NULL");
        }
    }
}
