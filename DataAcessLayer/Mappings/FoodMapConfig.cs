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
            builder.Property(a => a.Calories).IsRequired();
            builder.Property(a => a.Alcohol).IsRequired();
            builder.Property(a => a.Carbohydrate).IsRequired();
            builder.Property(a => a.Copper).IsRequired();
            builder.Property(a => a.Fiber).IsRequired();
            builder.Property(a => a.Lipid).IsRequired();
            builder.Property(a => a.Magnesium).IsRequired();
            builder.Property(a => a.Phosphor).IsRequired();
            builder.Property(a => a.Potassium).IsRequired();
            builder.Property(a => a.Protein).IsRequired();
            builder.Property(a => a.Selenium).IsRequired();
            builder.Property(a => a.Sodium).IsRequired();
            builder.Property(a => a.Vitamin_A).IsRequired();
            builder.Property(a => a.Vitamin_B12).IsRequired();
            builder.Property(a => a.Vitamin_B6).IsRequired();
            builder.Property(a => a.Vitamin_C).IsRequired();
            builder.Property(a => a.Vitamin_D).IsRequired();
            builder.Property(a => a.Vitamin_E).IsRequired();
            builder.Property(a => a.Zinc).IsRequired();
        }
    }
}
