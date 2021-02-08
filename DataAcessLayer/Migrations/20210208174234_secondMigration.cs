using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmountPerMeal_Foods_FoodID",
                table: "FoodAmountPerMeal");

            migrationBuilder.DropTable(
                name: "FoodAmountPerMealMeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodAmountPerMeal",
                table: "FoodAmountPerMeal");

            migrationBuilder.RenameTable(
                name: "FoodAmountPerMeal",
                newName: "FoodAmountPerMeals");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmountPerMeal_FoodID",
                table: "FoodAmountPerMeals",
                newName: "IX_FoodAmountPerMeals_FoodID");

            migrationBuilder.AlterColumn<int>(
                name: "FoodID",
                table: "FoodAmountPerMeals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MealID",
                table: "FoodAmountPerMeals",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodAmountPerMeals",
                table: "FoodAmountPerMeals",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmountPerMeals_MealID",
                table: "FoodAmountPerMeals",
                column: "MealID");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmountPerMeals_Foods_FoodID",
                table: "FoodAmountPerMeals");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodAmountPerMeals_Meals_MealID",
                table: "FoodAmountPerMeals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodAmountPerMeals",
                table: "FoodAmountPerMeals");

            migrationBuilder.DropIndex(
                name: "IX_FoodAmountPerMeals_MealID",
                table: "FoodAmountPerMeals");

            migrationBuilder.DropColumn(
                name: "MealID",
                table: "FoodAmountPerMeals");

            migrationBuilder.RenameTable(
                name: "FoodAmountPerMeals",
                newName: "FoodAmountPerMeal");

            migrationBuilder.RenameIndex(
                name: "IX_FoodAmountPerMeals_FoodID",
                table: "FoodAmountPerMeal",
                newName: "IX_FoodAmountPerMeal_FoodID");

            migrationBuilder.AlterColumn<int>(
                name: "FoodID",
                table: "FoodAmountPerMeal",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodAmountPerMeal",
                table: "FoodAmountPerMeal",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "FoodAmountPerMealMeal",
                columns: table => new
                {
                    FoodsID = table.Column<int>(type: "int", nullable: false),
                    MealsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAmountPerMealMeal", x => new { x.FoodsID, x.MealsID });
                    table.ForeignKey(
                        name: "FK_FoodAmountPerMealMeal_FoodAmountPerMeal_FoodsID",
                        column: x => x.FoodsID,
                        principalTable: "FoodAmountPerMeal",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodAmountPerMealMeal_Meals_MealsID",
                        column: x => x.MealsID,
                        principalTable: "Meals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmountPerMealMeal_MealsID",
                table: "FoodAmountPerMealMeal",
                column: "MealsID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodAmountPerMeal_Foods_FoodID",
                table: "FoodAmountPerMeal",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
