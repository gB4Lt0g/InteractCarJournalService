﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarJournal.Migrations
{
    /// <inheritdoc />
    public partial class MakeMileageAtStartNotNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 207, 30, 148, 127, 214, 231, 181, 106, 213, 231, 6, 142, 232, 174, 190, 178, 98, 190, 154, 246, 48, 225, 43, 204, 6, 221, 42, 148, 93, 141, 209, 138, 158, 249, 189, 180, 100, 190, 233, 199, 226, 168, 231, 61, 236, 122, 90, 131, 114, 32, 143, 112, 99, 81, 49, 189, 78, 99, 54, 214, 204, 103, 16, 223 }, new byte[] { 225, 6, 95, 11, 205, 153, 33, 105, 89, 90, 167, 233, 213, 192, 182, 200, 8, 183, 34, 106, 248, 33, 13, 168, 26, 17, 47, 3, 250, 121, 156, 164, 102, 148, 7, 118, 16, 52, 244, 177, 226, 78, 15, 68, 52, 47, 184, 218, 229, 96, 164, 63, 28, 162, 116, 108, 57, 62, 81, 67, 219, 56, 93, 133, 85, 83, 239, 84, 153, 152, 138, 31, 198, 103, 172, 13, 189, 89, 215, 204, 150, 203, 100, 134, 210, 1, 252, 251, 2, 235, 170, 27, 61, 227, 135, 76, 130, 139, 100, 110, 50, 218, 167, 245, 241, 248, 245, 46, 246, 123, 166, 244, 180, 255, 88, 44, 2, 51, 228, 169, 52, 191, 15, 82, 47, 250, 164, 17 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 52, 68, 81, 139, 201, 149, 225, 164, 210, 198, 123, 177, 225, 52, 159, 35, 114, 144, 150, 176, 204, 205, 137, 86, 123, 40, 137, 102, 219, 36, 132, 158, 97, 159, 64, 142, 77, 65, 196, 214, 171, 161, 131, 97, 105, 39, 66, 229, 18, 229, 237, 117, 2, 70, 160, 44, 67, 155, 191, 23, 61, 237, 131, 77 }, new byte[] { 27, 221, 254, 150, 109, 43, 3, 110, 52, 30, 142, 130, 197, 63, 89, 253, 229, 168, 13, 77, 75, 230, 25, 40, 129, 3, 243, 253, 84, 244, 59, 13, 114, 135, 156, 43, 73, 6, 202, 240, 43, 159, 127, 70, 155, 24, 165, 86, 35, 30, 74, 217, 145, 163, 230, 192, 135, 53, 181, 30, 219, 51, 123, 146, 20, 187, 54, 205, 111, 37, 185, 185, 44, 250, 14, 129, 72, 152, 218, 200, 146, 54, 204, 211, 223, 19, 203, 229, 47, 80, 228, 114, 59, 193, 34, 189, 50, 88, 176, 249, 126, 173, 43, 111, 23, 140, 79, 59, 4, 61, 132, 42, 198, 144, 74, 231, 146, 194, 159, 56, 193, 58, 100, 218, 129, 138, 101, 141 } });
        }
    }
}