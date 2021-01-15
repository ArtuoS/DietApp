using DataAcessLayer;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Common
{
    public class DietDB : DbContext
    {

        public DbSet<Food> Foods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Food_Category> Categories { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Restriction> Restrictions { get; set; }
        public DbSet<Food_Diet> Foods_Diets { get; set; }
        public DbSet<Meal_Diet> Meals_Diets { get; set; }
        public DbSet<Meal_Food> Meals_Foods { get; set; }
        public DbSet<User_Diet> Users_Diets { get; set; }
        public DbSet<User_Restriction> Users_Restrictions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        {
            modelBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\Users\Entra21\Documents\DietDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }

}