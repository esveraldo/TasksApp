using TasksApp.Domain.Entities;
using TasksApp.Domain.Interfaces.Repositories;
using TasksApp.Domain.Interfaces.Services;

namespace TasksApp.Domain.Services
{
    public class ProjectDomainService : IProjectDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectDomainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Project>> GetProject()
        {
            return _unitOfWork.projectRepository.GetAll().ToList();
        }

        public async Task NewProject(Project project)
        {
            await _unitOfWork.projectRepository.Create(project);
            _unitOfWork.SaveChanges();
        }
    }
}
