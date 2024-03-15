using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Domain.Core;
using TasksApp.Infraestructure.Data.Contexts;

namespace TasksApp.Infraestructure.Data.Repositories
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : class
    {
        private readonly DataContext _dataContext;

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public virtual async Task Create(TEntity entity)
        {
            _dataContext.Add(entity);
        }

        public virtual async Task Update(TEntity entity)
        {
            _dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual async Task Delete(TEntity entity)
        {
            _dataContext.Entry(entity).State = EntityState.Deleted;
        }

        public virtual List<TEntity> GetAll()
        {
            return _dataContext.Set<TEntity>().ToList();
        }

        public virtual TEntity GetById(TKey id)
        {
            return _dataContext.Set<TEntity>().Find(id);
        }

        public void Dispose()
        {
            _dataContext?.Dispose();
        }
    }
}
