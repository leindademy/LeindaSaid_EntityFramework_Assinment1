using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeindaSaid_EntityFramework_Assinment1.Entity;
using Microsoft.EntityFrameworkCore;

namespace LeindaSaid_EntityFramework_Assinment1.context
{
    public class Student_Database_Context : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Student_DB;Integrated Security=True;TrustServerCertificate=True");
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
                    modelBuilder.Entity<Instructor>()
            .HasOne(i => i.department)
            .WithMany(d => d.Instructors)
            .HasForeignKey(i => i.deptId)
            .OnDelete(DeleteBehavior.SetNull);

                    modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
            .WithMany(d => d.Students)
            .HasForeignKey(s => s.deptId) // SetNull delete for Department -> Student
            .OnDelete(DeleteBehavior.SetNull);  // SetNull delete for Department -> Student

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Instructor_Course> Instructor_Courses { get; set; }



    }
}
