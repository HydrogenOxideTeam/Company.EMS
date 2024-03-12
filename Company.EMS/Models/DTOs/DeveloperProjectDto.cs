namespace Company.EMS.Models.DTOs;

public record DeveloperProjectDto
{
    public int Id { get; init; }
    public int ProjectId { get; init; } 
    //public Project Project {get;init;}
    public int DeveloperId { get; init; } 
    //public Developer Developer {get;init;}
}