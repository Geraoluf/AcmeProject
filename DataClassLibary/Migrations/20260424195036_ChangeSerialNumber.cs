using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataClassLibary.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSerialNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "SerialNumbers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "SerialNumbers");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "SerialNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 18,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 19,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 29,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 36,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 37,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 38,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 39,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 40,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 41,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 42,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 43,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 44,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 45,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 46,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 47,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 48,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 49,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 50,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 51,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 52,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 53,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 54,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 55,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 56,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 57,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 58,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 59,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 60,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 61,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 62,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 63,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 64,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 65,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 66,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 67,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 68,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 69,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 70,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 71,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 72,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 73,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 74,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 75,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 76,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 77,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 78,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 79,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 80,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 81,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 82,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 83,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 84,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 85,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 86,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 87,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 88,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 89,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 90,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 91,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 92,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 93,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 94,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 95,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 96,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 97,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 98,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 99,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 100,
                column: "Count",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "SerialNumbers");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SerialNumbers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "SerialNumbers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { null, null });
        }
    }
}
