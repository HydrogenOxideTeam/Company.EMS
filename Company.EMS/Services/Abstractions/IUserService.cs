using Company.EMS.CQS.Commands.UserLogin;
using Company.EMS.CQS.Commands.UserRegister;

namespace Company.EMS.Services.Abstractions;

public interface IUserService
{
    Task<string> RegisterUserAsync(RegisterCommand command);
    Task<string> LoginUserAsync(LoginCommand command);
}