using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Models.Entities;

public class UserProfile
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string UserId { get; set; } 
    public IdentityUser User { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; } 
    public string? PhoneNumber { get; set; } 
    public string? AvatarUrl { get; set; } 
    public DateOnly Date { get; set; }
}