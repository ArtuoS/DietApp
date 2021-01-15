using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Mappings
{
    internal class RestrictionMapConfig : IEntityTypeConfiguration<Restriction>
    {
        public void Configure(EntityTypeBuilder<Restriction> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(40).IsRequired().IsUnicode();
        }
    }
}
