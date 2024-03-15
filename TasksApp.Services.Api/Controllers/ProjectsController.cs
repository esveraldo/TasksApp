using Microsoft.AspNetCore.Mvc;
using TasksApp.Application.Dtos.Projects;
using TasksApp.Application.Interfaces;

namespace TasksApp.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectAppService _projectAppService;

        public ProjectsController(IProjectAppService projectAppService)
        {
            _projectAppService = projectAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _projectAppService.GetAll();
            return StatusCode(200, users);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProjectDto userDto)
        {
            var result = _projectAppService.Add(userDto);
            return StatusCode(201, new
            {
                Message = result,
                userDto
            });

        }
    }
}

