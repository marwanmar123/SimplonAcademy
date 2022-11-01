using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class backoffice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Offres");

            migrationBuilder.RenameColumn(
                name: "Twitter",
                table: "Teams",
                newName: "TwitterTeam");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Teams",
                newName: "TitleTeam");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Teams",
                newName: "RoleTeam");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Teams",
                newName: "NameTeam");

            migrationBuilder.RenameColumn(
                name: "Linkedin",
                table: "Teams",
                newName: "LinkedinTeam");

            migrationBuilder.RenameColumn(
                name: "Instagram",
                table: "Teams",
                newName: "InstagramTeam");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Teams",
                newName: "ImageTeam");

            migrationBuilder.RenameColumn(
                name: "Facebook",
                table: "Teams",
                newName: "FacebookTeam");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Teams",
                newName: "DescriptionTeam");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Menus",
                newName: "TitlePage");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Headers",
                newName: "TitleHeader");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Headers",
                newName: "ImageHeader");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Headers",
                newName: "DescriptionHeader");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Contacts",
                newName: "TitleContact");

            migrationBuilder.RenameColumn(
                name: "Maps",
                table: "Contacts",
                newName: "MapsContact");

            migrationBuilder.RenameColumn(
                name: "Localisation",
                table: "Contacts",
                newName: "LocalisationContact");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contacts",
                newName: "EmailContact");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Contacts",
                newName: "DescriptionContact");

            migrationBuilder.RenameColumn(
                name: "Call",
                table: "Contacts",
                newName: "CallContact");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Abouts",
                newName: "TitleAbout");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Abouts",
                newName: "ContentAbout");

            migrationBuilder.AddColumn<string>(
                name: "ContentPage",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentPage",
                table: "Menus");

            migrationBuilder.RenameColumn(
                name: "TwitterTeam",
                table: "Teams",
                newName: "Twitter");

            migrationBuilder.RenameColumn(
                name: "TitleTeam",
                table: "Teams",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "RoleTeam",
                table: "Teams",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "NameTeam",
                table: "Teams",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LinkedinTeam",
                table: "Teams",
                newName: "Linkedin");

            migrationBuilder.RenameColumn(
                name: "InstagramTeam",
                table: "Teams",
                newName: "Instagram");

            migrationBuilder.RenameColumn(
                name: "ImageTeam",
                table: "Teams",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "FacebookTeam",
                table: "Teams",
                newName: "Facebook");

            migrationBuilder.RenameColumn(
                name: "DescriptionTeam",
                table: "Teams",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "TitlePage",
                table: "Menus",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleHeader",
                table: "Headers",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ImageHeader",
                table: "Headers",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "DescriptionHeader",
                table: "Headers",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "TitleContact",
                table: "Contacts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "MapsContact",
                table: "Contacts",
                newName: "Maps");

            migrationBuilder.RenameColumn(
                name: "LocalisationContact",
                table: "Contacts",
                newName: "Localisation");

            migrationBuilder.RenameColumn(
                name: "EmailContact",
                table: "Contacts",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "DescriptionContact",
                table: "Contacts",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CallContact",
                table: "Contacts",
                newName: "Call");

            migrationBuilder.RenameColumn(
                name: "TitleAbout",
                table: "Abouts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ContentAbout",
                table: "Abouts",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Offres",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
