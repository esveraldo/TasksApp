using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Domain.Core;
using TasksApp.Domain.Entities;

namespace TasksApp.Domain.Interfaces.Repositories
{
    public interface IProjectRepository : IBaseRepository<Project, Guid>
    {
    }
}
