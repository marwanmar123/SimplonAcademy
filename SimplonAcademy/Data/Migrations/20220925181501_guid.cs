﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplonAcademy.Data.Migrations
{
    public partial class guid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "VilleId",
                table: "Formations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VilleId",
                table: "Formations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }
    }
}
