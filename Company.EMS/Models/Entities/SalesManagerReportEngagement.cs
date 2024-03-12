namespace Company.EMS.Models.Entities;

public class SalesManagerReportEngagement
{
    public int SalesManagerReportId { get; set; } 
    //public  SalesManagerReport  SalesManagerReport {get;set;}
    public int EngagementId { get; set; } 
    //public  Engagement Engagement {get;set;}
    public SalesManagerReportEngagement(int salesManagerReportId, int engagementId)
    {
        SalesManagerReportId = salesManagerReportId;
        EngagementId = engagementId;
    }
}