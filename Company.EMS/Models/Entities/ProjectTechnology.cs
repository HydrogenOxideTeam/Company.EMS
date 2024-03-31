using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class ProjectTechnology
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int ProjectId { get; set; } 
    public Project Project { get; set; }
    public int TechnologyId { get; set; } 
    public Technology Technology { get; set; }
}