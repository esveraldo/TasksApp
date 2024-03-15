using TasksApp.Domain.Entities;

namespace TasksApp.Domain.Interfaces.Services
{
    public interface IUserDomainService
    {
        Task NewUser(User user);
        Task <List<User>> GetUsers();
    }
}
