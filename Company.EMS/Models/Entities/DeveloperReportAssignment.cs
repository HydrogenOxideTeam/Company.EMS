namespace Company.EMS.Models.Entities;

public class DeveloperReportAssignment
{
    public int DeveloperReportId { get; set; } 
    //public DeveloperReport DeveloperReport {get;set;}
    public int TaskId { get; set; } 
    //public Task Task {get;set;}
    public DeveloperReportAssignment(int developerReportId, int taskId)
    {
        DeveloperReportId = developerReportId;
        TaskId = taskId;
    }
}