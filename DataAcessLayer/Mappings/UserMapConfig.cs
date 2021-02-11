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
            builder.Property(a => a.Weight_Objective).IsRequired(false);
            builder.Property(a => a.Days_To_Reach_Goal).IsRequired(false);
            builder.HasOne(c => c.Restriction).WithOne(c => c.User).HasForeignKey<Restriction>(c => c.UserID);
        }
    }
}
