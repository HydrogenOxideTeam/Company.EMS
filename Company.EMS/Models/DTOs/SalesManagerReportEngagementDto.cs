namespace Company.EMS.Models.DTOs;

public record SalesManagerReportEngagementDto()
{
    public int Id { get; init; }
    public int SalesManagerReportId { get; init; } 
    public int EngagementId { get; init; } 
}