using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FscAppLibrary.Migrations
{
    /// <inheritdoc />
    public partial class BugFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewName",
                table: "Reviews",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ReviewDescription",
                table: "Reviews",
                type: "varchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProgramareService",
                table: "Programari",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ProgramarePhone",
                table: "Programari",
                type: "varchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(12",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "ProgramareName",
                table: "Programari",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ProgramareEmail",
                table: "Programari",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ProgramareDescription",
                table: "Programari",
                type: "varchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FormularPhone",
                table: "Formulare",
                type: "varchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(12",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "FormularName",
                table: "Formulare",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FormularEmail",
                table: "Formulare",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FormularDescription",
                table: "Formulare",
                type: "varchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ComentariuName",
                table: "Comentarii",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ComentariuDescription",
                table: "Comentarii",
                type: "varchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000",
                oldMaxLength: 2000,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewName",
                table: "Reviews",
                type: "varchar(50",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ReviewDescription",
                table: "Reviews",
                type: "varchar(2000",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProgramareService",
                table: "Programari",
                type: "varchar(100",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ProgramarePhone",
                table: "Programari",
                type: "varchar(12",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "ProgramareName",
                table: "Programari",
                type: "varchar(50",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ProgramareEmail",
                table: "Programari",
                type: "varchar(100",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ProgramareDescription",
                table: "Programari",
                type: "varchar(2000",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FormularPhone",
                table: "Formulare",
                type: "varchar(12",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "FormularName",
                table: "Formulare",
                type: "varchar(50",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FormularEmail",
                table: "Formulare",
                type: "varchar(100",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FormularDescription",
                table: "Formulare",
                type: "varchar(2000",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ComentariuName",
                table: "Comentarii",
                type: "varchar(50",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ComentariuDescription",
                table: "Comentarii",
                type: "varchar(2000",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);
        }
    }
}
