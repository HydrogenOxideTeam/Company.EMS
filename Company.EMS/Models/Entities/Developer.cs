namespace Company.EMS.Models.Entities;

public class Developer
{
    public Guid UserId { get; set; } 
    //public User User {get;set;}
    public int SalesManagerId { get; set; } 
    //public SalesManager SalesManager {get;set;}
    public int ProjectManagerId { get; set; } 
    //public ProjectManager ProjectManager {get;set;}
    public int ProgrammerTypeId { get; set; } 
    //public ProgrammerType ProgrammerType {get;set;}
    public bool IsCaller { get; set; }

    public Developer(Guid userId, int salesManagerId, int projectManagerId, int programmerTypeId, bool isCaller)
    {
        UserId = userId;
        SalesManagerId = salesManagerId;
        ProjectManagerId = projectManagerId;
        ProgrammerTypeId = programmerTypeId;
        IsCaller = isCaller;
    }
}