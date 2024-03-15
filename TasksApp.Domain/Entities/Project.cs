using FluentValidation.Results;
using TasksApp.Domain.Core;
using TasksApp.Domain.Validations;

namespace TasksApp.Domain.Entities
{
    public class Project : IEntity<Guid>
    {
        public Project()
        {
            this.Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public virtual IList<ProjectTask> ProjectTasks { get; set; }
        public ValidationResult Validate => new ProjectValidation().Validate(this);
    }
}
