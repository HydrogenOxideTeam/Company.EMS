using FluentValidation;

namespace Company.EMS.CQS.Queries.GetExample;

public class GetExampleQueryValidator: AbstractValidator<GetExampleQuery>
{
    public GetExampleQueryValidator()
    {
        RuleFor(query => query.Id).GreaterThan(0).WithMessage("Id must be greater than 0.");
    }
}