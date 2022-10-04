using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class modifFormationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Admission",
                table: "Formations");

            migrationBuilder.RenameColumn(
                name: "Programme",
                table: "Formations",
                newName: "Certification");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Certification",
                table: "Formations",
                newName: "Programme");

            migrationBuilder.AddColumn<string>(
                name: "Admission",
                table: "Formations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
