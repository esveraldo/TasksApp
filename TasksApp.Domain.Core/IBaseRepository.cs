using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp.Domain.Core
{
    public interface IBaseRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);

        List<TEntity> GetAll();
        TEntity GetById(TKey id);
    }
}
