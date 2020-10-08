using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AgencyApp.Infrastructure
{

    // Generic Repository
    public interface IRepository<T>
        where T : class
    {
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);

        IQueryable GetAll(Expression<Func<T, bool>> predicate = null);

        T GetById(int id);

        Task<T> GetByIdAsync(int id);

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
