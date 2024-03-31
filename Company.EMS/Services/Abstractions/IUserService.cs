using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IUserService
{
    Task<string> RegisterUserAsync(RegisterDto request);
    Task<string> LoginUserAsync(LoginDto command);
}