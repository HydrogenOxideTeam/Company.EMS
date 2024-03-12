using FluentValidation;

namespace Company.EMS.CQS.Commands.CreateExample;

public class CreateExampleCommandValidator: AbstractValidator<CreateExampleCommand>
{
    public CreateExampleCommandValidator()
    {
        RuleFor(command => command.Name).NotEmpty().WithMessage("Name is required");
    }
}