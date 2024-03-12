namespace Company.EMS.Models.DTOs;

public record DeveloperReportDto
{
    public int Id { get; init; }
    public int DeveloperId { get; init; } 
    //public Developer Developer {get;init;}
    public int ProjectId { get; init; } 
    //public Project Project {get;init;}
    public DateTime Date { get; init; }
    public int TotalHoursSpent { get; init; } 
    public string? Comments { get; init; } 
    public int ReportStatusId { get; init; }
}