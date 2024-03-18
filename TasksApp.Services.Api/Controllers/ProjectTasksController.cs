using Microsoft.AspNetCore.Mvc;
using TasksApp.Application.Interfaces;

namespace TasksApp.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProjectTasksController : ControllerBase
    {
        private readonly IProjectTaskAppService _projectTaskAppService;

        public ProjectTasksController(IProjectTaskAppService projectTaskAppService)
        {
            _projectTaskAppService = projectTaskAppService;
        }
    }
}
