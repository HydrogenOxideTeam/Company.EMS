using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class SalesManagerReportEngagement
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int SalesManagerReportId { get; set; } 
    public SalesManagerReport SalesManagerReport { get; set; } 
    public int EngagementId { get; set; } 
    public Engagement Engagement { get; set; } 
}