namespace Company.EMS.Models.DTOs;

public record RegisterDto
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }
    public string PasswordConfirmation { get; init; }
}