using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class addedCreatedAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "Ingredients",
                newName: "PurchaseUnit");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Ingredients",
                newName: "PurchaseQuantity");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Ingredients",
                newName: "PurchasePrice");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Recipes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "RecipeIngredients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Ingredients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 163, 24, 88, 247, 182, 193, 202, 14, 7, 193, 79, 91, 122, 198, 28, 73, 253, 79, 114, 17, 47, 114, 49, 182, 31, 119, 129, 132, 7, 171, 186, 7, 37, 166, 54, 255, 118, 137, 45, 150, 210, 22, 213, 129, 202, 1, 206, 76, 112, 36, 235, 250, 169, 126, 227, 90, 64, 102, 169, 77, 219, 99, 172, 185 }, new byte[] { 192, 39, 154, 37, 189, 25, 0, 243, 250, 234, 71, 44, 94, 92, 219, 222, 73, 35, 180, 85, 28, 140, 250, 88, 36, 26, 39, 27, 3, 65, 44, 195, 247, 19, 199, 112, 142, 221, 142, 131, 55, 189, 191, 143, 126, 201, 108, 217, 215, 12, 94, 185, 243, 55, 12, 33, 71, 169, 102, 230, 162, 163, 249, 137, 142, 241, 233, 29, 157, 107, 159, 115, 173, 219, 194, 151, 65, 53, 237, 17, 111, 242, 107, 187, 75, 249, 134, 233, 234, 174, 133, 98, 235, 91, 2, 60, 6, 52, 151, 106, 114, 182, 183, 184, 17, 177, 55, 255, 195, 15, 148, 56, 47, 79, 54, 65, 71, 114, 109, 143, 18, 200, 79, 187, 118, 46, 20, 161 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "PurchaseUnit",
                table: "Ingredients",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "PurchaseQuantity",
                table: "Ingredients",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "PurchasePrice",
                table: "Ingredients",
                newName: "Price");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 85, 214, 77, 65, 229, 47, 73, 208, 178, 77, 196, 223, 163, 173, 145, 114, 114, 0, 103, 154, 68, 112, 81, 237, 196, 179, 38, 249, 15, 239, 183, 19, 109, 203, 201, 172, 142, 243, 141, 63, 122, 84, 182, 244, 153, 143, 201, 36, 191, 37, 244, 21, 128, 115, 193, 30, 51, 6, 212, 84, 195, 50, 125, 213 }, new byte[] { 99, 146, 101, 191, 34, 186, 238, 148, 23, 166, 132, 145, 64, 235, 112, 168, 4, 111, 250, 21, 140, 173, 45, 136, 98, 231, 29, 213, 227, 169, 181, 143, 72, 47, 197, 161, 122, 213, 247, 103, 243, 81, 79, 124, 221, 82, 218, 79, 36, 32, 234, 192, 181, 25, 59, 171, 67, 0, 47, 36, 239, 98, 186, 37, 242, 43, 226, 165, 118, 235, 65, 36, 171, 205, 16, 160, 112, 113, 189, 95, 80, 102, 177, 182, 125, 66, 5, 165, 122, 169, 106, 10, 147, 48, 158, 124, 191, 65, 77, 119, 229, 151, 253, 8, 48, 183, 14, 244, 71, 165, 128, 186, 40, 84, 49, 125, 97, 170, 41, 235, 10, 255, 201, 174, 159, 162, 238, 150 } });
        }
    }
}
