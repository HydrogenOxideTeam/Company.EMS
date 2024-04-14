namespace Company.EMS.Models.DTOs;

/// <summary>
/// 
/// </summary>
public record AssignmentDto()
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public string? Comments { get; init; }
    public int HoursSpent { get; init; }
    public int Complexity { get; init; } 
}