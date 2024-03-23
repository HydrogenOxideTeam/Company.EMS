using Company.EMS.CQS.Configurations.Commands;
using Company.EMS.Services.Abstractions;
using FluentValidation;

namespace Company.EMS.CQS.Commands.UserLogin;

public class LoginCommandHandler(IUserService userService, IValidator<LoginCommand> validator): ICommandHandler<LoginCommand, string>
{
    private readonly IUserService _userService = userService;
    private readonly IValidator<LoginCommand> _validator = validator;
    
    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }
        return await _userService.LoginUserAsync(request);
    }
}