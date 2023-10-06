using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity110.Models;

namespace ContosoUniversity110.Data
{
    public class ContosoUniversity110Context : DbContext
    {
        public ContosoUniversity110Context (DbContextOptions<ContosoUniversity110Context> options)
            : base(options)
        {
        }

        //public DbSet<ContosoUniversity110.Models.Student> Student { get; set; } = default!;

        //public DbSet<ContosoUniversity110.Models.Course>? Course { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
