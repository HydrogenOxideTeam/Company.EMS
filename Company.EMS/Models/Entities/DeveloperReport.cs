using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class DeveloperReport
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int DeveloperId { get; set; }
    public Developer Developer { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; }
    public DateTime Date { get; set; }
    public int TotalHoursSpent { get; set; } 
    public string? Comments { get; set; } 
    public int ReportStatusId { get; set; }
    public ReportStatus ReportStatus { get; set; }
    
    public List<DeveloperReportAssignment> DeveloperReportAssignments { get; set; }
    public List<ReportFeedback> ReportFeedbacks { get; set; }

}