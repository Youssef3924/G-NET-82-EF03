using G_NET_82_EF03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_82_EF03.Configurations
{
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.HasKey(C => C.Id);

            C.Property(C => C.Id).UseIdentityColumn(1, 1);

            C.HasOne(I=>I.instructor)
                .WithMany(C=>C.Courses)
                .HasForeignKey(I => I.InstructorID)
                .OnDelete(DeleteBehavior.Restrict);

            C.Property(C => C.PublishedAt).IsRequired(false);

            C.Property(C => C.Title)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            C.Property(C => C.Title)
                .HasColumnType("varchar")
                .HasMaxLength(300)
                .IsRequired();

            C.Property(C => C.Price).HasPrecision(10,2).IsRequired();





        }
    }
}
