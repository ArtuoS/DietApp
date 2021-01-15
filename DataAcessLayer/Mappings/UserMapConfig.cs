using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Mappings
{
    internal class UserMapConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(a => a.First_Name).HasMaxLength(40).IsRequired().IsUnicode();
            builder.Property(b => b.Last_Name).HasMaxLength(40).IsRequired().IsUnicode();
            builder.Property(c => c.Email).HasMaxLength(255).IsRequired().IsUnicode();
            builder.HasIndex(c => c.Email).IsUnique();
        }
    }
}
