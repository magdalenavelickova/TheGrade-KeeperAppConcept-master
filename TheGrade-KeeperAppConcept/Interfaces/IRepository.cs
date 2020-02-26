using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGrade_KeeperAppConcept.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
        void Remove(TEntity entity);
    }
}
