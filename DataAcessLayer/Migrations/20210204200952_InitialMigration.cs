using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", maxLength: 40, nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Restrictions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restrictions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Date_Of_Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    BodyFat = table.Column<double>(type: "float", nullable: false),
                    Activity = table.Column<int>(type: "int", nullable: false),
                    Objective = table.Column<int>(type: "int", nullable: false),
                    IMC = table.Column<double>(type: "float", nullable: false),
                    Weight_Objective = table.Column<int>(type: "int", nullable: false),
                    Days_To_Reach_Goal = table.Column<int>(type: "int", nullable: false),
                    Daily_Calories = table.Column<double>(type: "float", nullable: false),
                    Daily_Carbohydrates = table.Column<double>(type: "float", nullable: false),
                    Daily_Fats = table.Column<double>(type: "float", nullable: false),
                    Daily_Protein = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Food_CategoryID = table.Column<int>(type: "int", nullable: false),
                    Food_Name = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    Calories = table.Column<double>(type: "float", nullable: false),
                    Alcohol = table.Column<double>(type: "float", nullable: false),
                    Carbohydrate = table.Column<double>(type: "float", nullable: false),
                    Copper = table.Column<double>(type: "float", nullable: false),
                    Fiber = table.Column<double>(type: "float", nullable: false),
                    Lipid = table.Column<double>(type: "float", nullable: false),
                    Magnesium = table.Column<double>(type: "float", nullable: false),
                    Phosphor = table.Column<double>(type: "float", nullable: false),
                    Potassium = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Sodium = table.Column<double>(type: "float", nullable: false),
                    Selenium = table.Column<double>(type: "float", nullable: false),
                    Vitamin_A = table.Column<double>(type: "float", nullable: false),
                    Vitamin_C = table.Column<double>(type: "float", nullable: false),
                    Vitamin_D = table.Column<double>(type: "float", nullable: false),
                    Vitamin_E = table.Column<double>(type: "float", nullable: false),
                    Vitamin_B6 = table.Column<double>(type: "float", nullable: false),
                    Vitamin_B12 = table.Column<double>(type: "float", nullable: false),
                    Zinc = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_Food_CategoryID",
                        column: x => x.Food_CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Diets_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestrictionUser",
                columns: table => new
                {
                    RestrictionsID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestrictionUser", x => new { x.RestrictionsID, x.UsersID });
                    table.ForeignKey(
                        name: "FK_RestrictionUser_Restrictions_RestrictionsID",
                        column: x => x.RestrictionsID,
                        principalTable: "Restrictions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestrictionUser_Users_UsersID",
                        column: x => x.UsersID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodMeal",
                columns: table => new
                {
                    FoodsID = table.Column<int>(type: "int", nullable: false),
                    MealsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMeal", x => new { x.FoodsID, x.MealsID });
                    table.ForeignKey(
                        name: "FK_FoodMeal_Foods_FoodsID",
                        column: x => x.FoodsID,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodMeal_Meals_MealsID",
                        column: x => x.MealsID,
                        principalTable: "Meals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodRestriction",
                columns: table => new
                {
                    FoodsID = table.Column<int>(type: "int", nullable: false),
                    RestrictionsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodRestriction", x => new { x.FoodsID, x.RestrictionsID });
                    table.ForeignKey(
                        name: "FK_FoodRestriction_Foods_FoodsID",
                        column: x => x.FoodsID,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodRestriction_Restrictions_RestrictionsID",
                        column: x => x.RestrictionsID,
                        principalTable: "Restrictions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DietMeal",
                columns: table => new
                {
                    DietsID = table.Column<int>(type: "int", nullable: false),
                    MealsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietMeal", x => new { x.DietsID, x.MealsID });
                    table.ForeignKey(
                        name: "FK_DietMeal_Diets_DietsID",
                        column: x => x.DietsID,
                        principalTable: "Diets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DietMeal_Meals_MealsID",
                        column: x => x.MealsID,
                        principalTable: "Meals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DietMeal_MealsID",
                table: "DietMeal",
                column: "MealsID");

            migrationBuilder.CreateIndex(
                name: "IX_Diets_UserID",
                table: "Diets",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeal_MealsID",
                table: "FoodMeal",
                column: "MealsID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodRestriction_RestrictionsID",
                table: "FoodRestriction",
                column: "RestrictionsID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_Food_CategoryID",
                table: "Foods",
                column: "Food_CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_RestrictionUser_UsersID",
                table: "RestrictionUser",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DietMeal");

            migrationBuilder.DropTable(
                name: "FoodMeal");

            migrationBuilder.DropTable(
                name: "FoodRestriction");

            migrationBuilder.DropTable(
                name: "RestrictionUser");

            migrationBuilder.DropTable(
                name: "Diets");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Restrictions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
