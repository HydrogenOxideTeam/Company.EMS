namespace Company.EMS.Models.Entities;

public class ProjectManager
{
    public Guid UserId { get; set; } 
    //public User User {get;set;}
    public ProjectManager(Guid userId)
    {
        UserId = userId;
    }
}