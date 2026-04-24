using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataClassLibary.Migrations
{
    /// <inheritdoc />
    public partial class IniiaMigration : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Submissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "Email", "FirstName", "SerialNumber" },
                values: new object[,]
                {
                    { 1, null, null, "ACME-001" },
                    { 2, null, null, "ACME-002" },
                    { 3, null, null, "ACME-003" },
                    { 4, null, null, "ACME-004" },
                    { 5, null, null, "ACME-005" },
                    { 6, null, null, "ACME-006" },
                    { 7, null, null, "ACME-007" },
                    { 8, null, null, "ACME-008" },
                    { 9, null, null, "ACME-009" },
                    { 10, null, null, "ACME-010" },
                    { 11, null, null, "ACME-011" },
                    { 12, null, null, "ACME-012" },
                    { 13, null, null, "ACME-013" },
                    { 14, null, null, "ACME-014" },
                    { 15, null, null, "ACME-015" },
                    { 16, null, null, "ACME-016" },
                    { 17, null, null, "ACME-017" },
                    { 18, null, null, "ACME-018" },
                    { 19, null, null, "ACME-019" },
                    { 20, null, null, "ACME-020" },
                    { 21, null, null, "ACME-021" },
                    { 22, null, null, "ACME-022" },
                    { 23, null, null, "ACME-023" },
                    { 24, null, null, "ACME-024" },
                    { 25, null, null, "ACME-025" },
                    { 26, null, null, "ACME-026" },
                    { 27, null, null, "ACME-027" },
                    { 28, null, null, "ACME-028" },
                    { 29, null, null, "ACME-029" },
                    { 30, null, null, "ACME-030" },
                    { 31, null, null, "ACME-031" },
                    { 32, null, null, "ACME-032" },
                    { 33, null, null, "ACME-033" },
                    { 34, null, null, "ACME-034" },
                    { 35, null, null, "ACME-035" },
                    { 36, null, null, "ACME-036" },
                    { 37, null, null, "ACME-037" },
                    { 38, null, null, "ACME-038" },
                    { 39, null, null, "ACME-039" },
                    { 40, null, null, "ACME-040" },
                    { 41, null, null, "ACME-041" },
                    { 42, null, null, "ACME-042" },
                    { 43, null, null, "ACME-043" },
                    { 44, null, null, "ACME-044" },
                    { 45, null, null, "ACME-045" },
                    { 46, null, null, "ACME-046" },
                    { 47, null, null, "ACME-047" },
                    { 48, null, null, "ACME-048" },
                    { 49, null, null, "ACME-049" },
                    { 50, null, null, "ACME-050" },
                    { 51, null, null, "ACME-051" },
                    { 52, null, null, "ACME-052" },
                    { 53, null, null, "ACME-053" },
                    { 54, null, null, "ACME-054" },
                    { 55, null, null, "ACME-055" },
                    { 56, null, null, "ACME-056" },
                    { 57, null, null, "ACME-057" },
                    { 58, null, null, "ACME-058" },
                    { 59, null, null, "ACME-059" },
                    { 60, null, null, "ACME-060" },
                    { 61, null, null, "ACME-061" },
                    { 62, null, null, "ACME-062" },
                    { 63, null, null, "ACME-063" },
                    { 64, null, null, "ACME-064" },
                    { 65, null, null, "ACME-065" },
                    { 66, null, null, "ACME-066" },
                    { 67, null, null, "ACME-067" },
                    { 68, null, null, "ACME-068" },
                    { 69, null, null, "ACME-069" },
                    { 70, null, null, "ACME-070" },
                    { 71, null, null, "ACME-071" },
                    { 72, null, null, "ACME-072" },
                    { 73, null, null, "ACME-073" },
                    { 74, null, null, "ACME-074" },
                    { 75, null, null, "ACME-075" },
                    { 76, null, null, "ACME-076" },
                    { 77, null, null, "ACME-077" },
                    { 78, null, null, "ACME-078" },
                    { 79, null, null, "ACME-079" },
                    { 80, null, null, "ACME-080" },
                    { 81, null, null, "ACME-081" },
                    { 82, null, null, "ACME-082" },
                    { 83, null, null, "ACME-083" },
                    { 84, null, null, "ACME-084" },
                    { 85, null, null, "ACME-085" },
                    { 86, null, null, "ACME-086" },
                    { 87, null, null, "ACME-087" },
                    { 88, null, null, "ACME-088" },
                    { 89, null, null, "ACME-089" },
                    { 90, null, null, "ACME-090" },
                    { 91, null, null, "ACME-091" },
                    { 92, null, null, "ACME-092" },
                    { 93, null, null, "ACME-093" },
                    { 94, null, null, "ACME-094" },
                    { 95, null, null, "ACME-095" },
                    { 96, null, null, "ACME-096" },
                    { 97, null, null, "ACME-097" },
                    { 98, null, null, "ACME-098" },
                    { 99, null, null, "ACME-099" },
                    { 100, null, null, "ACME-100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SerialNumbers");

            migrationBuilder.DropTable(
                name: "Submissions");
        }
    }
}
