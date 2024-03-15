using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp.Application.Dtos.Projects
{
    public class CreateProjectDto
    {
        public string Name { get; set; }
        public Guid UserId { get; set; }
    }
}
