using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClass.Data.Interfaces
{
    public interface IRepository<T>
    {
        T Add(T obj);
        Task<T> AddAsync(T obj);

        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();

        T GetById(object id);

        Task<T> GetByIdAsync(object id);

        T GetSingleByCondition(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable, IOrderedQueryable> orderby = null, 
            params string[] includeProperties);

        IEnumerable<T> GetByCondition(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable, IOrderedQueryable> orderby = null,
            int? skip = null, int? take = null,
            params string[] includeProperties);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate = null);
        bool Any(Expression<Func<T, bool>> predicate = null);
    }
}
