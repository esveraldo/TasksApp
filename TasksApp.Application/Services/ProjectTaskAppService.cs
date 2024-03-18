using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Application.Dtos.Projects;
using TasksApp.Application.Dtos.ProjectTasks;
using TasksApp.Application.Interfaces;
using TasksApp.Application.Mappings;
using TasksApp.Domain.Entities;
using TasksApp.Domain.Interfaces.Services;
using TasksApp.Domain.Services;

namespace TasksApp.Application.Services
{
    public class ProjectTaskAppService : IProjectTaskAppService
    {
        private readonly IMapper _mapper;
        private readonly IProjectTasksDomainService _projectTasksDomainService;

        public ProjectTaskAppService(IMapper mapper, IProjectTasksDomainService projectTasksDomainService)
        {
            _mapper = mapper;
            _projectTasksDomainService = projectTasksDomainService;
        }

        public async Task<string> Add(UpdateProjectTaskDto updateProjectTaskDto)
        {
            string msg;
            var mapper = MapperConfig.InitializeAutomapper();
            var projectTask = mapper.Map<ProjectTask>(updateProjectTaskDto);

            var result = _projectTasksDomainService.NewProjectTask(projectTask);

            msg = result.Id != null ? "Tarefa criada com sucesso." : "Houve um erro ao criar a tarefa";

            return msg;
        }

        public async Task<List<GetProjectTaskDto>> GetAll()
        {
            var mapper = MapperConfig.InitializeAutomapper();
            return mapper.Map<List<GetProjectTaskDto>>(await _projectTasksDomainService.GetProjectTask());
        }

        public async Task Remove(int id)
        {
            await _projectTasksDomainService.RemoveProjectTask(id);
        }

        public async Task Update(UpdateProjectTaskDto updateProjectTaskDto)
        {
            var mapper = MapperConfig.InitializeAutomapper();
            var projectTask = mapper.Map<ProjectTask>(updateProjectTaskDto);
            await _projectTasksDomainService.UpdateProjectTask(projectTask);
        }
    }
}
