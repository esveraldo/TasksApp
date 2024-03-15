using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Domain.Entities;

namespace TasksApp.Domain.Interfaces.Services
{
    public interface IProjectDomainService
    {
        Task NewProject(Project project);
        Task<List<Project>> GetProject();
    }
}
