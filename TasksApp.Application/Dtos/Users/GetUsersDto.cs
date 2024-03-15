using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp.Application.Dtos.Users
{
    public class GetUsersDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
