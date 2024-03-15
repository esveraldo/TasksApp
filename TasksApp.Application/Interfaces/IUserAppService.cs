using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Application.Dtos.Users;

namespace TasksApp.Application.Interfaces
{
    public interface IUserAppService
    {
        Task Add(CreateUserDto createUserDto);
        Task <List<GetUsersDto>> GetAll();
    }
}
