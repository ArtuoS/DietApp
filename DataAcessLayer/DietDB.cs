using DataAcessLayer;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Entities
{
    public class DietDB : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FoodCategory> Categories { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Restriction> Restrictions { get; set; }
        public DbSet<FoodAmountPerMeal> FoodAmoutPerMeal { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        {
            //modelBuilder.UseSqlServer(@"Server=tcp:dietplusdatabaseserver.database.windows.net,1433;Initial Catalog=DietPlusDatabase;Persist Security Info=False;User ID=dpdadm;Password=abcd1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",

            modelBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DietDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //options => options.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }

}