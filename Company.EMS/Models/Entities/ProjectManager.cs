using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class ProjectManager
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public Guid UserId { get; set; } 
    
    public ProjectManager(Guid userId)
    {
        UserId = userId;
    }
}