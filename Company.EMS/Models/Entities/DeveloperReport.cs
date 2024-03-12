using System.Runtime.InteropServices.JavaScript;

namespace Company.EMS.Models.Entities;

public class DeveloperReport
{
    public int DeveloperId { get; set; } 
    //public Developer Developer {get;set;}
    public int ProjectId { get; set; } 
    //public Project Project {get;set;}
    public DateTime Date { get; set; }
    public int TotalHoursSpent { get; set; } 
    public string? Comments { get; set; } 
    public int ReportStatusId { get; set; }

    public DeveloperReport(int developerId, int projectId, DateTime date, int totalHoursSpent, string? comments, int reportStatusId)
    {
        DeveloperId = developerId;
        ProjectId = projectId;
        Date = date;
        TotalHoursSpent = totalHoursSpent;
        Comments = comments;
        ReportStatusId = reportStatusId;
    }
}