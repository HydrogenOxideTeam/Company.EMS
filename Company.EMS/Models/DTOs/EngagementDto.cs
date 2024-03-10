namespace Company.EMS.Models.DTOs;

public record EngagementDto
{
    public int Id { get; init; }
    public int Amount { get; init; } 
    public int EngagementTypeId { get; init; } 
    //public EngagementType EngagementType {get;init;}
}