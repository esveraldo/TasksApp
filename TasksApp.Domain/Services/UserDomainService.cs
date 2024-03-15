using TasksApp.Domain.Entities;
using TasksApp.Domain.Interfaces.Repositories;
using TasksApp.Domain.Interfaces.Services;

namespace TasksApp.Domain.Services
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserDomainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<User>> GetUsers()
        {
            return _unitOfWork.userRepository.GetAll().ToList();
        }

        public async Task NewUser(User user)
        {
            _unitOfWork.userRepository.Create(user);
            _unitOfWork.SaveChanges();
        }
    }
}
