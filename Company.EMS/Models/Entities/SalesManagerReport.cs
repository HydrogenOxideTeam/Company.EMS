using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.EMS.Models.Entities.Enums;

namespace Company.EMS.Models.Entities;

public class SalesManagerReport
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int SalesManagerId { get; set; } 
    public SalesManager SalesManager { get; set; } 
    public int AccountId { get; set; }
    public Account Account { get; set; } 
    public DateOnly Date { get; set; } 
    public int EngagementTotal { get; set; } 
    public string Comments { get; set; } 
    public ReportStatus ReportStatus { get; set; } 
    
    public List<SalesManagerReportEngagement> SalesManagerReportEngagements { get; set; }

}