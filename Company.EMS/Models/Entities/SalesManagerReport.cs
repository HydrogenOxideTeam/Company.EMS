namespace Company.EMS.Models.Entities;

public class SalesManagerReport
{
    public int SalesManagerId { get; set; } 
    //public SalesManager SalesManager {get;set;}
    public int AccountId { get; set; } 
    //public Account Account {get;set;}
    public DateOnly Date { get; set; } 
    public int EngagementTotal { get; set; } 
    public string Comments { get; set; } 
    public int ReportStatusId { get; set; } 
    //public ReportStatus ReportStatus {get;set;}
    public SalesManagerReport(int salesManagerId, int accountId, DateOnly date, int engagementTotal, string comments, int reportStatusId)
    {
        SalesManagerId = salesManagerId;
        AccountId = accountId;
        Date = date;
        EngagementTotal = engagementTotal;
        Comments = comments;
        ReportStatusId = reportStatusId;
    }
}