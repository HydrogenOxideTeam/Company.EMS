using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class SalesManager
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public Guid UserId { get; set; } 
    public int ProjectManagerId { get; set; } 
   
    public SalesManager(Guid userId, int projectManagerId)
    {
        UserId = userId;
        ProjectManagerId = projectManagerId;
    }
}