using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FscAppLibrary.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProgramareTimp",
                table: "Programari",
                newName: "ProgramareTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProgramareTime",
                table: "Programari",
                newName: "ProgramareTimp");
        }
    }
}
