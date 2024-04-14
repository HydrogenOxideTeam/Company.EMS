namespace Company.EMS.Models.DTOs;

public record ProjectDto()
{
    public int Id { get; init; }
    public string? Name { get; init; } 
    public string? Customer { get; init; } 
    public int ProjectType { get; init; } 
    public int HoursLimit { get; init; } 
    public int Rate { get; init; } 
    public int AccountId { get; init; } 
    public int ProjectStatus { get; init; } 
    public int CallerId { get; init; } 
    public DateTime Date { get; init; }
}