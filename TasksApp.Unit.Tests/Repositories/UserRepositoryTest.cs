using FluentAssertions;
using TasksApp.Domain.Entities;
using TasksApp.Domain.Interfaces.Repositories;
using Xunit;

namespace TasksApp.Unit.Tests.Repositories
{
    public class UserRepositoryTest
    {
        private readonly IUserRepository _userRepository;

        public UserRepositoryTest(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Fact]
        public void TesteDeCriacao()
        {
            var user = CreateUser();

            var userById = _userRepository.GetById(user.Id);

            userById.Should().NotBeNull();
            userById.Name.Should().Be(user.Name);
            userById.Role.Should().Be(user.Role);
        }

        private User CreateUser()
        {
            var user = new User()
            {
                Name = "Test",
                Role = "Usuario"
            };

            _userRepository.Create(user);
            return user;
        }
    }
}