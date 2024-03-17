using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class DeveloperReport
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public int DeveloperId { get; set; } 
    public int ProjectId { get; set; } 
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