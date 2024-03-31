using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Models.Entities;

public class SalesManager
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string UserId { get; set; } 
    public IdentityUser User { get; set; }
    public int ProjectManagerId { get; set; } 
    public ProjectManager ProjectManager { get; set; }
    
    public List<Account> Accounts { get; set; }
    public List<Developer> Developers { get; set; }
    public List<ReportFeedback> ReportFeedbacks { get; set; }
    public List<SalesManagerReport> SalesManagerReports { get; set; }


}