using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie.Api.Migrations
{
    /// <inheritdoc />
    public partial class DirectorsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "DateOfBirth", "Name", "Nationality" },
                values: new object[,]
                {
                    { 1, new DateOnly(1946, 12, 18), "Steven Spielberg", "American" },
                    { 2, new DateOnly(1970, 7, 30), "Christopher Nolan", "British" },
                    { 3, new DateOnly(1963, 3, 27), "Quentin Tarantino", "American" },
                    { 4, new DateOnly(1942, 11, 17), "Martin Scorsese", "American" },
                    { 5, new DateOnly(1937, 11, 30), "Ridley Scott", "British" },
                    { 6, new DateOnly(1941, 1, 5), "Hayao Miyazaki", "Japanese" },
                    { 7, new DateOnly(1971, 5, 14), "Sofia Coppola", "American" },
                    { 8, new DateOnly(1964, 10, 9), "Guillermo del Toro", "Mexican" },
                    { 9, new DateOnly(1949, 9, 25), "Pedro Almodóvar", "Spanish" },
                    { 10, new DateOnly(1983, 8, 4), "Greta Gerwig", "American" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
