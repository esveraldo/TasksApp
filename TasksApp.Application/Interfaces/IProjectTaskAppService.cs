using AutoMapper;
using TasksApp.Application.Dtos.Projects;
using TasksApp.Application.Dtos.ProjectTasks;
using TasksApp.Domain.Interfaces.Services;

namespace TasksApp.Application.Interfaces
{
    public interface IProjectTaskAppService
    {
        Task<string> Add(UpdateProjectTaskDto updateProjectTaskDto);
        Task Update(UpdateProjectTaskDto updateProjectTaskDto);
        Task Remove(int id);
        Task<List<GetProjectTaskDto>> GetAll();
    }
}
