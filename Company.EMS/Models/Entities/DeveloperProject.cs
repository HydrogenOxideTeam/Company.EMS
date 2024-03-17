using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class DeveloperProject
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public int ProjectId { get; set; } 
    public int DeveloperId { get; set; } 
    public DeveloperProject(int projectId, int developerId)
    {
        ProjectId = projectId;
        DeveloperId = developerId;
    }
}