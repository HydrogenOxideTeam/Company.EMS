using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class DeveloperReportAssignment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int DeveloperReportId { get; set; } 
    public DeveloperReport DeveloperReport { get; set; }
    public int AssignmentId { get; set; } 
    public Assignment Assignment { get; set; }
}