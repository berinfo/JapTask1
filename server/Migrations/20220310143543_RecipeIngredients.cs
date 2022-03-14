using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class RecipeIngredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.IngredientId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 85, 214, 77, 65, 229, 47, 73, 208, 178, 77, 196, 223, 163, 173, 145, 114, 114, 0, 103, 154, 68, 112, 81, 237, 196, 179, 38, 249, 15, 239, 183, 19, 109, 203, 201, 172, 142, 243, 141, 63, 122, 84, 182, 244, 153, 143, 201, 36, 191, 37, 244, 21, 128, 115, 193, 30, 51, 6, 212, 84, 195, 50, 125, 213 }, new byte[] { 99, 146, 101, 191, 34, 186, 238, 148, 23, 166, 132, 145, 64, 235, 112, 168, 4, 111, 250, 21, 140, 173, 45, 136, 98, 231, 29, 213, 227, 169, 181, 143, 72, 47, 197, 161, 122, 213, 247, 103, 243, 81, 79, 124, 221, 82, 218, 79, 36, 32, 234, 192, 181, 25, 59, 171, 67, 0, 47, 36, 239, 98, 186, 37, 242, 43, 226, 165, 118, 235, 65, 36, 171, 205, 16, 160, 112, 113, 189, 95, 80, 102, 177, 182, 125, 66, 5, 165, 122, 169, 106, 10, 147, 48, 158, 124, 191, 65, 77, 119, 229, 151, 253, 8, 48, 183, 14, 244, 71, 165, 128, 186, 40, 84, 49, 125, 97, 170, 41, 235, 10, 255, 201, 174, 159, 162, 238, 150 } });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Recipes");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 17, 190, 142, 41, 72, 227, 31, 133, 172, 222, 148, 79, 134, 175, 224, 100, 214, 144, 129, 101, 238, 123, 55, 104, 54, 239, 2, 110, 82, 200, 28, 79, 239, 199, 36, 2, 83, 209, 235, 25, 193, 140, 127, 212, 212, 17, 178, 182, 190, 14, 74, 106, 64, 161, 196, 243, 181, 71, 150, 245, 245, 111, 102, 153 }, new byte[] { 124, 37, 72, 16, 46, 113, 33, 119, 2, 5, 214, 238, 27, 59, 104, 177, 167, 137, 195, 149, 226, 28, 26, 136, 199, 151, 4, 182, 55, 250, 149, 9, 163, 222, 224, 95, 67, 11, 198, 96, 73, 126, 179, 53, 182, 0, 25, 140, 44, 202, 89, 182, 3, 164, 12, 75, 230, 173, 227, 3, 212, 19, 42, 124, 84, 102, 240, 143, 21, 219, 169, 112, 23, 245, 56, 53, 61, 253, 75, 136, 79, 64, 231, 97, 65, 67, 138, 166, 192, 134, 174, 32, 185, 213, 179, 165, 214, 27, 84, 122, 163, 124, 144, 198, 190, 156, 232, 187, 159, 126, 89, 221, 195, 26, 210, 86, 84, 167, 153, 31, 36, 178, 55, 42, 255, 122, 201, 22 } });
        }
    }
}
