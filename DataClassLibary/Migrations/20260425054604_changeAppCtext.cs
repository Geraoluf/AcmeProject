using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataClassLibary.Migrations
{
    /// <inheritdoc />
    public partial class changeAppCtext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DrawEntryModels",
                table: "DrawEntryModels");

            migrationBuilder.RenameTable(
                name: "DrawEntryModels",
                newName: "SubmissionModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubmissionModels",
                table: "SubmissionModels",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubmissionModels",
                table: "SubmissionModels");

            migrationBuilder.RenameTable(
                name: "SubmissionModels",
                newName: "DrawEntryModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrawEntryModels",
                table: "DrawEntryModels",
                column: "Id");
        }
    }
}
