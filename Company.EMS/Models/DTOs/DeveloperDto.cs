namespace Company.EMS.Models.DTOs;

public record DeveloperDto()
{
    public int Id { get; init; }
    public Guid UserId { get; init; } 
    public int SalesManagerId { get; init; } 
    public int ProjectManagerId { get; init; } 
    public int ProgrammerType { get; init; } 
    public bool IsCaller { get; init; }
}