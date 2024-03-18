using FluentValidation;
using TasksApp.Domain.Entities;

namespace TasksApp.Domain.Validations
{
    public class ProjectTaskValidation : AbstractValidator<ProjectTask>
    {
        public ProjectTaskValidation()
        {
            RuleFor(p => p.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("Id é obrigatório");

            RuleFor(p => p.Priority)
                .NotNull()
                .NotEmpty()
                .WithMessage("A prioridade é obrigatório");

            RuleFor(p => p.Status)
                .NotNull()
                .NotEmpty()
                .WithMessage("Status é obrigatório");
        }
    }
}
