using System;
using online_shop.Models;

using online_shop.DataAccess.Data;
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

        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}

