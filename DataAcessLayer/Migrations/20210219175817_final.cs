using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmoutPerMeal_Foods_FoodID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmoutPerMeal_Meals_MealID",
                table: "FoodAmoutPerMeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodAmoutPerMeal",
                table: "FoodAmoutPerMeal");

            migrationBuilder.RenameTable(
                name: "FoodAmoutPerMeal",
                newName: "FoodAmountPerMeal");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmoutPerMeal_MealID",
                table: "FoodAmountPerMeal",
                newName: "IX_FoodAmountPerMeal_MealID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmoutPerMeal_FoodID",
                table: "FoodAmountPerMeal",
                newName: "IX_FoodAmountPerMeal_FoodID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Meals",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmountPerMeal_Meals_MealID",
                table: "FoodAmountPerMeal",
                column: "MealID",
                principalTable: "Meals",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmountPerMeal_Foods_FoodID",
                table: "FoodAmountPerMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmountPerMeal_Meals_MealID",
                table: "FoodAmountPerMeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodAmountPerMeal",
                table: "FoodAmountPerMeal");

            migrationBuilder.RenameTable(
                name: "FoodAmountPerMeal",
                newName: "FoodAmoutPerMeal");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmountPerMeal_MealID",
                table: "FoodAmoutPerMeal",
                newName: "IX_FoodAmoutPerMeal_MealID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmountPerMeal_FoodID",
                table: "FoodAmoutPerMeal",
                newName: "IX_FoodAmoutPerMeal_FoodID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Meals",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmoutPerMeal_Meals_MealID",
                table: "FoodAmoutPerMeal",
                column: "MealID",
                principalTable: "Meals",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
