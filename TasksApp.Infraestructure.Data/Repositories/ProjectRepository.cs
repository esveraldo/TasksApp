using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Domain.Entities;
using TasksApp.Domain.Interfaces.Repositories;
using TasksApp.Infraestructure.Data.Contexts;

namespace TasksApp.Infraestructure.Data.Repositories
{
    public class ProjectRepository : BaseRepository<Project, Guid>, IProjectRepository
    {
        private readonly DataContext _dataContext;

        public ProjectRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
