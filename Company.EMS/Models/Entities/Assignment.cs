using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class Assignment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Comments { get; set; }
    public string HoursSpent { get; set; }
    public int ComplexityId { get; set; } 
    
    public Assignment(string? name, string? comments, string hoursSpent, int complexityId)
    {
        Name = name;
        Comments = comments;
        HoursSpent = hoursSpent;
        ComplexityId = complexityId;
    }
}