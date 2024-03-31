namespace Company.EMS.Models.DTOs;

public record RegisterDto
{
    public string UserName { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }
    public string PasswordConfirmation { get; init; }
}