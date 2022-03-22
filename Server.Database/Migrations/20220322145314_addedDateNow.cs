using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class addedDateNow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 22, 15, 53, 14, 526, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 243, 230, 38, 90, 147, 64, 133, 82, 12, 12, 233, 242, 94, 145, 21, 121, 78, 106, 231, 246, 80, 237, 44, 114, 54, 246, 252, 239, 19, 66, 137, 243, 187, 102, 138, 206, 137, 251, 46, 100, 185, 29, 193, 56, 201, 126, 223, 123, 128, 76, 119, 154, 24, 23, 19, 150, 116, 98, 234, 17, 243, 136, 168, 9 }, new byte[] { 80, 210, 44, 36, 23, 3, 113, 55, 132, 253, 30, 174, 33, 86, 169, 246, 80, 97, 190, 30, 253, 45, 251, 220, 34, 99, 26, 47, 207, 250, 95, 30, 45, 215, 4, 110, 214, 110, 207, 209, 171, 40, 160, 152, 42, 230, 160, 7, 70, 91, 95, 167, 142, 133, 121, 248, 34, 46, 16, 100, 60, 103, 184, 195, 61, 203, 1, 51, 180, 210, 0, 73, 148, 7, 25, 133, 159, 53, 34, 10, 105, 169, 160, 78, 54, 185, 30, 51, 136, 203, 5, 149, 12, 65, 193, 18, 199, 146, 247, 122, 176, 39, 203, 143, 202, 186, 231, 143, 208, 86, 148, 23, 54, 141, 131, 54, 64, 207, 192, 204, 150, 175, 27, 201, 5, 190, 66, 252 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 163, 24, 88, 247, 182, 193, 202, 14, 7, 193, 79, 91, 122, 198, 28, 73, 253, 79, 114, 17, 47, 114, 49, 182, 31, 119, 129, 132, 7, 171, 186, 7, 37, 166, 54, 255, 118, 137, 45, 150, 210, 22, 213, 129, 202, 1, 206, 76, 112, 36, 235, 250, 169, 126, 227, 90, 64, 102, 169, 77, 219, 99, 172, 185 }, new byte[] { 192, 39, 154, 37, 189, 25, 0, 243, 250, 234, 71, 44, 94, 92, 219, 222, 73, 35, 180, 85, 28, 140, 250, 88, 36, 26, 39, 27, 3, 65, 44, 195, 247, 19, 199, 112, 142, 221, 142, 131, 55, 189, 191, 143, 126, 201, 108, 217, 215, 12, 94, 185, 243, 55, 12, 33, 71, 169, 102, 230, 162, 163, 249, 137, 142, 241, 233, 29, 157, 107, 159, 115, 173, 219, 194, 151, 65, 53, 237, 17, 111, 242, 107, 187, 75, 249, 134, 233, 234, 174, 133, 98, 235, 91, 2, 60, 6, 52, 151, 106, 114, 182, 183, 184, 17, 177, 55, 255, 195, 15, 148, 56, 47, 79, 54, 65, 71, 114, 109, 143, 18, 200, 79, 187, 118, 46, 20, 161 } });
        }
    }
}
