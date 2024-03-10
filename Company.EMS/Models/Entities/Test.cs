namespace Company.EMS.Models.Entities;

public class Test
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Test(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}