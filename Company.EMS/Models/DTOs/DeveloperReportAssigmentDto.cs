namespace Company.EMS.Models.DTOs;

public record DeveloperReportAssigmentDto
{
    public int Id { get; init; }
    public int DeveloperReportId { get; init; } 
    //public DeveloperReport DeveloperReport {get;init;}
    public int TaskId { get; init; } 
    //public Task Task {get;init;}
}