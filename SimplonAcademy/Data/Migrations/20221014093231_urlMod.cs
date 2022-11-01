using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class urlMod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "link",
                table: "Menus",
                newName: "Link");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Menus",
                newName: "link");
        }
    }
}
