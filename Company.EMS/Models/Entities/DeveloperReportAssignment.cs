using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class DeveloperReportAssignment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public int DeveloperReportId { get; set; } 
    public int AssignmentId { get; set; } 
    
    public DeveloperReportAssignment(int developerReportId, int assignmentId)
    {
        DeveloperReportId = developerReportId;
        AssignmentId = assignmentId;
    }
}