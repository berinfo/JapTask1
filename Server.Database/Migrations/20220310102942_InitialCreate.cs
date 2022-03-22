using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 3, 3, 5, 25, 4, 0, DateTimeKind.Unspecified), "Barbecue" },
                    { 2, new DateTime(2021, 4, 4, 6, 15, 14, 0, DateTimeKind.Unspecified), "Desert" },
                    { 3, new DateTime(2020, 4, 6, 3, 17, 25, 0, DateTimeKind.Unspecified), "Breakfast" },
                    { 4, new DateTime(2019, 5, 6, 2, 2, 2, 0, DateTimeKind.Unspecified), "Lunch" },
                    { 5, new DateTime(2018, 5, 7, 1, 15, 15, 0, DateTimeKind.Unspecified), "Dinner" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 84, 65, 231, 110, 154, 236, 111, 29, 71, 223, 88, 176, 63, 134, 35, 76, 146, 153, 86, 117, 160, 40, 245, 141, 28, 204, 157, 139, 134, 162, 184, 38, 190, 172, 50, 237, 248, 203, 94, 142, 16, 114, 143, 88, 150, 187, 117, 237, 213, 36, 101, 100, 113, 65, 94, 122, 117, 181, 205, 251, 80, 163, 14, 136 }, new byte[] { 148, 50, 124, 246, 32, 180, 50, 33, 222, 112, 208, 159, 178, 132, 39, 46, 138, 99, 204, 95, 227, 83, 229, 141, 108, 70, 110, 125, 199, 77, 69, 107, 15, 24, 238, 34, 37, 210, 155, 113, 223, 63, 167, 184, 143, 196, 237, 102, 221, 107, 198, 200, 44, 204, 139, 198, 218, 166, 48, 137, 86, 98, 117, 218, 9, 202, 202, 247, 94, 2, 49, 18, 35, 98, 123, 69, 254, 229, 20, 71, 199, 216, 13, 35, 156, 145, 183, 23, 228, 156, 168, 215, 84, 39, 24, 29, 200, 222, 106, 120, 76, 230, 85, 214, 149, 132, 202, 236, 203, 6, 247, 20, 53, 155, 192, 251, 144, 35, 27, 121, 34, 249, 96, 116, 26, 242, 162, 201 }, "user123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
