using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class Engagement
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public int Amount { get; set; } 
    public int EngagementTypeId { get; set; } 
   
    public Engagement(int amount, int engagementTypeId)
    {
        Amount = amount;
        EngagementTypeId = engagementTypeId;
    }
}