using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp.Application.Dtos.Projects
{
    public class GetProjectsDto
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid UserId { get; set; }
    }
}
