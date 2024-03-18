using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Domain.Entities;
using TasksApp.Domain.Entities.Enums;
using TasksApp.Domain.Interfaces.Repositories;
using TasksApp.Domain.Interfaces.Services;

namespace TasksApp.Domain.Services
{
    public class ProjectTasksDomainService : IProjectTasksDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectTasksDomainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ProjectTask>> GetProjectTask()
        {
            return _unitOfWork.projectTaskRepository.GetAll().ToList();
        }

        public async Task NewProjectTask(ProjectTask projectTasks)
        {
            await _unitOfWork.projectTaskRepository.Create(projectTasks);
            _unitOfWork.SaveChanges();
        }

        public async Task RemoveProjectTask(int id)
        {
            var task = _unitOfWork.projectTaskRepository.GetById(id);
            await _unitOfWork.projectTaskRepository.Delete(task);
            _unitOfWork.SaveChanges();
        }

        public async Task UpdateProjectTask(ProjectTask projectTasks)
        {
            var task = _unitOfWork.projectTaskRepository.GetById(projectTasks.Id);

            if (task.Id == projectTasks.Id)
            {
                task.Title = projectTasks.Title;
                task.Details = projectTasks.Details;
                task.expireDate = projectTasks.expireDate;
                task.Status = projectTasks.Status;
            }

            await _unitOfWork.projectTaskRepository.Update(task);
            _unitOfWork.SaveChanges();
        }
    }
}
