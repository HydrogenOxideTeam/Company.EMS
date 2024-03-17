using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class SalesManagerReportEngagement
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public int SalesManagerReportId { get; set; } 
    public int EngagementId { get; set; } 
   
    public SalesManagerReportEngagement(int salesManagerReportId, int engagementId)
    {
        SalesManagerReportId = salesManagerReportId;
        EngagementId = engagementId;
    }
}