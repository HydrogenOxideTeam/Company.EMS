namespace Company.EMS.Models.DTOs;

public record SalesManagerDto()
{
    public int Id { get; init; }
    public Guid UserId { get; init; } 
    public int ProjectManagerId { get; init; } 
}