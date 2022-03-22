using Microsoft.EntityFrameworkCore;
using server.Models;
using server.Units;
using System;

namespace server.Datas
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<RecipeIngredients> RecipeIngredients { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Barbecue", CreatedAt = new DateTime(2021,3,3,5,25,4) },
                new Category { Id = 2, Name = "Desert", CreatedAt = new DateTime(2021,4,4,6,15,14)},
                new Category { Id = 3, Name = "Breakfast", CreatedAt = new DateTime(2020,4,6,3,17,25)},
                new Category { Id = 4, Name = "Lunch", CreatedAt = new DateTime(2019,5,6,2,2,2)},
                new Category { Id = 5, Name = "Dinner", CreatedAt = new DateTime(2018,5,7,1,15,15)}
                );
            var hmac = new System.Security.Cryptography.HMACSHA512();
            var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("test123"));

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "user123", PasswordHash = passwordHash, PasswordSalt = hmac.Key }
                );

            modelBuilder.Entity<Ingredient>().HasData(
                 new Ingredient { Id = 1, Name = "Oil", PurchasePrice= 3, PurchaseQuantity = 1, PurchaseUnit = UnitEnum.l },
                 new Ingredient { Id = 2, Name = "Flour", PurchasePrice = 30, PurchaseQuantity = 25, PurchaseUnit = UnitEnum.kg },
                 new Ingredient { Id = 3, Name = "Sugar", PurchasePrice = 3, PurchaseQuantity = 1, PurchaseUnit = UnitEnum.kg},
                 new Ingredient { Id = 4, Name = "Salt", PurchasePrice = 2, PurchaseQuantity = 1, PurchaseUnit = UnitEnum.kg},
                 new Ingredient { Id = 5, Name = "Olive Oil", PurchasePrice = 20, PurchaseQuantity = 1, PurchaseUnit = UnitEnum.l},
                 new Ingredient { Id = 6, Name = "Egg", PurchasePrice = 9, PurchaseQuantity = 30, PurchaseUnit = UnitEnum.pcs},
                 new Ingredient { Id = 7, Name = "Chicken meat", PurchasePrice = 10, PurchaseQuantity = 1, PurchaseUnit = UnitEnum.kg}
                );

            modelBuilder.Entity<RecipeIngredients>().HasKey(r => new { r.IngredientId, r.RecipeId });
        }

    }
}
