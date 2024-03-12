namespace Company.EMS.Models.DTOs;

public record SalesManagerDto
{
    public int Id { get; init; }
    public Guid UserId { get; init; } 
    //public User User {get;init;}
    public int ProjectManagerId { get; init; } 
    //public ProjectManager ProjectManager {get;init;}
}