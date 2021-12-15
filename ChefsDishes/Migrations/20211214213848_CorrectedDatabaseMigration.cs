using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefsDishes.Migrations
{
    public partial class CorrectedDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Chefs_chefId",
                table: "Dish");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dish",
                table: "Dish");

            migrationBuilder.RenameTable(
                name: "Dish",
                newName: "Dishes");

            migrationBuilder.RenameIndex(
                name: "IX_Dish_chefId",
                table: "Dishes",
                newName: "IX_Dishes_chefId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_chefId",
                table: "Dishes",
                column: "chefId",
                principalTable: "Chefs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_chefId",
                table: "Dishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes");

            migrationBuilder.RenameTable(
                name: "Dishes",
                newName: "Dish");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_chefId",
                table: "Dish",
                newName: "IX_Dish_chefId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dish",
                table: "Dish",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Chefs_chefId",
                table: "Dish",
                column: "chefId",
                principalTable: "Chefs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
