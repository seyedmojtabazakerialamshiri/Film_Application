using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Film_Application.Core.Repositories;
using Film_Application.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Film_Application.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;

        public Repository(FilmDbContext context)
        {
            Context = context;
        }
        public void AddAsync(T entity)
        {
            Context.Set<T>().AddAsync(entity);
        }

        public void AddRangeAsync(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRangeAsync(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAllAsync()
        {
            return Context.Set<T>().ToList();
        }

        public T GetByIdAsync(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Context.Set<T>().RemoveRange(entities);
        }

        public T SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().SingleOrDefault(predicate);
        }
    }
}
