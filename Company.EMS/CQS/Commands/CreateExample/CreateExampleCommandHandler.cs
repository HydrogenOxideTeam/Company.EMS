using Company.EMS.CQS.Configurations.Commands;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Services.Abstractions;
using FluentValidation;

namespace Company.EMS.CQS.Commands.CreateExample;

public class CreateExampleCommandHandler(IExampleService exampleService, IValidator<CreateExampleCommand> validator): ICommandHandler<CreateExampleCommand, ExampleDto>
{
    private readonly IExampleService _exampleService = exampleService;
    private readonly IValidator<CreateExampleCommand> _validator = validator;

    public async Task<ExampleDto> Handle(CreateExampleCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }
        return await _exampleService.CreateExampleAsync(request.Name);
    }
}