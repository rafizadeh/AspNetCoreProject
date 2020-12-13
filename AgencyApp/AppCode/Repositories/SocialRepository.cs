using AgencyApp.Infrastructure;
using AgencyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AgencyApp.AppCode.Repositories
{
    public class SocialRepository : IRepository<Social>
    {
        public Social Create(Social entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Social entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable GetAll(Expression<Func<Social, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Social GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Social> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Social Update(Social entity)
        {
            throw new NotImplementedException();
        }
    }
}
