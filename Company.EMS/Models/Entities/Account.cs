using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class Account
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int SalesManagerId { get; set; } 
    public string? Email { get; set; }
    public string? EmailPassword { get; set; }
    public string? GitHub { get; set; }
    public string? GitHubPassword { get; set; }
    public string? PhoneNumber { get; set; }

    public Account(string? firstName, string? lastName, int salesManagerId, string? email, string? emailPassword, 
        string? gitHub, string? gitHubPassword, string? phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        SalesManagerId = salesManagerId;
        Email = email;
        EmailPassword = emailPassword;
        GitHub = gitHub;
        GitHubPassword = gitHubPassword;
        PhoneNumber = phoneNumber;
    }
}