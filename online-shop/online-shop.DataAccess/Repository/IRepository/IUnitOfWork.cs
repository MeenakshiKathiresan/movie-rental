using System;
using online_shop.Repository;

namespace online_shop.DataAccess.Repository
{
	public interface IUnitOfWork
	{
		ICategoryRepository Category { get;  }
		IProductRepository Product { get; }
		void Save();
	}
}

