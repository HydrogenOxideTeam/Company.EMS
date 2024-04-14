namespace Company.EMS.Models.DTOs;

public record DeveloperReportAssigmentDto()
{
    public int Id { get; init; }
    public int DeveloperReportId { get; init; } 
    public int AssignmentId { get; init; } 
}