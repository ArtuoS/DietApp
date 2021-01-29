using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class UserChangeColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Weigth",
                table: "Users",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "Heigth",
                table: "Users",
                newName: "Height");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "Users",
                newName: "Weigth");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "Users",
                newName: "Heigth");
        }
    }
}
