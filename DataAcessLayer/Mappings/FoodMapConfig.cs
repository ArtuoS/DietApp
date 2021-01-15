using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Mappings
{
    internal class FoodMapConfig : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(a => a.Food_Name).IsRequired().HasMaxLength(40).IsUnicode(false);
        }
    }
}
