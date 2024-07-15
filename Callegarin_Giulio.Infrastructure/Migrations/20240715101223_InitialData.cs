using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Callegarin_Giulio.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "ProfessorId", "FirstName", "LastName", "PrefersVideo", "ReceptionAvailability", "Specialization", "TeachingAvailability", "YearsOfExperience" },
                values: new object[,]
                {
                    { new Guid("3fda0d02-eded-4c1e-ac56-ee17d54c1481"), "Silvia", "Zuliani", true, "Thursday,Friday,Saturday", "IT", "Wednesday,Saturday", 5 },
                    { new Guid("97c5a08c-c14e-4773-95eb-926298ec7370"), "Stefania", "Sardi", false, "Monday,Thursday", "Math", "Monday,Thursday,Friday", 7 },
                    { new Guid("ca4a4974-90b5-4291-ad1c-4e27da44c240"), "Gianpietro", "Vecchi", false, "Tuesday,Friday", "English", "Tuesday,Thursday,Friday", 3 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "AdditionalNotes", "BirthDate", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("1aaa6fc6-56aa-454e-8a5c-33a43290b82a"), "", new DateOnly(2002, 10, 28), "stefano.bianchi@example.com", "Stefano", "Bianchi", "+393516954821" },
                    { new Guid("4e9e22ff-a2df-4688-ae14-1cfeb6371d14"), "", new DateOnly(2002, 7, 23), "franco.berrucci@example.com", "Franco", "Berrucci", "+393492546954" },
                    { new Guid("7d9ff0f9-ac3d-4037-8b9b-6f5d1128a904"), "", new DateOnly(2001, 4, 16), "gianpaolo.geppetto@example.com", "Gianpaolo", "Geppetto", "+393474526398" },
                    { new Guid("85a02d6a-05e1-40f2-a4cd-90ada9fc67f7"), "", new DateOnly(2003, 1, 8), "miriam.rossi@example.com", "Miriam", "Rossi", "+393336954712" },
                    { new Guid("9bca8410-1515-47b0-8033-1d412172c6a1"), "", new DateOnly(2002, 6, 7), "anna.carducci@example.com", "Anna", "Carducci", "+393423698562" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "ProfessorId",
                keyValue: new Guid("3fda0d02-eded-4c1e-ac56-ee17d54c1481"));

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "ProfessorId",
                keyValue: new Guid("97c5a08c-c14e-4773-95eb-926298ec7370"));

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "ProfessorId",
                keyValue: new Guid("ca4a4974-90b5-4291-ad1c-4e27da44c240"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("1aaa6fc6-56aa-454e-8a5c-33a43290b82a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("4e9e22ff-a2df-4688-ae14-1cfeb6371d14"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("7d9ff0f9-ac3d-4037-8b9b-6f5d1128a904"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("85a02d6a-05e1-40f2-a4cd-90ada9fc67f7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: new Guid("9bca8410-1515-47b0-8033-1d412172c6a1"));
        }
    }
}
