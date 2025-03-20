using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FscAppLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddMigrationInitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formulare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormularName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FormularEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormularPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormularDescription = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formulare", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Programari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramareService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramarePersons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramareTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramareDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProgramareName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ProgramareEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramarePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramareDescription = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ReviewDescription = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false),
                    ReviewDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewRate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formulare");

            migrationBuilder.DropTable(
                name: "Programari");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
