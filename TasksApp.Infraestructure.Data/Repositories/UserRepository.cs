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

        public override List<User> GetAll()
        {
            return _dataContext.Users.Include(x => x.Projects).ToList();
        }
    }
}
