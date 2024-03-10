namespace Company.EMS.Models.Entities;

public class ReportFeedback
{
    public int SalesManagerId { get; set; } 
    //public SalesManager SalesManager {get;set;}
    public int DeveloperReportId { get; set; } 
    //public DeveloperReport DeveloperReport {get;set;}
    public int Rate { get; set; } 
    public DateOnly CreatedOn { get; set; }

    public ReportFeedback(int salesManagerId, int developerReportId, int rate, DateOnly createdOn)
    {
        SalesManagerId = salesManagerId;
        DeveloperReportId = developerReportId;
        Rate = rate;
        CreatedOn = createdOn;
    }
}