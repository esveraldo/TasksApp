using Microsoft.EntityFrameworkCore.Storage;
using TasksApp.Domain.Interfaces.Repositories;
using TasksApp.Infraestructure.Data.Contexts;

namespace TasksApp.Infraestructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        private IDbContextTransaction _dbContextTransaction;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IUserRepository userRepository => new UserRepository(_dataContext);

        public IProjectRepository projectRepository => new ProjectRepository(_dataContext);

        public IProjectTaskRepository projectTaskRepository => new ProjectTaskRepository(_dataContext);

        public void BeginTransaction()
        {
            _dbContextTransaction = _dataContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _dbContextTransaction.Commit();
        }

        public void Rollback()
        {
            _dbContextTransaction?.Rollback();
        }

        public void SaveChanges()
        {
            _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext?.Dispose();
        }
    }
}
