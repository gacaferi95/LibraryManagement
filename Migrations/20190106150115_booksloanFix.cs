using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryApp1.Migrations
{
    public partial class booksloanFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksLoan_Users_UsersID",
                table: "BooksLoan");

            migrationBuilder.RenameColumn(
                name: "UsersID",
                table: "BooksLoan",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksLoan_UsersID",
                table: "BooksLoan",
                newName: "IX_BooksLoan_UsersId");

            migrationBuilder.AlterColumn<int>(
                name: "UsersId",
                table: "BooksLoan",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksLoan_Users_UsersId",
                table: "BooksLoan",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksLoan_Users_UsersId",
                table: "BooksLoan");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "BooksLoan",
                newName: "UsersID");

            migrationBuilder.RenameIndex(
                name: "IX_BooksLoan_UsersId",
                table: "BooksLoan",
                newName: "IX_BooksLoan_UsersID");

            migrationBuilder.AlterColumn<int>(
                name: "UsersID",
                table: "BooksLoan",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_BooksLoan_Users_UsersID",
                table: "BooksLoan",
                column: "UsersID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
