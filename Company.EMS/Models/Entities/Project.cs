using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.EMS.Models.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Models.Entities;

public class Project
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? Name { get; set; } 
    public string? Customer { get; set; } 
    public ProjectType ProjectType { get; set; }
    public int HoursLimit { get; set; } 
    public int Rate { get; set; } 
    public int AccountId { get; set; } 
    public Account Account { get; set; }
    public ProjectStatus ProjectStatus { get; set; }
    public string CallerId { get; set; } 
    public IdentityUser Caller { get; set; }
    public DateTime Date { get; set; }
    
    public List<DeveloperProject> DeveloperProjects { get; set; }
    public List<DeveloperReport> DeveloperReports { get; set; }
    public List<ProjectTechnology> ProjectTechnologies { get; set; }


}