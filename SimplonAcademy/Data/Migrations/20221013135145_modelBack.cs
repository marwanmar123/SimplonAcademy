using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class modelBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TitlePage",
                table: "Menus",
                newName: "TitleMenu");

            migrationBuilder.RenameColumn(
                name: "ContentPage",
                table: "Menus",
                newName: "ContentMenu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TitleMenu",
                table: "Menus",
                newName: "TitlePage");

            migrationBuilder.RenameColumn(
                name: "ContentMenu",
                table: "Menus",
                newName: "ContentPage");
        }
    }
}
