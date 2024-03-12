namespace Company.EMS.Models.Entities;

public class DeveloperProject
{
    public int ProjectId { get; set; } 
    //public Project Project {get;set;}
    public int DeveloperId { get; set; } 
    //public Developer Developer {get;set;}
    public DeveloperProject(int projectId, int developerId)
    {
        ProjectId = projectId;
        DeveloperId = developerId;
    }
}