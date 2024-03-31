using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class ReportFeedback
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int SalesManagerId { get; set; }
    public SalesManager SalesManager { get; set; }
    public int DeveloperReportId { get; set; } 
    public DeveloperReport DeveloperReport { get; set; }
    public int Rate { get; set; } 
    public DateOnly CreatedOn { get; set; }
}