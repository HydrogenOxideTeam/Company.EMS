using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.EMS.Models.Entities.Enums;

namespace Company.EMS.Models.Entities;

public class Assignment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Comments { get; set; }
    public string HoursSpent { get; set; }
    public Complexity Complexity { get; set; }
    
    public List<DeveloperReportAssignment> DeveloperReportAssignments { get; set; }

}