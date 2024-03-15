using FluentValidation.Results;

namespace TasksApp.Domain.Core
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        ValidationResult Validate { get; }
    }
}
