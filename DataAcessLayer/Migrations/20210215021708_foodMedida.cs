using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class foodMedida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "FoodAmountPerMeal");

            migrationBuilder.AddColumn<int>(
                name: "Unit",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "Unit",
                table: "FoodAmountPerMeal",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
