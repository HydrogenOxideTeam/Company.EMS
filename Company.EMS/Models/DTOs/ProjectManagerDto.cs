namespace Company.EMS.Models.DTOs;

public record ProjectManagerDto
{
    public int Id { get; init; }
    public Guid UserId { get; init; } 
    //public User User {get;init;}
}