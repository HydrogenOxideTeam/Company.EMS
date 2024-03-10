namespace Company.EMS.Models.Entities;

public class Project
{
    public string? Name { get; set; } 
    public string? Customer { get; set; } 
    public int ProjectTypeId { get; set; } 
    //public ProjectType ProjectType {get;set;}
    public int HoursLimit { get; set; } 
    public int Rate { get; set; } 
    public int AccountId { get; set; } 
    //public Account Account {get;set;}
    public int ProjectStatusId { get; set; } 
    //public ProjectStatus ProjectStatus {get;set;}
    public int CallerId { get; set; } 
    //public Caller Caller {get;set;}
    public DateTime Date { get; set; }

    public Project(string? name, string? customer, int projectTypeId, int hoursLimit, int rate, int accountId, 
        int projectStatusId, int callerId, DateTime date)
    {
        Name = name;
        Customer = customer;
        ProjectTypeId = projectTypeId;
        HoursLimit = hoursLimit;
        Rate = rate;
        AccountId = accountId;
        ProjectStatusId = projectStatusId;
        CallerId = callerId;
        Date = date;
    }
}