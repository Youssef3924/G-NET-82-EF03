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
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {

            S.HasKey(S => S.Id);

            S.Property(S => S.Id).UseIdentityColumn(1, 1);

            S.Property(S=>S.DateOfBirth).IsRequired();

            S.Property(S => S.FullName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            S.Property(S => S.Email)
             .HasColumnType("varchar")
             .HasMaxLength(100)
             .IsRequired();

        }
    }
}
