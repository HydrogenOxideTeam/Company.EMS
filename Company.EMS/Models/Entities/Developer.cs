using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class Developer
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public Guid UserId { get; set; } 
    public int SalesManagerId { get; set; } 
    public int ProjectManagerId { get; set; } 
    public int ProgrammerTypeId { get; set; } 
    public bool IsCaller { get; set; }

    public Developer(Guid userId, int salesManagerId, int projectManagerId, int programmerTypeId, bool isCaller)
    {
        UserId = userId;
        SalesManagerId = salesManagerId;
        ProjectManagerId = projectManagerId;
        ProgrammerTypeId = programmerTypeId;
        IsCaller = isCaller;
    }
}