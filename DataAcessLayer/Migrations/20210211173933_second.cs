using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestrictionUser");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Restrictions");

            migrationBuilder.AddColumn<int>(
                name: "RestrictionID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Restrictions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Restrictions_UserID",
                table: "Restrictions",
                column: "UserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Restrictions_Users_UserID",
                table: "Restrictions",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restrictions_Users_UserID",
                table: "Restrictions");

            migrationBuilder.DropIndex(
                name: "IX_Restrictions_UserID",
                table: "Restrictions");

            migrationBuilder.DropColumn(
                name: "RestrictionID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Restrictions");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Restrictions",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_RestrictionUser_UsersID",
                table: "RestrictionUser",
                column: "UsersID");
        }
    }
}
