using System;
using online_shop.DataAccess.Data;
using online_shop.DataAccess.Repository;
using online_shop.Models;
using online_shop.Repository;


namespace online_shop.Repository
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
        ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) :base(db)
		{
            _db = db;
        }

        public void Update(Product product)
        {
            _db.Products.Update(product);
        }
    }
}

