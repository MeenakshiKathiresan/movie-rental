using System;
using online_shop.Models;

using online_shop.DataAccess.Repository.IRepository;
using online_shop.Data;
using Microsoft.EntityFrameworkCore;

namespace online_shop.DataAccess.Repository
{
	public class CategoryRepository : Repository<Category>, ICategoryRepository
	{
        private ApplicationDbContext _db;
       

        public CategoryRepository(ApplicationDbContext db): base(db)
		{
            _db = db;
		}

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category category)
        {
            Console.WriteLine("repo impl");
            _db.Categories.Update(category);
        }
    }
}

