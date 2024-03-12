using Company.EMS.CQS.Configurations.Queries;
using Company.EMS.Models.DTOs;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Services.Abstractions;
using FluentValidation;

namespace Company.EMS.CQS.Queries.GetExample;

public class GetExampleQueryHandler(IExampleService exampleService, IValidator<GetExampleQuery> validator): IQueryHandler<GetExampleQuery, ExampleDto>
{
    private readonly IExampleService _exampleService = exampleService;
    private readonly IValidator<GetExampleQuery> _validator = validator;


    public async Task<ExampleDto> Handle(GetExampleQuery request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }
        return await _exampleService.GetExampleByIdAsync(request.Id);
    }
}