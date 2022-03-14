using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class Ingredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "Price", "Quantity", "Unit" },
                values: new object[,]
                {
                    { 1, "Oil", 3f, 1, 4 },
                    { 2, "Flour", 30f, 25, 2 },
                    { 3, "Sugar", 3f, 1, 2 },
                    { 4, "Salt", 2f, 1, 2 },
                    { 5, "Olive Oil", 20f, 1, 4 },
                    { 6, "Egg", 9f, 30, 0 },
                    { 7, "Chicken meat", 10f, 1, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 17, 190, 142, 41, 72, 227, 31, 133, 172, 222, 148, 79, 134, 175, 224, 100, 214, 144, 129, 101, 238, 123, 55, 104, 54, 239, 2, 110, 82, 200, 28, 79, 239, 199, 36, 2, 83, 209, 235, 25, 193, 140, 127, 212, 212, 17, 178, 182, 190, 14, 74, 106, 64, 161, 196, 243, 181, 71, 150, 245, 245, 111, 102, 153 }, new byte[] { 124, 37, 72, 16, 46, 113, 33, 119, 2, 5, 214, 238, 27, 59, 104, 177, 167, 137, 195, 149, 226, 28, 26, 136, 199, 151, 4, 182, 55, 250, 149, 9, 163, 222, 224, 95, 67, 11, 198, 96, 73, 126, 179, 53, 182, 0, 25, 140, 44, 202, 89, 182, 3, 164, 12, 75, 230, 173, 227, 3, 212, 19, 42, 124, 84, 102, 240, 143, 21, 219, 169, 112, 23, 245, 56, 53, 61, 253, 75, 136, 79, 64, 231, 97, 65, 67, 138, 166, 192, 134, 174, 32, 185, 213, 179, 165, 214, 27, 84, 122, 163, 124, 144, 198, 190, 156, 232, 187, 159, 126, 89, 221, 195, 26, 210, 86, 84, 167, 153, 31, 36, 178, 55, 42, 255, 122, 201, 22 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 84, 65, 231, 110, 154, 236, 111, 29, 71, 223, 88, 176, 63, 134, 35, 76, 146, 153, 86, 117, 160, 40, 245, 141, 28, 204, 157, 139, 134, 162, 184, 38, 190, 172, 50, 237, 248, 203, 94, 142, 16, 114, 143, 88, 150, 187, 117, 237, 213, 36, 101, 100, 113, 65, 94, 122, 117, 181, 205, 251, 80, 163, 14, 136 }, new byte[] { 148, 50, 124, 246, 32, 180, 50, 33, 222, 112, 208, 159, 178, 132, 39, 46, 138, 99, 204, 95, 227, 83, 229, 141, 108, 70, 110, 125, 199, 77, 69, 107, 15, 24, 238, 34, 37, 210, 155, 113, 223, 63, 167, 184, 143, 196, 237, 102, 221, 107, 198, 200, 44, 204, 139, 198, 218, 166, 48, 137, 86, 98, 117, 218, 9, 202, 202, 247, 94, 2, 49, 18, 35, 98, 123, 69, 254, 229, 20, 71, 199, 216, 13, 35, 156, 145, 183, 23, 228, 156, 168, 215, 84, 39, 24, 29, 200, 222, 106, 120, 76, 230, 85, 214, 149, 132, 202, 236, 203, 6, 247, 20, 53, 155, 192, 251, 144, 35, 27, 121, 34, 249, 96, 116, 26, 242, 162, 201 } });
        }
    }
}
