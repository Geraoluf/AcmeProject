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
     new SerialNumberModel { Id = 1, SerialNumber = "ACME-001-NH35" },
     new SerialNumberModel { Id = 2, SerialNumber = "ACME-002-C17T" },
     new SerialNumberModel { Id = 3, SerialNumber = "ACME-003-PNDQ" },
     new SerialNumberModel { Id = 4, SerialNumber = "ACME-004-QBRA" },
     new SerialNumberModel { Id = 5, SerialNumber = "ACME-005-XWWT" },
     new SerialNumberModel { Id = 6, SerialNumber = "ACME-006-WFH0" },
     new SerialNumberModel { Id = 7, SerialNumber = "ACME-007-3GH0" },
     new SerialNumberModel { Id = 8, SerialNumber = "ACME-008-V535" },
     new SerialNumberModel { Id = 9, SerialNumber = "ACME-009-JHWC" },
     new SerialNumberModel { Id = 10, SerialNumber = "ACME-010-TXF1" },
     new SerialNumberModel { Id = 11, SerialNumber = "ACME-011-86XB" },
     new SerialNumberModel { Id = 12, SerialNumber = "ACME-012-EHKV" },
     new SerialNumberModel { Id = 13, SerialNumber = "ACME-013-TUUN" },
     new SerialNumberModel { Id = 14, SerialNumber = "ACME-014-YX78" },
     new SerialNumberModel { Id = 15, SerialNumber = "ACME-015-71ML" },
     new SerialNumberModel { Id = 16, SerialNumber = "ACME-016-56S1" },
     new SerialNumberModel { Id = 17, SerialNumber = "ACME-017-KQ3F" },
     new SerialNumberModel { Id = 18, SerialNumber = "ACME-018-A1XG" },
     new SerialNumberModel { Id = 19, SerialNumber = "ACME-019-TFFV" },
     new SerialNumberModel { Id = 20, SerialNumber = "ACME-020-222K" },
     new SerialNumberModel { Id = 21, SerialNumber = "ACME-021-1FWZ" },
     new SerialNumberModel { Id = 22, SerialNumber = "ACME-022-J6Y4" },
     new SerialNumberModel { Id = 23, SerialNumber = "ACME-023-QE01" },
     new SerialNumberModel { Id = 24, SerialNumber = "ACME-024-CO2A" },
     new SerialNumberModel { Id = 25, SerialNumber = "ACME-025-FRMQ" },
     new SerialNumberModel { Id = 26, SerialNumber = "ACME-026-C0HI" },
     new SerialNumberModel { Id = 27, SerialNumber = "ACME-027-FXGR" },
     new SerialNumberModel { Id = 28, SerialNumber = "ACME-028-OAE8" },
     new SerialNumberModel { Id = 29, SerialNumber = "ACME-029-8ZTI" },
     new SerialNumberModel { Id = 30, SerialNumber = "ACME-030-NE8H" },
     new SerialNumberModel { Id = 31, SerialNumber = "ACME-031-XF27" },
     new SerialNumberModel { Id = 32, SerialNumber = "ACME-032-P7X1" },
     new SerialNumberModel { Id = 33, SerialNumber = "ACME-033-4XLN" },
     new SerialNumberModel { Id = 34, SerialNumber = "ACME-034-6GE2" },
     new SerialNumberModel { Id = 35, SerialNumber = "ACME-035-ZHML" },
     new SerialNumberModel { Id = 36, SerialNumber = "ACME-036-DEGT" },
     new SerialNumberModel { Id = 37, SerialNumber = "ACME-037-VIIK" },
     new SerialNumberModel { Id = 38, SerialNumber = "ACME-038-FI9O" },
     new SerialNumberModel { Id = 39, SerialNumber = "ACME-039-17FP" },
     new SerialNumberModel { Id = 40, SerialNumber = "ACME-040-SNYJ" },
     new SerialNumberModel { Id = 41, SerialNumber = "ACME-041-F84J" },
     new SerialNumberModel { Id = 42, SerialNumber = "ACME-042-AOST" },
     new SerialNumberModel { Id = 43, SerialNumber = "ACME-043-JY0A" },
     new SerialNumberModel { Id = 44, SerialNumber = "ACME-044-CZ3T" },
     new SerialNumberModel { Id = 45, SerialNumber = "ACME-045-0C63" },
     new SerialNumberModel { Id = 46, SerialNumber = "ACME-046-245L" },
     new SerialNumberModel { Id = 47, SerialNumber = "ACME-047-3OLZ" },
     new SerialNumberModel { Id = 48, SerialNumber = "ACME-048-MD5T" },
     new SerialNumberModel { Id = 49, SerialNumber = "ACME-049-DSZ4" },
     new SerialNumberModel { Id = 50, SerialNumber = "ACME-050-4CEA" },
     new SerialNumberModel { Id = 51, SerialNumber = "ACME-051-6GF9" },
     new SerialNumberModel { Id = 52, SerialNumber = "ACME-052-YRNA" },
     new SerialNumberModel { Id = 53, SerialNumber = "ACME-053-T5XY" },
     new SerialNumberModel { Id = 54, SerialNumber = "ACME-054-0XRH" },
     new SerialNumberModel { Id = 55, SerialNumber = "ACME-055-FHPF" },
     new SerialNumberModel { Id = 56, SerialNumber = "ACME-056-Z9HH" },
     new SerialNumberModel { Id = 57, SerialNumber = "ACME-057-6TUA" },
     new SerialNumberModel { Id = 58, SerialNumber = "ACME-058-7NA0" },
     new SerialNumberModel { Id = 59, SerialNumber = "ACME-059-NAVM" },
     new SerialNumberModel { Id = 60, SerialNumber = "ACME-060-6FYT" },
     new SerialNumberModel { Id = 61, SerialNumber = "ACME-061-W5FP" },
     new SerialNumberModel { Id = 62, SerialNumber = "ACME-062-6JBS" },
     new SerialNumberModel { Id = 63, SerialNumber = "ACME-063-J85Z" },
     new SerialNumberModel { Id = 64, SerialNumber = "ACME-064-A8UG" },
     new SerialNumberModel { Id = 65, SerialNumber = "ACME-065-AGVF" },
     new SerialNumberModel { Id = 66, SerialNumber = "ACME-066-G8LW" },
     new SerialNumberModel { Id = 67, SerialNumber = "ACME-067-CSWX" },
     new SerialNumberModel { Id = 68, SerialNumber = "ACME-068-EF0P" },
     new SerialNumberModel { Id = 69, SerialNumber = "ACME-069-C3YX" },
     new SerialNumberModel { Id = 70, SerialNumber = "ACME-070-V4FO" },
     new SerialNumberModel { Id = 71, SerialNumber = "ACME-071-7M1N" },
     new SerialNumberModel { Id = 72, SerialNumber = "ACME-072-6IRR" },
     new SerialNumberModel { Id = 73, SerialNumber = "ACME-073-85IQ" },
     new SerialNumberModel { Id = 74, SerialNumber = "ACME-074-7IGO" },
     new SerialNumberModel { Id = 75, SerialNumber = "ACME-075-GUS0" },
     new SerialNumberModel { Id = 76, SerialNumber = "ACME-076-YE3S" },
     new SerialNumberModel { Id = 77, SerialNumber = "ACME-077-HU26" },
     new SerialNumberModel { Id = 78, SerialNumber = "ACME-078-95K9" },
     new SerialNumberModel { Id = 79, SerialNumber = "ACME-079-51U5" },
     new SerialNumberModel { Id = 80, SerialNumber = "ACME-080-2R0N" },
     new SerialNumberModel { Id = 81, SerialNumber = "ACME-081-LPVH" },
     new SerialNumberModel { Id = 82, SerialNumber = "ACME-082-9371" },
     new SerialNumberModel { Id = 83, SerialNumber = "ACME-083-ADEH" },
     new SerialNumberModel { Id = 84, SerialNumber = "ACME-084-9EEO" },
     new SerialNumberModel { Id = 85, SerialNumber = "ACME-085-49OL" },
     new SerialNumberModel { Id = 86, SerialNumber = "ACME-086-ANOB" },
     new SerialNumberModel { Id = 87, SerialNumber = "ACME-087-DLSW" },
     new SerialNumberModel { Id = 88, SerialNumber = "ACME-088-11B2" },
     new SerialNumberModel { Id = 89, SerialNumber = "ACME-089-HTEF" },
     new SerialNumberModel { Id = 90, SerialNumber = "ACME-090-4BMH" },
     new SerialNumberModel { Id = 91, SerialNumber = "ACME-091-PX93" },
     new SerialNumberModel { Id = 92, SerialNumber = "ACME-092-04MA" },
     new SerialNumberModel { Id = 93, SerialNumber = "ACME-093-SJYM" },
     new SerialNumberModel { Id = 94, SerialNumber = "ACME-094-QSQM" },
     new SerialNumberModel { Id = 95, SerialNumber = "ACME-095-K9BV" },
     new SerialNumberModel { Id = 96, SerialNumber = "ACME-096-Y875" },
     new SerialNumberModel { Id = 97, SerialNumber = "ACME-097-08EN" },
     new SerialNumberModel { Id = 98, SerialNumber = "ACME-098-3719" },
     new SerialNumberModel { Id = 99, SerialNumber = "ACME-099-LJNZ" },
     new SerialNumberModel { Id = 100, SerialNumber = "ACME-100-F69H" }
 );

        } 
        


    }
}
