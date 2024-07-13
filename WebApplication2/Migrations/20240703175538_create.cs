using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Work_experience = table.Column<int>(type: "int", nullable: false),
                    Categori = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Birthday", "Categori", "FirstName", "LastName", "Name", "Work_experience" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LOR", "Grec", "Ivanivuch", "Stepan", 5 },
                    { 2, new DateTime(1988, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "TERAPEVT", "Ivanov", "Ivanivuch", "Stanislav", 6 },
                    { 3, new DateTime(1981, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "SURGEON", "Sidorov", "Romanovich", "Sergii", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
