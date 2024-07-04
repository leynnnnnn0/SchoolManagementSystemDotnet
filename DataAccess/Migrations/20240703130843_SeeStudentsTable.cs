using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeeStudentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "DateOfBirth", "FirstName", "LastName", "ProfilePicture" },
                values: new object[,]
                {
                    { 1, "Manila, Philippines", new DateOnly(2002, 8, 12), "Nathaniel", "Alvarez", "" },
                    { 2, "Quezon City, Philippines", new DateOnly(2002, 8, 12), "Alyssa", "Gonzales", "" },
                    { 3, "Cebu City, Philippines", new DateOnly(2002, 8, 12), "Joshua", "Reyes", "" },
                    { 4, "Davao City, Philippines", new DateOnly(2002, 8, 12), "Isabella", "Santos", "" },
                    { 5, "Makati, Philippines", new DateOnly(2002, 8, 12), "Miguel", "Torres", "" },
                    { 6, "Pasig, Philippines", new DateOnly(2002, 8, 12), "Sophia", "Cruz", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
