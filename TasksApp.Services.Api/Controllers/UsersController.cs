using Microsoft.AspNetCore.Mvc;
using TasksApp.Application.Dtos.Users;
using TasksApp.Application.Interfaces;

namespace TasksApp.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userAppService.GetAll();
            return StatusCode(200, users);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateUserDto userDto)
        {
            var result = _userAppService.Add(userDto);
            return StatusCode(201, new
            {
                Message = result,
                userDto
            });

        }
    }
}
