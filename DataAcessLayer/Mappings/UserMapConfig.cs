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
            builder.Property(a => a.Last_Name).HasMaxLength(40).IsRequired().IsUnicode();
            builder.Property(a => a.Email).HasMaxLength(255).IsRequired().IsUnicode();
            builder.HasIndex(a => a.Email).IsUnique();
            builder.Property(a => a.Activity).IsRequired();
            builder.Property(a => a.Password).IsRequired();
        }
    }
}
