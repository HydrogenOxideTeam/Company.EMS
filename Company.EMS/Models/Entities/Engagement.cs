namespace Company.EMS.Models.Entities;

public class Engagement
{
    public int Amount { get; set; } 
    public int EngagementTypeId { get; set; } 
    //public EngagementType EngagementType {get;set;}
    public Engagement(int amount, int engagementTypeId)
    {
        Amount = amount;
        EngagementTypeId = engagementTypeId;
    }
}