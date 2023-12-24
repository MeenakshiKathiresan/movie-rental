using System;
using Microsoft.EntityFrameworkCore;
using online_shop.Models;

namespace online_shop.DataAccess.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Thriller", DisplayOrder = 1 },
				new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
				new Category { Id = 3, Name = "Action", DisplayOrder = 3 }
				);

            modelBuilder.Entity<Product>().HasData(
                new Product {
					Id = 1,
					Title = "Fortune of time",
                    Author = "Billy spark",
                    Description = "About time travel",
					ISBN = "SWD99",
					price = 90.25,
					unitPrice = 99.75
				},
                new Product
                {
                    Id = 2,
                    Title = "Kafka on the shore",
                    Author = "Murakami",
                    Description = "Japan based novel",
                    ISBN = "SWD89",
                    price = 20.25,
                    unitPrice = 29.75
                },
                new Product
                {
                    Id = 3,
                    Title = "A thousand splended suns",
                    Author = "Khaleed Hussain",
                    Description = "Afghanisthan during Taliban rule",
                    ISBN = "SWD79",
                    price = 10.25,
                    unitPrice = 29.75
                }, new Product
                {
                    Id = 4,
                    Title = "Atomic habits",
                    Author = "James clear",
                    Description = "Self help book",
                    ISBN = "SWD69",
                    price = 15.25,
                    unitPrice = 22.99
                }, new Product
                {
                    Id = 5,
                    Title = "Breaking the habit of being yourself",
                    Author = "Joe Dispenza",
                    Description = "Build a new you",
                    ISBN = "SWD59",
                    price = 4.25,
                    unitPrice = 9.75
                }
                );
        }
    }
}

