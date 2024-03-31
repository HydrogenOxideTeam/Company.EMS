using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class DeveloperTechnology
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int DeveloperId { get; set; } 
    public Developer Developer { get; set; }
    public int TechnologyId { get; set; } 
    public Technology Technology { get; set; }
}