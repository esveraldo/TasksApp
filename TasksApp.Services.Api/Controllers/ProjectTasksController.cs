using Microsoft.AspNetCore.Mvc;
using TasksApp.Application.Dtos.Projects;
using TasksApp.Application.Dtos.ProjectTasks;
using TasksApp.Application.Interfaces;
using TasksApp.Application.Services;
using TasksApp.Domain.Entities;

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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _projectTaskAppService.GetAll();
            return StatusCode(200, users);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProjectTaskDto createProjectTask)
        {
            var result = await _projectTaskAppService.Add(createProjectTask);
            return StatusCode(201, new
            {
                Message = result,
                createProjectTask
            });

        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateProjectTaskDto updateProjectTaskDto)
        {
            var result = _projectTaskAppService.Update(updateProjectTaskDto);
            return StatusCode(200, result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _projectTaskAppService.Remove(id);
            return Ok();
        }
    }
}
