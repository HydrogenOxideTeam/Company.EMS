namespace Company.EMS.Models.DTOs;

public record AccountDto()
{
    public int Id { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public int SalesManagerId { get; init; } 
    //public SalesManager SalesManager {get;init;}
    public string? Email { get; init; }
    public string? EmailPassword { get; init; }
    public string? GitHub { get; init; }
    public string? GitHubPassword { get; init; }
    public string? PhoneNumber { get; init; }
}