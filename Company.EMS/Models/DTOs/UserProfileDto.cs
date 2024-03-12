namespace Company.EMS.Models.DTOs;

public record UserProfileDto
{
    public int Id { get; init; }
    public int UserId { get; init; } 
    //public User User {get;init;}
    public string? LastName { get; init; } 
    public string? PhoneNumber { get; init; } 
    public string? AvatarUrl { get; init; } 
    public DateOnly Date { get; init; }
}