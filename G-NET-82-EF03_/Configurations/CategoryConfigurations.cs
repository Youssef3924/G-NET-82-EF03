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
    internal class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> C)
        {
            C.HasKey(C => C.Id);

            C.Property(C => C.Id).UseIdentityColumn(1, 1);

            C.HasOne(C => C.ParentCategory)
                .WithMany(C => C.SubCategories)
                .HasForeignKey(C=>C.ParentID)
                .OnDelete(DeleteBehavior.Restrict);

            C.Property(C => C.Name)
                 .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


            C.Property(C => C.Description)
                .HasColumnType("varchar")
                .HasMaxLength(300)
                .IsRequired(false);
        }
    }
}
