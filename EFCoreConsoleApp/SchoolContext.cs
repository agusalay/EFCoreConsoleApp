using EFCoreConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreConsoleApp
{
    public partial class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                 new Student { StudentId = 1,  Name = "Abhimanyu K Vatsa" , CourseId = 1},
                 new Student { StudentId = 2, Name = "Deepak Kumar Gupta" , CourseId = 1 },
                 new Student { StudentId = 3, Name = "Manish Kumar" ,CourseId = 2 },
                 new Student { StudentId = 4, Name = "Rohit Ranjan" ,CourseId = 3 },
                 new Student { StudentId = 5, Name = "Shivam" ,CourseId = 4 });


            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, CourseName = "CourseName 1" , StartDate = DateTime.Now.AddDays(5), EndDate = DateTime.Now.AddDays(30)},
                new Course { CourseId = 2, CourseName = "CourseName 2", StartDate = DateTime.Now.AddDays(5), EndDate = DateTime.Now.AddDays(30) },
                new Course { CourseId = 3, CourseName = "CourseName 3", StartDate = DateTime.Now.AddDays(-1), EndDate = DateTime.Now.AddDays(30) },
                new Course { CourseId = 4, CourseName = "CourseName 4", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(30) },
                new Course { CourseId = 5, CourseName = "CourseName 5", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(30) });

        }
    }
}
