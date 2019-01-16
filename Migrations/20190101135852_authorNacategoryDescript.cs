using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryApp1.Migrations
{
    public partial class authorNacategoryDescript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "authorSurname",
                table: "Authors");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "authorSurname",
                table: "Authors",
                nullable: true);
        }
    }
}
