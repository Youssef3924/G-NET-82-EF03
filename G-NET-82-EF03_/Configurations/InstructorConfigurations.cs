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
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(I => I.Id);
            I.Property(I => I.Id).UseIdentityColumn(1, 1);
            
            I.Property(I=>I.FullName).HasColumnType("varchar")
                .HasMaxLength(200);

            I.Property(I => I.Email).HasColumnType("varchar")
                          .HasMaxLength(200)
                          .IsRequired();

            I.Property(I => I.Bio).HasColumnType("varchar")
              .HasMaxLength(400)
              .IsRequired(false);

        }
    }
}
