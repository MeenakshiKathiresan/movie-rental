using System;
using online_shop.DataAccess.Data;
using online_shop.Repository;
using online_shop.Repository;

namespace online_shop.DataAccess.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
        ApplicationDbContext _db;

        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
		{
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
		}

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

