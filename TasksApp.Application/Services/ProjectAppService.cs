using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Application.Dtos.Projects;
using TasksApp.Application.Dtos.Users;
using TasksApp.Application.Interfaces;
using TasksApp.Application.Mappings;
using TasksApp.Domain.Entities;
using TasksApp.Domain.Interfaces.Services;
using TasksApp.Domain.Services;

namespace TasksApp.Application.Services
{
    public class ProjectAppService : IProjectAppService
    {
        private readonly IMapper _mapper;
        private readonly IProjectDomainService _projectDomainService;

        public ProjectAppService(IMapper mapper, IProjectDomainService projectDomainService)
        {
            _mapper = mapper;
            _projectDomainService = projectDomainService;
        }

        public async Task Add(CreateProjectDto createProjectDto)
        {
            var mapper = MapperConfig.InitializeAutomapper();
            var project = mapper.Map<Project>(createProjectDto);

            await _projectDomainService.NewProject(project);
        }

        public async Task<List<GetProjectsDto>> GetAll()
        {
            var mapper = MapperConfig.InitializeAutomapper();
            return mapper.Map<List<GetProjectsDto>>(await _projectDomainService.GetProject());
        }
    }
}
