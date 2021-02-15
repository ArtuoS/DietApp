using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class FoodAmoutDbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "FoodAmoutPerMeal");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmountPerMeal_MealsID",
                table: "FoodAmoutPerMeal",
                newName: "IX_FoodAmoutPerMeal_MealsID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmountPerMeal_FoodID",
                table: "FoodAmoutPerMeal",
                newName: "IX_FoodAmoutPerMeal_FoodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodAmoutPerMeal",
                table: "FoodAmoutPerMeal",
                column: "ID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmoutPerMeal_Foods_FoodID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmoutPerMeal_Meals_MealsID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodAmoutPerMeal",
                table: "FoodAmoutPerMeal");

            migrationBuilder.RenameTable(
                name: "FoodAmoutPerMeal",
                newName: "FoodAmountPerMeal");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmoutPerMeal_MealsID",
                table: "FoodAmountPerMeal",
                newName: "IX_FoodAmountPerMeal_MealsID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmoutPerMeal_FoodID",
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
    }
}
