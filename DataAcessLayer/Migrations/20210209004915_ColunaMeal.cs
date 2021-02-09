using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class ColunaMeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_Food_CategoryID",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_Food_CategoryID",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Meals");

            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "Meals",
                newName: "Category");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryID",
                table: "Foods",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryID",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Meals",
                newName: "Categoria");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Meals",
                type: "datetime2",
                maxLength: 40,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Foods_Food_CategoryID",
                table: "Foods",
                column: "Food_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_Food_CategoryID",
                table: "Foods",
                column: "Food_CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
