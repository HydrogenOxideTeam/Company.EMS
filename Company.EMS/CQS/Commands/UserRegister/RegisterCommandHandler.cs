using Company.EMS.CQS.Configurations.Commands;
using Company.EMS.Services.Abstractions;
using FluentValidation;

namespace Company.EMS.CQS.Commands.UserRegister;

public class RegisterCommandHandler(IUserService userService, IValidator<RegisterCommand> validator): ICommandHandler<RegisterCommand, string>
{
    private readonly IUserService _userService = userService;
    private readonly IValidator<RegisterCommand> _validator = validator;
    
    public async Task<string> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);
         if (!validationResult.IsValid)
         {
             throw new ValidationException(validationResult.Errors);
         }
        return await _userService.RegisterUserAsync(request);
    }
}