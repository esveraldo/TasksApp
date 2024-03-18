using FluentAssertions;
using System.Net;
using TasksApp.Application.Dtos.Users;
using TasksApp.Integration.Tests.Helpers;
using Xunit;

namespace TasksApp.Integration.Tests
{
    public class UserTest
    {
        private readonly TestHelper _testHelper;

        public UserTest()
        {
            _testHelper = new TestHelper();
        }

        [Fact]
        public async Task Test_Post_User_Returns_Created()
        {
            var user = new CreateUserDto
            {
                Name = "João Carlos",
                Role = "Usuario"
            };

            var content = _testHelper.CreateContent(user);
            var result = await _testHelper.CreateClient().PostAsync("/api/users", content);

            result.StatusCode
                .Should()
                    .Be(HttpStatusCode.Created);
        }
    }
}