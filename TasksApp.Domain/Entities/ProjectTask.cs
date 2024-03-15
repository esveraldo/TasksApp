using FluentValidation;
using FluentValidation.Results;
using TasksApp.Domain.Core;
using TasksApp.Domain.Entities.Enums;
using TasksApp.Domain.Validations;

namespace TasksApp.Domain.Entities
{
    public class ProjectTask : IEntity<int>
    {
        public ProjectTask()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            Status = Status.Pending;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime expireDate { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public ValidationResult Validate => new ProjectTaskValidation().Validate(this);
    }
}
