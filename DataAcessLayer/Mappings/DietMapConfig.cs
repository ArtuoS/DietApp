using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Mappings
{
    internal class DietMapConfig : IEntityTypeConfiguration<Diet>
    {
        public void Configure(EntityTypeBuilder<Diet> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(40).IsRequired().IsUnicode();
            builder.Property(a => a.Status).IsRequired();
            builder.Property(a => a.Date).IsRequired();
        }
    }
}
