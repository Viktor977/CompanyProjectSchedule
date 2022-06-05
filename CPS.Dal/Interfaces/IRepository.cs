using CPS.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Dal.Interfaces
{
   public interface IRepository<TEntity>where TEntity:BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task AddAsync(TEntity entity);
        void Delete(TEntity entity);
        Task DeleteByIdAsync(int id);
        void UpDate(TEntity entity);

    }
}
