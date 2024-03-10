namespace Company.EMS.Models.DTOs;

public record DeveloperDto
{
    public int Id { get; init; }
    public Guid UserId { get; init; } 
    //public User User {get;init;}
    public int SalesManagerId { get; init; } 
    //public SalesManager SalesManager {get;init;}
    public int ProjectManagerId { get; init; } 
    //public ProjectManager ProjectManager {get;init;}
    public int ProgrammerTypeId { get; init; } 
    //public ProgrammerType ProgrammerType {get;init;}
    public bool IsCaller { get; init; }
}