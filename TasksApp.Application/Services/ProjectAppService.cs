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

        public async Task<string> Add(CreateProjectDto createProjectDto)
        {
            string msg;
            var mapper = MapperConfig.InitializeAutomapper();
            var project = mapper.Map<Project>(createProjectDto);

            var result = _projectDomainService.NewProject(project);

            msg = result.Id != null ? "Projeto criado com sucesso." : "Houve um erro ao criar o projeto";

            return msg;
        }

        public async Task<List<GetProjectsDto>> GetAll()
        {
            var mapper = MapperConfig.InitializeAutomapper();
            return mapper.Map<List<GetProjectsDto>>(await _projectDomainService.GetProject());
        }
    }
}
