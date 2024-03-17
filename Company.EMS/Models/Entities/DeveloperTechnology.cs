using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class DeveloperTechnology
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public int DeveloperId { get; set; } 
    public int TechnologyId { get; set; } 

    public DeveloperTechnology(int developerId, int technologyId)
    {
        DeveloperId = developerId;
        TechnologyId = technologyId;
    }
}