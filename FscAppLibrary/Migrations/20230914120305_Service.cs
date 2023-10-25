using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FscAppLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Service : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProgramareTimp",
                table: "Programari",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProgramareTimp",
                table: "Programari");
        }
    }
}
