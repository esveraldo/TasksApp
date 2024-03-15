using FluentValidation;
using TasksApp.Domain.Entities;

namespace TasksApp.Domain.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(p => p.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("Id é obrigatório");
        }
    }
}
