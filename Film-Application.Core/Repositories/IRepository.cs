using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Film_Application.Core.Models;

namespace Film_Application.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        T GetByIdAsync(int id);
        IEnumerable<T> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
        void AddAsync(T entity);
        void AddRangeAsync(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
