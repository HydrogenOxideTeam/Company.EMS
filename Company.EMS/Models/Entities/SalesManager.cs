namespace Company.EMS.Models.Entities;

public class SalesManager
{
    public Guid UserId { get; set; } 
    //public User User {get;set;}
    public int ProjectManagerId { get; set; } 
    //public ProjectManager ProjectManager {get;set;}
    public SalesManager(Guid userId, int projectManagerId)
    {
        UserId = userId;
        ProjectManagerId = projectManagerId;
    }
}