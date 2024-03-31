using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class Technology
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<DeveloperTechnology> DeveloperTechnologies { get; set; }
    public List<ProjectTechnology> ProjectTechnologies { get; set; }

}