using Microsoft.EntityFrameworkCore;
using TasksApp.Domain.Core;
using TasksApp.Domain.Entities;
using TasksApp.Domain.Interfaces.Repositories;
using TasksApp.Infraestructure.Data.Contexts;

namespace TasksApp.Infraestructure.Data.Repositories
{
    public class UserRepository : BaseRepository<User, Guid>, IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public List<User> GetAllUsersWithProjects()
        {
            return _dataContext.Users
            .Include(u => u.Projects)
            .ThenInclude(p => p.ProjectTasks)
            .ToList();
        }
    }
}
