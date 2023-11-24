using System;
using System.Linq.Expressions;

namespace online_shop.DataAccess.Repository.IRepository
{
	public interface IRepository<T> where T:class
	{
		// eg: T is a category
		IEnumerable<T> GetAll();
		T GetFirst(Expression<Func<T,bool>> filter);
		void Add(T entity);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entity);

	}
}

