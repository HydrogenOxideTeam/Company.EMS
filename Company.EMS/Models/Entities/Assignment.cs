namespace Company.EMS.Models.Entities;

public class Assignment
{
    public string? Name { get; set; }
    public string? Comments { get; set; }
    public string HoursSpent { get; set; }
    public int ComplexityId { get; set; } 
    //public Complexity Complexity {get;set;}
    public Assignment(string? name, string? comments, string hoursSpent, int complexityId)
    {
        Name = name;
        Comments = comments;
        HoursSpent = hoursSpent;
        ComplexityId = complexityId;
    }
}