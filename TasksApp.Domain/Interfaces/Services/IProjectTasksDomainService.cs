using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Domain.Entities;

namespace TasksApp.Domain.Interfaces.Services
{
    public interface IProjectTasksDomainService
    {
        Task NewProjectTask(ProjectTask projectTasks);
        Task UpdateProjectTask(ProjectTask projectTasks);
        Task RemoveProjectTask(int id);
        Task<List<ProjectTask>> GetProjectTask();
    }
}
