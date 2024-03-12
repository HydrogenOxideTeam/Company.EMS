namespace Company.EMS.Models.DTOs;

public record AssigmentDto
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public string? Comments { get; init; }
    public string HoursSpent { get; init; }
    public int ComplexityId { get; init; } 
    //public Complexity Complexity {get;init;}
}