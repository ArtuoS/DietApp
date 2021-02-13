using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class FoodAmoutUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmountPerMeals_Foods_FoodID",
                table: "FoodAmountPerMeals");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmountPerMeals_Meals_MealID",
                table: "FoodAmountPerMeals");

            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Foods_FoodID",
                table: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Meals_FoodID",
                table: "Meals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodAmountPerMeals",
                table: "FoodAmountPerMeals");

            migrationBuilder.DropColumn(
                name: "FoodID",
                table: "Meals");

            migrationBuilder.RenameTable(
                name: "FoodAmountPerMeals",
                newName: "FoodAmountPerMeal");

            migrationBuilder.RenameColumn(
                name: "MealID",
                table: "FoodAmountPerMeal",
                newName: "MealsID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmountPerMeals_MealID",
                table: "FoodAmountPerMeal",
                newName: "IX_FoodAmountPerMeal_MealsID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmountPerMeals_FoodID",
                table: "FoodAmountPerMeal",
                newName: "IX_FoodAmountPerMeal_FoodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodAmountPerMeal",
                table: "FoodAmountPerMeal",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmountPerMeal_Foods_FoodID",
                table: "FoodAmountPerMeal",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmountPerMeal_Meals_MealsID",
                table: "FoodAmountPerMeal",
                column: "MealsID",
                principalTable: "Meals",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmountPerMeal_Foods_FoodID",
                table: "FoodAmountPerMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmountPerMeal_Meals_MealsID",
                table: "FoodAmountPerMeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodAmountPerMeal",
                table: "FoodAmountPerMeal");

            migrationBuilder.RenameTable(
                name: "FoodAmountPerMeal",
                newName: "FoodAmountPerMeals");

            migrationBuilder.RenameColumn(
                name: "MealsID",
                table: "FoodAmountPerMeals",
                newName: "MealID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmountPerMeal_MealsID",
                table: "FoodAmountPerMeals",
                newName: "IX_FoodAmountPerMeals_MealID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmountPerMeal_FoodID",
                table: "FoodAmountPerMeals",
                newName: "IX_FoodAmountPerMeals_FoodID");

            migrationBuilder.AddColumn<int>(
                name: "FoodID",
                table: "Meals",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodAmountPerMeals",
                table: "FoodAmountPerMeals",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_FoodID",
                table: "Meals",
                column: "FoodID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmountPerMeals_Foods_FoodID",
                table: "FoodAmountPerMeals",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmountPerMeals_Meals_MealID",
                table: "FoodAmountPerMeals",
                column: "MealID",
                principalTable: "Meals",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Foods_FoodID",
                table: "Meals",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
