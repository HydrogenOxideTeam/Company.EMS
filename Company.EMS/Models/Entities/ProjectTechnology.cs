using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class ProjectTechnology
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public int ProjectId { get; set; } 
    public int TechnologyId { get; set; } 

    public ProjectTechnology(int projectId, int technologyId)
    {
        ProjectId = projectId;
        TechnologyId = technologyId;
    }
}