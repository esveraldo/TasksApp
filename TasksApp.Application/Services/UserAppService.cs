using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Application.Dtos.Users;
using TasksApp.Application.Interfaces;
using TasksApp.Application.Mappings;
using TasksApp.Domain.Entities;
using TasksApp.Domain.Interfaces.Services;

namespace TasksApp.Application.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly IMapper _mapper;
        private readonly IUserDomainService _userDomainService;

        public UserAppService(IMapper mapper, IUserDomainService userDomainService)
        {
            _mapper = mapper;
            _userDomainService = userDomainService;
        }

        public async Task Add(CreateUserDto createUserDto)
        {
            var mapper = MapperConfig.InitializeAutomapper();
            var user = mapper.Map<User>(createUserDto);

            await _userDomainService.NewUser(user);
        }

        public async Task<List<GetUsersDto>> GetAll()
        {
            var mapper = MapperConfig.InitializeAutomapper();
            return mapper.Map<List<GetUsersDto>>(await _userDomainService.GetUsers());
        }
    }
}
