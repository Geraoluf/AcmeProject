using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AppDbContext   : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<SerialNumberModel> SerialNumbers { get; set; }
        public DbSet<SubmissionModel> SubmissionModels  { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SerialNumberModel>().HasData(
                new SerialNumberModel { Id = 1, SerialNumber = "ACME-001" },
                new SerialNumberModel { Id = 2, SerialNumber = "ACME-002" },
                new SerialNumberModel { Id = 3, SerialNumber = "ACME-003" },
                new SerialNumberModel { Id = 4, SerialNumber = "ACME-004" },
                new SerialNumberModel { Id = 5, SerialNumber = "ACME-005" },
                new SerialNumberModel { Id = 6, SerialNumber = "ACME-006" },
                new SerialNumberModel { Id = 7, SerialNumber = "ACME-007" },
                new SerialNumberModel { Id = 8, SerialNumber = "ACME-008" },
                new SerialNumberModel { Id = 9, SerialNumber = "ACME-009" },
                new SerialNumberModel { Id = 10, SerialNumber = "ACME-010" },
                new SerialNumberModel { Id = 11, SerialNumber = "ACME-011" },
                new SerialNumberModel { Id = 12, SerialNumber = "ACME-012" },
                new SerialNumberModel { Id = 13, SerialNumber = "ACME-013" },
                new SerialNumberModel { Id = 14, SerialNumber = "ACME-014" },
                new SerialNumberModel { Id = 15, SerialNumber = "ACME-015" },
                new SerialNumberModel { Id = 16, SerialNumber = "ACME-016" },
                new SerialNumberModel { Id = 17, SerialNumber = "ACME-017" },
                new SerialNumberModel { Id = 18, SerialNumber = "ACME-018" },
                new SerialNumberModel { Id = 19, SerialNumber = "ACME-019" },
                new SerialNumberModel { Id = 20, SerialNumber = "ACME-020" },
                new SerialNumberModel { Id = 21, SerialNumber = "ACME-021" },
                new SerialNumberModel { Id = 22, SerialNumber = "ACME-022" },
                new SerialNumberModel { Id = 23, SerialNumber = "ACME-023" },
                new SerialNumberModel { Id = 24, SerialNumber = "ACME-024" },
                new SerialNumberModel { Id = 25, SerialNumber = "ACME-025" },
                new SerialNumberModel { Id = 26, SerialNumber = "ACME-026" },
                new SerialNumberModel { Id = 27, SerialNumber = "ACME-027" },
                new SerialNumberModel { Id = 28, SerialNumber = "ACME-028" },
                new SerialNumberModel { Id = 29, SerialNumber = "ACME-029" },
                new SerialNumberModel { Id = 30, SerialNumber = "ACME-030" },
                new SerialNumberModel { Id = 31, SerialNumber = "ACME-031" },
                new SerialNumberModel { Id = 32, SerialNumber = "ACME-032" },
                new SerialNumberModel { Id = 33, SerialNumber = "ACME-033" },
                new SerialNumberModel { Id = 34, SerialNumber = "ACME-034" },
                new SerialNumberModel { Id = 35, SerialNumber = "ACME-035" },
                new SerialNumberModel { Id = 36, SerialNumber = "ACME-036" },
                new SerialNumberModel { Id = 37, SerialNumber = "ACME-037" },
                new SerialNumberModel { Id = 38, SerialNumber = "ACME-038" },
                new SerialNumberModel { Id = 39, SerialNumber = "ACME-039" },
                new SerialNumberModel { Id = 40, SerialNumber = "ACME-040" },
                new SerialNumberModel { Id = 41, SerialNumber = "ACME-041" },
                new SerialNumberModel { Id = 42, SerialNumber = "ACME-042" },
                new SerialNumberModel { Id = 43, SerialNumber = "ACME-043" },
                new SerialNumberModel { Id = 44, SerialNumber = "ACME-044" },
                new SerialNumberModel { Id = 45, SerialNumber = "ACME-045" },
                new SerialNumberModel { Id = 46, SerialNumber = "ACME-046" },
                new SerialNumberModel { Id = 47, SerialNumber = "ACME-047" },
                new SerialNumberModel { Id = 48, SerialNumber = "ACME-048" },
                new SerialNumberModel { Id = 49, SerialNumber = "ACME-049" },
                new SerialNumberModel { Id = 50, SerialNumber = "ACME-050" },
                new SerialNumberModel { Id = 51, SerialNumber = "ACME-051" },
                new SerialNumberModel { Id = 52, SerialNumber = "ACME-052" },
                new SerialNumberModel { Id = 53, SerialNumber = "ACME-053" },
                new SerialNumberModel { Id = 54, SerialNumber = "ACME-054" },
                new SerialNumberModel { Id = 55, SerialNumber = "ACME-055" },
                new SerialNumberModel { Id = 56, SerialNumber = "ACME-056" },
                new SerialNumberModel { Id = 57, SerialNumber = "ACME-057" },
                new SerialNumberModel { Id = 58, SerialNumber = "ACME-058" },
                new SerialNumberModel { Id = 59, SerialNumber = "ACME-059" },
                new SerialNumberModel { Id = 60, SerialNumber = "ACME-060" },
                new SerialNumberModel { Id = 61, SerialNumber = "ACME-061" },
                new SerialNumberModel { Id = 62, SerialNumber = "ACME-062" },
                new SerialNumberModel { Id = 63, SerialNumber = "ACME-063" },
                new SerialNumberModel { Id = 64, SerialNumber = "ACME-064" },
                new SerialNumberModel { Id = 65, SerialNumber = "ACME-065" },
                new SerialNumberModel { Id = 66, SerialNumber = "ACME-066" },
                new SerialNumberModel { Id = 67, SerialNumber = "ACME-067" },
                new SerialNumberModel { Id = 68, SerialNumber = "ACME-068" },
                new SerialNumberModel { Id = 69, SerialNumber = "ACME-069" },
                new SerialNumberModel { Id = 70, SerialNumber = "ACME-070" },
                new SerialNumberModel { Id = 71, SerialNumber = "ACME-071" },
                new SerialNumberModel { Id = 72, SerialNumber = "ACME-072" },
                new SerialNumberModel { Id = 73, SerialNumber = "ACME-073" },
                new SerialNumberModel { Id = 74, SerialNumber = "ACME-074" },
                new SerialNumberModel { Id = 75, SerialNumber = "ACME-075" },
                new SerialNumberModel { Id = 76, SerialNumber = "ACME-076" },
                new SerialNumberModel { Id = 77, SerialNumber = "ACME-077" },
                new SerialNumberModel { Id = 78, SerialNumber = "ACME-078" },
                new SerialNumberModel { Id = 79, SerialNumber = "ACME-079" },
                new SerialNumberModel { Id = 80, SerialNumber = "ACME-080" },
                new SerialNumberModel { Id = 81, SerialNumber = "ACME-081" },
                new SerialNumberModel { Id = 82, SerialNumber = "ACME-082" },
                new SerialNumberModel { Id = 83, SerialNumber = "ACME-083" },
                new SerialNumberModel { Id = 84, SerialNumber = "ACME-084" },
                new SerialNumberModel { Id = 85, SerialNumber = "ACME-085" },
                new SerialNumberModel { Id = 86, SerialNumber = "ACME-086" },
                new SerialNumberModel { Id = 87, SerialNumber = "ACME-087" },
                new SerialNumberModel { Id = 88, SerialNumber = "ACME-088" },
                new SerialNumberModel { Id = 89, SerialNumber = "ACME-089" },
                new SerialNumberModel { Id = 90, SerialNumber = "ACME-090" },
                new SerialNumberModel { Id = 91, SerialNumber = "ACME-091" },
                new SerialNumberModel { Id = 92, SerialNumber = "ACME-092" },
                new SerialNumberModel { Id = 93, SerialNumber = "ACME-093" },
                new SerialNumberModel { Id = 94, SerialNumber = "ACME-094" },
                new SerialNumberModel { Id = 95, SerialNumber = "ACME-095" },
                new SerialNumberModel { Id = 96, SerialNumber = "ACME-096" },
                new SerialNumberModel { Id = 97, SerialNumber = "ACME-097" },
                new SerialNumberModel { Id = 98, SerialNumber = "ACME-098" },
                new SerialNumberModel { Id = 99, SerialNumber = "ACME-099" },
                new SerialNumberModel { Id = 100, SerialNumber = "ACME-100" }
            );

        } 
        


    }
}
