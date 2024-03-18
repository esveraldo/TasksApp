using TasksApp.Domain.Entities;
using TasksApp.Domain.Interfaces.Repositories;
using TasksApp.Infraestructure.Data.Contexts;

namespace TasksApp.Infraestructure.Data.Repositories
{
    public class ProjectTaskRepository : BaseRepository<ProjectTask, int>, IProjectTaskRepository
    {
        private readonly DataContext _dataContext;

        public ProjectTaskRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
