using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class foodAmount2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmoutPerMeal_Foods_FoodID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmoutPerMeal_Meals_MealsID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.DropIndex(
                name: "IX_FoodAmoutPerMeal_MealsID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.DropColumn(
                name: "MealsID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.AlterColumn<int>(
                name: "FoodID",
                table: "FoodAmoutPerMeal",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MealID",
                table: "FoodAmoutPerMeal",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmoutPerMeal_MealID",
                table: "FoodAmoutPerMeal",
                column: "MealID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmoutPerMeal_Foods_FoodID",
                table: "FoodAmoutPerMeal",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmoutPerMeal_Meals_MealID",
                table: "FoodAmoutPerMeal",
                column: "MealID",
                principalTable: "Meals",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmoutPerMeal_Foods_FoodID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmoutPerMeal_Meals_MealID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.DropIndex(
                name: "IX_FoodAmoutPerMeal_MealID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.DropColumn(
                name: "MealID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.AlterColumn<int>(
                name: "FoodID",
                table: "FoodAmoutPerMeal",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MealsID",
                table: "FoodAmoutPerMeal",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmoutPerMeal_MealsID",
                table: "FoodAmoutPerMeal",
                column: "MealsID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmoutPerMeal_Foods_FoodID",
                table: "FoodAmoutPerMeal",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmoutPerMeal_Meals_MealsID",
                table: "FoodAmoutPerMeal",
                column: "MealsID",
                principalTable: "Meals",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
