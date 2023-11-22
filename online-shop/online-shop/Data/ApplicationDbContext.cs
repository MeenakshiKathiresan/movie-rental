using System;
using Microsoft.EntityFrameworkCore;
using online_shop.Models;

namespace online_shop.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			Console.Write(modelBuilder);
            System.Diagnostics.Debug.WriteLine("This will be displayed in output window");
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Thriller", DisplayOrder = 1 },
				new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
				new Category { Id = 3, Name = "Action", DisplayOrder = 3 }
				);
        }
    }
}

