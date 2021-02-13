﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAcessLayer.Migrations
{
    [DbContext(typeof(DietDB))]
    partial class DietDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DietMeal", b =>
                {
                    b.Property<int>("DietsID")
                        .HasColumnType("int");

                    b.Property<int>("MealsID")
                        .HasColumnType("int");

                    b.HasKey("DietsID", "MealsID");

                    b.HasIndex("MealsID");

                    b.ToTable("DietMeal");
                });

            modelBuilder.Entity("Entities.Diet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Diets");
                });

            modelBuilder.Entity("Entities.Food", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Alcohol")
                        .HasColumnType("float");

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<double>("Carbohydrate")
                        .HasColumnType("float");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<double>("Copper")
                        .HasColumnType("float");

                    b.Property<double>("Fiber")
                        .HasColumnType("float");

                    b.Property<string>("Food_Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<double>("Lipid")
                        .HasColumnType("float");

                    b.Property<double>("Magnesium")
                        .HasColumnType("float");

                    b.Property<double>("Phosphor")
                        .HasColumnType("float");

                    b.Property<double>("Potassium")
                        .HasColumnType("float");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<double>("Selenium")
                        .HasColumnType("float");

                    b.Property<double>("Sodium")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<double>("Vitamin_A")
                        .HasColumnType("float");

                    b.Property<double>("Vitamin_B12")
                        .HasColumnType("float");

                    b.Property<double>("Vitamin_B6")
                        .HasColumnType("float");

                    b.Property<double>("Vitamin_C")
                        .HasColumnType("float");

                    b.Property<double>("Vitamin_D")
                        .HasColumnType("float");

                    b.Property<double>("Vitamin_E")
                        .HasColumnType("float");

                    b.Property<double>("Zinc")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("Entities.FoodAmountPerMeal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("FoodID")
                        .HasColumnType("int");

                    b.Property<int?>("MealsID")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FoodID");

                    b.HasIndex("MealsID");

                    b.ToTable("FoodAmountPerMeal");
                });

            modelBuilder.Entity("Entities.FoodCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entities.Meal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<double>("Total_Calories")
                        .HasColumnType("float");

                    b.Property<double>("Total_Carbohydrates")
                        .HasColumnType("float");

                    b.Property<double>("Total_Lipids")
                        .HasColumnType("float");

                    b.Property<double>("Total_Proteins")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("Entities.Restriction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Restrictions");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Activity")
                        .HasColumnType("int");

                    b.Property<double>("BodyFat")
                        .HasColumnType("float");

                    b.Property<double>("Daily_Calories")
                        .HasColumnType("float");

                    b.Property<double>("Daily_Carbohydrates")
                        .HasColumnType("float");

                    b.Property<double>("Daily_Fats")
                        .HasColumnType("float");

                    b.Property<double>("Daily_Protein")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date_Of_Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Days_To_Reach_Goal")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<double>("IMC")
                        .HasColumnType("float");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Objective")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestrictionID")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<int?>("Weight_Objective")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FoodRestriction", b =>
                {
                    b.Property<int>("FoodsID")
                        .HasColumnType("int");

                    b.Property<int>("RestrictionsID")
                        .HasColumnType("int");

                    b.HasKey("FoodsID", "RestrictionsID");

                    b.HasIndex("RestrictionsID");

                    b.ToTable("FoodRestriction");
                });

            modelBuilder.Entity("DietMeal", b =>
                {
                    b.HasOne("Entities.Diet", null)
                        .WithMany()
                        .HasForeignKey("DietsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Meal", null)
                        .WithMany()
                        .HasForeignKey("MealsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Diet", b =>
                {
                    b.HasOne("Entities.User", null)
                        .WithMany("Diets")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("Entities.Food", b =>
                {
                    b.HasOne("Entities.FoodCategory", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.FoodAmountPerMeal", b =>
                {
                    b.HasOne("Entities.Food", "Food")
                        .WithMany("Meals")
                        .HasForeignKey("FoodID");

                    b.HasOne("Entities.Meal", "Meals")
                        .WithMany("Foods")
                        .HasForeignKey("MealsID");

                    b.Navigation("Food");

                    b.Navigation("Meals");
                });

            modelBuilder.Entity("Entities.Restriction", b =>
                {
                    b.HasOne("Entities.User", "User")
                        .WithOne("Restriction")
                        .HasForeignKey("Entities.Restriction", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodRestriction", b =>
                {
                    b.HasOne("Entities.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Restriction", null)
                        .WithMany()
                        .HasForeignKey("RestrictionsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Food", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("Entities.FoodCategory", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("Entities.Meal", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Navigation("Diets");

                    b.Navigation("Restriction");
                });
#pragma warning restore 612, 618
        }
    }
}
