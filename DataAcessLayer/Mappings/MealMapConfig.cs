using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Mappings
{
    internal class MealMapConfig : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
		{
            builder.Property(a => a.Name).HasMaxLength(300).IsRequired().IsUnicode();
        }
    }
}
