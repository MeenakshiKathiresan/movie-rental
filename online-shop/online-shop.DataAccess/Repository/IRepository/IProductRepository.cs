using System;
using online_shop.DataAccess.Repository;
using online_shop.Models;

namespace online_shop.Repository
{
	public interface IProductRepository :IRepository<Product>
	{
        void Update(Product product);
    }
}

