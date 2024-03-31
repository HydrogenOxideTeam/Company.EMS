using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Models.Entities;

public class ProjectManager
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string UserId { get; set; } 
    public IdentityUser User { get; set; } 
    
    public List<Developer> Developers { get; set; }
    public List<SalesManager> SalesManagers { get; set; }

}