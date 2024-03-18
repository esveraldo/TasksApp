using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApp.Domain.Entities.Enums;

namespace TasksApp.Application.Dtos.ProjectTasks
{
    public class CreateProjectTaskDto
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime expireDate { get; set; }
        public Priority Priority { get; set; }
    }
}
