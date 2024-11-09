﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarJournal.Migrations
{
    /// <inheritdoc />
    public partial class CarModelNotUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars_Model",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 70, 162, 6, 255, 9, 99, 203, 219, 196, 216, 197, 113, 45, 65, 124, 253, 37, 25, 74, 114, 134, 222, 42, 212, 134, 124, 237, 9, 133, 136, 98, 246, 202, 244, 56, 92, 135, 157, 224, 145, 235, 233, 236, 165, 34, 246, 249, 184, 191, 28, 119, 225, 123, 26, 237, 134, 134, 158, 80, 243, 103, 21, 66, 106 }, new byte[] { 35, 80, 125, 75, 100, 71, 75, 136, 55, 43, 25, 145, 224, 246, 33, 208, 22, 143, 101, 217, 135, 26, 229, 56, 215, 207, 214, 246, 159, 168, 13, 14, 190, 92, 180, 171, 24, 28, 224, 138, 210, 223, 55, 36, 28, 234, 181, 69, 63, 30, 177, 148, 223, 227, 159, 140, 68, 225, 113, 194, 76, 250, 130, 22, 246, 103, 167, 142, 183, 223, 74, 178, 206, 150, 80, 197, 203, 162, 82, 175, 228, 73, 134, 209, 205, 250, 183, 202, 24, 50, 69, 88, 59, 12, 227, 45, 251, 102, 210, 88, 182, 127, 73, 71, 107, 163, 236, 50, 249, 17, 161, 90, 63, 130, 48, 32, 11, 190, 2, 17, 68, 2, 148, 164, 44, 217, 89, 70 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 114, 144, 20, 233, 66, 110, 48, 3, 56, 18, 127, 90, 249, 116, 170, 93, 253, 94, 233, 66, 114, 202, 12, 245, 174, 87, 47, 19, 244, 196, 101, 123, 35, 251, 135, 41, 39, 187, 145, 238, 35, 155, 194, 14, 112, 37, 31, 223, 133, 101, 217, 54, 200, 33, 71, 145, 79, 135, 163, 93, 202, 163, 197, 60 }, new byte[] { 5, 123, 168, 197, 43, 202, 104, 74, 91, 158, 51, 133, 30, 232, 170, 238, 214, 169, 151, 111, 98, 93, 188, 160, 25, 47, 79, 88, 71, 2, 146, 202, 182, 188, 145, 189, 4, 27, 104, 173, 25, 216, 232, 41, 5, 10, 208, 61, 220, 199, 234, 25, 115, 195, 154, 59, 27, 71, 161, 196, 173, 250, 120, 118, 7, 10, 252, 102, 16, 76, 195, 146, 98, 148, 2, 91, 215, 178, 109, 170, 82, 198, 56, 221, 10, 134, 171, 54, 53, 191, 99, 42, 70, 174, 36, 163, 161, 143, 225, 254, 187, 51, 144, 86, 15, 31, 248, 119, 227, 183, 92, 188, 39, 254, 161, 227, 76, 8, 116, 70, 216, 10, 162, 228, 14, 60, 233, 68 } });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_Model",
                table: "Cars",
                column: "Model",
                unique: true);
        }
    }
}