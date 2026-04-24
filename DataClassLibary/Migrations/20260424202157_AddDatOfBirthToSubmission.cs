using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataClassLibary.Migrations
{
    /// <inheritdoc />
    public partial class AddDatOfBirthToSubmission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DateOfBirth",
                table: "DrawEntryModels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "DrawEntryModels");
        }
    }
}
