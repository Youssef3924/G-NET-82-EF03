using G_NET_82_EF03.Configurations;
using G_NET_82_EF03.Models;
using G_NET_82_EF03_.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_82_EF03_
{
    internal class DbContext_Assignment:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=EFAssignment;Trusted_Connection=true;TrustServerCertificate=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfigurations());
            modelBuilder.ApplyConfiguration<Course>(new CourseConfigurations());
            modelBuilder.ApplyConfiguration<Enrollment>(new EnrollmentConfigurations());
            modelBuilder.ApplyConfiguration<Instructor>(new InstructorConfigurations());
            modelBuilder.ApplyConfiguration<Student>(new StudentConfigurations());
        }
    }
}
