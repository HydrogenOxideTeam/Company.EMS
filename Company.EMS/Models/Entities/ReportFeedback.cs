using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class ReportFeedback
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public int SalesManagerId { get; set; } 
    public int DeveloperReportId { get; set; } 
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