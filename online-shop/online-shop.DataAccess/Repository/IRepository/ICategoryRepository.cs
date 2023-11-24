using System;
using online_shop.Models;

namespace online_shop.DataAccess.Repository.IRepository
{
	public interface ICategoryRepository : IRepository<Category>
	{
		void Update(Category category);
		void Save();
	}
}

