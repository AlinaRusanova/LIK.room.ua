using LIK.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIK.Persistence.Configurations
{
    public class ClothingConfiguration : IEntityTypeConfiguration<Clothing>
    {
        public void Configure(EntityTypeBuilder<Clothing> builder)
        {
            builder.HasKey(cl => cl.Id);
            builder.HasIndex(cl => cl.Id).IsUnique();

            builder.Property(p => p.Model)
                .IsRequired().HasMaxLength(50); // TODO use shared constants for maxLen
        }
    }
}
