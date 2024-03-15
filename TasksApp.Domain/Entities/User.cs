using FluentValidation.Results;
using TasksApp.Domain.Core;
using TasksApp.Domain.Validations;

namespace TasksApp.Domain.Entities
{
    public class User : IEntity<Guid>
    {
        public User()
        {
            this.Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;

        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual IList<Project> Projects { get; set; }
        public ValidationResult Validate => new UserValidation().Validate(this);
    }
}
