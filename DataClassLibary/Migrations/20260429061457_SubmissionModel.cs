using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataClassLibary.Migrations
{
    /// <inheritdoc />
    public partial class SubmissionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "SubmissionModels");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "SubmissionModels",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "SubmissionModels");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "SubmissionModels",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
