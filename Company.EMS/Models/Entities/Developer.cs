using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.EMS.Models.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Models.Entities;

public class Developer
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string UserId { get; set; } 
    public IdentityUser User { get; set; }
    public int SalesManagerId { get; set; } 
    public SalesManager SalesManager { get; set; }
    public int ProjectManagerId { get; set; }
    public ProjectManager ProjectManager { get; set; }
    public ProgrammerType ProgrammerType { get; set; }
    public bool IsCaller { get; set; }
    
    public List<DeveloperProject> DeveloperProjects { get; set; }
    public List<DeveloperReport> DeveloperReports { get; set; }
    public List<DeveloperTechnology> DeveloperTechnologies { get; set; }

}