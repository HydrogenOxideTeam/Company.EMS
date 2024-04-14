namespace Company.EMS.Models.DTOs;

public record DeveloperTechnologyDto()
{
    public int Id { get; init; }
    public int DeveloperId { get; init; } 
    public int Technology { get; init; } 
}