using System;
using online_shop.Models;

namespace online_shop.DataAccess.Repository
{
	public interface ICategoryRepository : IRepository<Category>
	{
		void Update(Category category);
	}
}

