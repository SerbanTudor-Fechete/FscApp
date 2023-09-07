using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FscAppLibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialDbCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comentarii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComentariuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComentariuDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComentariuDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComentariuVotes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formulare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormularName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormularEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormularPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormularDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormularComments = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ProgramarePersons = table.Column<int>(type: "int", nullable: false),
                    ProgramareDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProgramareName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramareEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramarePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramareDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ReviewName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewRate = table.Column<double>(type: "float", nullable: false),
                    ReviewVotes = table.Column<int>(type: "int", nullable: false),
                    ReviewComents = table.Column<int>(type: "int", nullable: false),
                    ComentariuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Comentarii_ComentariuId",
                        column: x => x.ComentariuId,
                        principalTable: "Comentarii",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ComentariuId",
                table: "Reviews",
                column: "ComentariuId");
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

            migrationBuilder.DropTable(
                name: "Comentarii");
        }
    }
}
