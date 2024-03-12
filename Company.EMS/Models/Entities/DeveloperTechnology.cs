namespace Company.EMS.Models.Entities;

public class DeveloperTechnology
{
    public int DeveloperId { get; set; } 
    //public Developer Developer {get;set;}
    public int TechnologyId { get; set; } 
    //public Technology Technology {get;set;}
    public DeveloperTechnology(int developerId, int technologyId)
    {
        DeveloperId = developerId;
        TechnologyId = technologyId;
    }
}