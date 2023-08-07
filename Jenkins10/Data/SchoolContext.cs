using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Jenkins10.Data;
using Jenkins10.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Jenkins10.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Course>().HasData(
            new Course { CourseID = 1050, Title = "Chemistry", Credits = 3 },
            new Course { CourseID = 4022, Title = "Microeconomics", Credits = 3 },
            new Course { CourseID = 4041, Title = "Macroeconomics", Credits = 3 },
            new Course { CourseID = 1045, Title = "Calculus", Credits = 4 },
            new Course { CourseID = 3141, Title = "Trigonometry", Credits = 4 },
            new Course { CourseID = 2021, Title = "Composition", Credits = 3 },
            new Course { CourseID = 2042, Title = "Literature", Credits = 4 });


        }
    }
}
