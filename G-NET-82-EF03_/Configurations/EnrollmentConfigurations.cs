using G_NET_82_EF03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_82_EF03_.Configurations
{
    internal class EnrollmentConfigurations : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> E)
        {
            E.ToTable(nameof(EnrollmentConfigurations)); 

            E.HasKey(K => new { K.StudentId, K.CourseId });
            E.HasOne(S => S.student)
                .WithMany(E => E.EnrollmentsOfStudent)
                .HasForeignKey(E => E.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            E.HasOne(C => C.course)
                 .WithMany(E => E.EnrollmentsOfCourse)
                 .HasForeignKey(E => E.CourseId)
                 .OnDelete(DeleteBehavior.Cascade);

            E.ToTable(E => E.HasCheckConstraint(
                "Ck_Progress_Percentage_Between_100_And_0",
                "[ProgressPercentage] between 0 And 100"));

            E.Property(E => E.ProgressPercentage).HasPrecision(10,2);
            E.Property(E => E.FinalGrade).HasPrecision(10,2).IsRequired(false);
           
        }
    }
}
