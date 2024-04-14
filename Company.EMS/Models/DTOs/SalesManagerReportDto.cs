namespace Company.EMS.Models.DTOs;

public record SalesManagerReportDto
{
    public int Id { get; init; }
    public int SalesManagerId { get; init; } 
    public int AccountId { get; init; } 
    public DateOnly Date { get; init; } 
    public int EngagementTotal { get; init; } 
    public string? Comments { get; init; } 
    public int ReportStatus { get; init; } 
}