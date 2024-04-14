using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.EMS.Models.Entities.Enums;

namespace Company.EMS.Models.Entities;

public class Engagement
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int Amount { get; set; } 
    public EngagementType EngagementType { get; set; }
    
    public List<SalesManagerReportEngagement> SalesManagerReportEngagements { get; set; }

}