using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Application.Dtos.Projects;
using TasksApp.Application.Dtos.Users;

namespace TasksApp.Application.Interfaces
{
    public interface IProjectAppService
    {
        Task Add(CreateProjectDto createProjectDto);
        Task<List<GetProjectsDto>> GetAll();
    }
}
