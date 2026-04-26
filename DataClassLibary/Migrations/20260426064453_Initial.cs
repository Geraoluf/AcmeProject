using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataClassLibary.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SerialNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubmissionModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmissionModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "Count", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 0, "ACME-001-NH35" },
                    { 2, 0, "ACME-002-C17T" },
                    { 3, 0, "ACME-003-PNDQ" },
                    { 4, 0, "ACME-004-QBRA" },
                    { 5, 0, "ACME-005-XWWT" },
                    { 6, 0, "ACME-006-WFH0" },
                    { 7, 0, "ACME-007-3GH0" },
                    { 8, 0, "ACME-008-V535" },
                    { 9, 0, "ACME-009-JHWC" },
                    { 10, 0, "ACME-010-TXF1" },
                    { 11, 0, "ACME-011-86XB" },
                    { 12, 0, "ACME-012-EHKV" },
                    { 13, 0, "ACME-013-TUUN" },
                    { 14, 0, "ACME-014-YX78" },
                    { 15, 0, "ACME-015-71ML" },
                    { 16, 0, "ACME-016-56S1" },
                    { 17, 0, "ACME-017-KQ3F" },
                    { 18, 0, "ACME-018-A1XG" },
                    { 19, 0, "ACME-019-TFFV" },
                    { 20, 0, "ACME-020-222K" },
                    { 21, 0, "ACME-021-1FWZ" },
                    { 22, 0, "ACME-022-J6Y4" },
                    { 23, 0, "ACME-023-QE01" },
                    { 24, 0, "ACME-024-CO2A" },
                    { 25, 0, "ACME-025-FRMQ" },
                    { 26, 0, "ACME-026-C0HI" },
                    { 27, 0, "ACME-027-FXGR" },
                    { 28, 0, "ACME-028-OAE8" },
                    { 29, 0, "ACME-029-8ZTI" },
                    { 30, 0, "ACME-030-NE8H" },
                    { 31, 0, "ACME-031-XF27" },
                    { 32, 0, "ACME-032-P7X1" },
                    { 33, 0, "ACME-033-4XLN" },
                    { 34, 0, "ACME-034-6GE2" },
                    { 35, 0, "ACME-035-ZHML" },
                    { 36, 0, "ACME-036-DEGT" },
                    { 37, 0, "ACME-037-VIIK" },
                    { 38, 0, "ACME-038-FI9O" },
                    { 39, 0, "ACME-039-17FP" },
                    { 40, 0, "ACME-040-SNYJ" },
                    { 41, 0, "ACME-041-F84J" },
                    { 42, 0, "ACME-042-AOST" },
                    { 43, 0, "ACME-043-JY0A" },
                    { 44, 0, "ACME-044-CZ3T" },
                    { 45, 0, "ACME-045-0C63" },
                    { 46, 0, "ACME-046-245L" },
                    { 47, 0, "ACME-047-3OLZ" },
                    { 48, 0, "ACME-048-MD5T" },
                    { 49, 0, "ACME-049-DSZ4" },
                    { 50, 0, "ACME-050-4CEA" },
                    { 51, 0, "ACME-051-6GF9" },
                    { 52, 0, "ACME-052-YRNA" },
                    { 53, 0, "ACME-053-T5XY" },
                    { 54, 0, "ACME-054-0XRH" },
                    { 55, 0, "ACME-055-FHPF" },
                    { 56, 0, "ACME-056-Z9HH" },
                    { 57, 0, "ACME-057-6TUA" },
                    { 58, 0, "ACME-058-7NA0" },
                    { 59, 0, "ACME-059-NAVM" },
                    { 60, 0, "ACME-060-6FYT" },
                    { 61, 0, "ACME-061-W5FP" },
                    { 62, 0, "ACME-062-6JBS" },
                    { 63, 0, "ACME-063-J85Z" },
                    { 64, 0, "ACME-064-A8UG" },
                    { 65, 0, "ACME-065-AGVF" },
                    { 66, 0, "ACME-066-G8LW" },
                    { 67, 0, "ACME-067-CSWX" },
                    { 68, 0, "ACME-068-EF0P" },
                    { 69, 0, "ACME-069-C3YX" },
                    { 70, 0, "ACME-070-V4FO" },
                    { 71, 0, "ACME-071-7M1N" },
                    { 72, 0, "ACME-072-6IRR" },
                    { 73, 0, "ACME-073-85IQ" },
                    { 74, 0, "ACME-074-7IGO" },
                    { 75, 0, "ACME-075-GUS0" },
                    { 76, 0, "ACME-076-YE3S" },
                    { 77, 0, "ACME-077-HU26" },
                    { 78, 0, "ACME-078-95K9" },
                    { 79, 0, "ACME-079-51U5" },
                    { 80, 0, "ACME-080-2R0N" },
                    { 81, 0, "ACME-081-LPVH" },
                    { 82, 0, "ACME-082-9371" },
                    { 83, 0, "ACME-083-ADEH" },
                    { 84, 0, "ACME-084-9EEO" },
                    { 85, 0, "ACME-085-49OL" },
                    { 86, 0, "ACME-086-ANOB" },
                    { 87, 0, "ACME-087-DLSW" },
                    { 88, 0, "ACME-088-11B2" },
                    { 89, 0, "ACME-089-HTEF" },
                    { 90, 0, "ACME-090-4BMH" },
                    { 91, 0, "ACME-091-PX93" },
                    { 92, 0, "ACME-092-04MA" },
                    { 93, 0, "ACME-093-SJYM" },
                    { 94, 0, "ACME-094-QSQM" },
                    { 95, 0, "ACME-095-K9BV" },
                    { 96, 0, "ACME-096-Y875" },
                    { 97, 0, "ACME-097-08EN" },
                    { 98, 0, "ACME-098-3719" },
                    { 99, 0, "ACME-099-LJNZ" },
                    { 100, 0, "ACME-100-F69H" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SerialNumbers");

            migrationBuilder.DropTable(
                name: "SubmissionModels");
        }
    }
}
