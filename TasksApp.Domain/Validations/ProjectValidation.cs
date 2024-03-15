using FluentValidation;
using TasksApp.Domain.Entities;

namespace TasksApp.Domain.Validations
{
    public class ProjectValidation : AbstractValidator<Project>
    {
        public ProjectValidation()
        {
            RuleFor(p => p.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("Id é obrigatório");
        }
    }
}
