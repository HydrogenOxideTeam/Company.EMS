namespace Company.EMS.Models.DTOs;

public record ReportFeedbackDto
{
    public int Id { get; init; }
    public int SalesManagerId { get; init; } 
    //public SalesManager SalesManager {get;init;}
    public int DeveloperReportId { get; init; } 
    //public DeveloperReport DeveloperReport {get;init;}
    public int Rate { get; init; } 
    public DateOnly CreatedOn { get; init; }
}