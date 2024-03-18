using FluentAssertions;
using System.Net;
using TasksApp.Application.Dtos.Projects;
using TasksApp.Integration.Tests.Helpers;
using Xunit;

namespace TasksApp.Integration.Tests
{
    public class ProjectTest
    { 
    private readonly TestHelper _testHelper;

    public ProjectTest()
    {
        _testHelper = new TestHelper();
    }

    [Fact]
    public async Task Test_Post_Project_Returns_Created()
    {
        var project = new CreateProjectDto
        {
            Name = "Pilates",
            UserId = Guid.NewGuid(),    
        };

        var content = _testHelper.CreateContent(project);
        var result = await _testHelper.CreateClient().PostAsync("/api/projects", content);

        result.StatusCode
            .Should()
                .Be(HttpStatusCode.Created);
    }
}
}