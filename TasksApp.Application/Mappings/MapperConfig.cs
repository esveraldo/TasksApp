using AutoMapper;
using TasksApp.Application.Dtos.Projects;
using TasksApp.Application.Dtos.Users;
using TasksApp.Domain.Entities;

namespace TasksApp.Application.Mappings
{
    public class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CreateUserDto, User>().ReverseMap();
                cfg.CreateMap<GetUsersDto, User>().ReverseMap();

                cfg.CreateMap<CreateProjectDto, Project>().ReverseMap();
                cfg.CreateMap<GetProjectsDto, Project>().ReverseMap();
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
