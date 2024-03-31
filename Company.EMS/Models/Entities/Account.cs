using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Company.EMS.Models.Entities;

public class Account
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int SalesManagerId { get; set; } 
    public SalesManager SalesManager { get; set; }
    public string? Email { get; set; }
    public string? EmailPassword { get; set; }
    public string? GitHub { get; set; }
    public string? GitHubPassword { get; set; }
    public string? PhoneNumber { get; set; }
    
    public List<Project> Projects { get; set; }
    public List<SalesManagerReport> SalesManagerReports { get; set; }

}